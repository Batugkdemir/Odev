using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;

namespace Ananı
{
    public partial class Form1 : Form
    {
        Ogrenci ogr = new Ogrenci();
        public Form1()
        {
            InitializeComponent();
        }

        string selectquery = "Select Ad,Soyad,Numara from Ogrenciler where Numara = @Numara";
        string insertquery = "Insert Into Ogrenciler (Ad, Soyad, Numara) values (@Ad,@Soyad,@Numara)";
        string connectionstring = @"Data Source=DESKTOP-HBR8SIT;initial catalog=Ogrenci;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework";

        private void button1_Click(object sender, EventArgs e)
        {
            ekle();
        }

        private void ekle()
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(insertquery, conn))
                    {
                        string noogrenci = ogrenciNumaraTxt.Text;
                        ogr.Numara = noogrenci;
                        string adogrenci = ogrenciAdTxt.Text;
                        ogr.Ad = adogrenci;
                        string soyadogrenci = ogrenciSoyadTxt.Text;
                        ogr.Soyad = soyadogrenci;
                        

                        cmd.Parameters.AddWithValue("@Ad", ogr.Ad);
                        cmd.Parameters.AddWithValue("@Soyad", ogr.Soyad);
                        cmd.Parameters.AddWithValue("@Numara", ogr.Numara);
                        int value = cmd.ExecuteNonQuery();
                        if (value > 0)
                        {
                            MessageBox.Show("Bağlantı Başarılı");
                            listele();
                        }
                        else { MessageBox.Show("Bağlantı Başarısız!"); }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Bir hata oluştu Komut Çalışmıyor" + ex.Message);
                }

            }
        }

        private void listele() 
        {
            using (SqlConnection conn = new SqlConnection(connectionstring)) 
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(selectquery,conn)) 
                    {
                        cmd.Parameters.AddWithValue("@Numara",ogr.Numara);
                        try
                        {
                            using (SqlDataReader list = cmd.ExecuteReader()) 
                            {
                                while (list.Read()) 
                                {
                                    TextBox textbox = new TextBox();
                                    textbox.Text = "Ogrenci Adı:" + list["Ad"].ToString()+"Ogrenci Soyadı: "+list["Soyad"].ToString()+"Ogrenci Numarası: "+list["Numara"].ToString() ;
                                    textbox.Visible = true;
                                    textbox.Focus();
                                    textbox.Multiline = true;
                                    textbox.ReadOnly = true;
                                    textbox.Width = 800;
                                    textbox.Height = 150;
                                    dataGridView1.Controls.Add(textbox);
                                }
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Bir hata Oluştu Reader!!"+ex.Message);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Bir Hata Oluştu Komutta!!"+ex.Message);
                }
            }
        }

       
    }
}
