namespace Ananı
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            ogrenciAdTxt = new TextBox();
            ogrenciSoyadTxt = new TextBox();
            ogrenciNumaraTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(337, 218);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ogrenciAdTxt
            // 
            ogrenciAdTxt.Location = new Point(327, 127);
            ogrenciAdTxt.Name = "ogrenciAdTxt";
            ogrenciAdTxt.Size = new Size(100, 23);
            ogrenciAdTxt.TabIndex = 1;
            // 
            // ogrenciSoyadTxt
            // 
            ogrenciSoyadTxt.Location = new Point(327, 156);
            ogrenciSoyadTxt.Name = "ogrenciSoyadTxt";
            ogrenciSoyadTxt.Size = new Size(100, 23);
            ogrenciSoyadTxt.TabIndex = 2;
            // 
            // ogrenciNumaraTxt
            // 
            ogrenciNumaraTxt.Location = new Point(327, 189);
            ogrenciNumaraTxt.Name = "ogrenciNumaraTxt";
            ogrenciNumaraTxt.Size = new Size(100, 23);
            ogrenciNumaraTxt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(271, 130);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 4;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(271, 159);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 192);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 6;
            label3.Text = "Numara";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 300);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 150);
            dataGridView1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ogrenciNumaraTxt);
            Controls.Add(ogrenciSoyadTxt);
            Controls.Add(ogrenciAdTxt);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox ogrenciAdTxt;
        private TextBox ogrenciSoyadTxt;
        private TextBox ogrenciNumaraTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
    }
}
