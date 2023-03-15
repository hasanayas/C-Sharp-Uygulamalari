namespace Checkbox_Sayfa113_114
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Txt_birimfiyati = new System.Windows.Forms.TextBox();
            this.Txt_adet = new System.Windows.Forms.TextBox();
            this.Txt_tutar = new System.Windows.Forms.TextBox();
            this.checkBox_KDV = new System.Windows.Forms.CheckBox();
            this.checkBox_bayii = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Malzeme Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Birim Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tutar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Click += new System.EventHandler(this.islem_yap2);
            // 
            // Txt_birimfiyati
            // 
            this.Txt_birimfiyati.Location = new System.Drawing.Point(156, 72);
            this.Txt_birimfiyati.Name = "Txt_birimfiyati";
            this.Txt_birimfiyati.Size = new System.Drawing.Size(140, 20);
            this.Txt_birimfiyati.TabIndex = 5;
            this.Txt_birimfiyati.Click += new System.EventHandler(this.islem_yap2);
            // 
            // Txt_adet
            // 
            this.Txt_adet.Location = new System.Drawing.Point(156, 123);
            this.Txt_adet.Name = "Txt_adet";
            this.Txt_adet.Size = new System.Drawing.Size(140, 20);
            this.Txt_adet.TabIndex = 6;
            this.Txt_adet.Click += new System.EventHandler(this.islem_yap2);
            // 
            // Txt_tutar
            // 
            this.Txt_tutar.Location = new System.Drawing.Point(156, 252);
            this.Txt_tutar.Name = "Txt_tutar";
            this.Txt_tutar.Size = new System.Drawing.Size(140, 20);
            this.Txt_tutar.TabIndex = 7;
            this.Txt_tutar.Click += new System.EventHandler(this.islem_yap2);
            // 
            // checkBox_KDV
            // 
            this.checkBox_KDV.AutoSize = true;
            this.checkBox_KDV.Location = new System.Drawing.Point(156, 179);
            this.checkBox_KDV.Name = "checkBox_KDV";
            this.checkBox_KDV.Size = new System.Drawing.Size(71, 30);
            this.checkBox_KDV.TabIndex = 8;
            this.checkBox_KDV.Text = "%18 KDV\r\n\r\n";
            this.checkBox_KDV.UseVisualStyleBackColor = true;
            this.checkBox_KDV.Click += new System.EventHandler(this.ekle_indir2);
            // 
            // checkBox_bayii
            // 
            this.checkBox_bayii.AutoSize = true;
            this.checkBox_bayii.Location = new System.Drawing.Point(156, 212);
            this.checkBox_bayii.Name = "checkBox_bayii";
            this.checkBox_bayii.Size = new System.Drawing.Size(104, 17);
            this.checkBox_bayii.TabIndex = 9;
            this.checkBox_bayii.Text = "%25 BAyi indirimi";
            this.checkBox_bayii.UseVisualStyleBackColor = true;
            this.checkBox_bayii.Click += new System.EventHandler(this.ekle_indir2);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox_bayii);
            this.Controls.Add(this.checkBox_KDV);
            this.Controls.Add(this.Txt_tutar);
            this.Controls.Add(this.Txt_adet);
            this.Controls.Add(this.Txt_birimfiyati);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.ekle_indir2);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Txt_birimfiyati;
        private System.Windows.Forms.TextBox Txt_adet;
        private System.Windows.Forms.TextBox Txt_tutar;
        private System.Windows.Forms.CheckBox checkBox_KDV;
        private System.Windows.Forms.CheckBox checkBox_bayii;
        private System.Windows.Forms.Button button1;
    }
}

