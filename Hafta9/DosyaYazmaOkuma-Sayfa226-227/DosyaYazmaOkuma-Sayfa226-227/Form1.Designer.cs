
namespace DosyaYazmaOkuma_Sayfa226_227
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
            this.Txt_adisoyadi = new System.Windows.Forms.TextBox();
            this.Txt_bolumu = new System.Windows.Forms.TextBox();
            this.Txt_babaadi = new System.Windows.Forms.TextBox();
            this.listBox_adisoyadi = new System.Windows.Forms.ListBox();
            this.listBox_bolumu = new System.Windows.Forms.ListBox();
            this.listBox_babaadi = new System.Windows.Forms.ListBox();
            this.Btn_ekle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrencinin Adı Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrencinin Bölümü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Öğrencinin Baba ADı";
            // 
            // Txt_adisoyadi
            // 
            this.Txt_adisoyadi.Location = new System.Drawing.Point(85, 91);
            this.Txt_adisoyadi.Name = "Txt_adisoyadi";
            this.Txt_adisoyadi.Size = new System.Drawing.Size(108, 20);
            this.Txt_adisoyadi.TabIndex = 3;
            // 
            // Txt_bolumu
            // 
            this.Txt_bolumu.Location = new System.Drawing.Point(268, 91);
            this.Txt_bolumu.Name = "Txt_bolumu";
            this.Txt_bolumu.Size = new System.Drawing.Size(108, 20);
            this.Txt_bolumu.TabIndex = 4;
            // 
            // Txt_babaadi
            // 
            this.Txt_babaadi.Location = new System.Drawing.Point(436, 91);
            this.Txt_babaadi.Name = "Txt_babaadi";
            this.Txt_babaadi.Size = new System.Drawing.Size(108, 20);
            this.Txt_babaadi.TabIndex = 5;
            // 
            // listBox_adisoyadi
            // 
            this.listBox_adisoyadi.FormattingEnabled = true;
            this.listBox_adisoyadi.Location = new System.Drawing.Point(85, 152);
            this.listBox_adisoyadi.Name = "listBox_adisoyadi";
            this.listBox_adisoyadi.Size = new System.Drawing.Size(108, 121);
            this.listBox_adisoyadi.TabIndex = 6;
            // 
            // listBox_bolumu
            // 
            this.listBox_bolumu.FormattingEnabled = true;
            this.listBox_bolumu.Location = new System.Drawing.Point(268, 152);
            this.listBox_bolumu.Name = "listBox_bolumu";
            this.listBox_bolumu.Size = new System.Drawing.Size(108, 121);
            this.listBox_bolumu.TabIndex = 7;
            // 
            // listBox_babaadi
            // 
            this.listBox_babaadi.FormattingEnabled = true;
            this.listBox_babaadi.Location = new System.Drawing.Point(436, 152);
            this.listBox_babaadi.Name = "listBox_babaadi";
            this.listBox_babaadi.Size = new System.Drawing.Size(108, 121);
            this.listBox_babaadi.TabIndex = 8;
            // 
            // Btn_ekle
            // 
            this.Btn_ekle.Location = new System.Drawing.Point(153, 311);
            this.Btn_ekle.Name = "Btn_ekle";
            this.Btn_ekle.Size = new System.Drawing.Size(136, 51);
            this.Btn_ekle.TabIndex = 9;
            this.Btn_ekle.Text = "Listeye Ekle";
            this.Btn_ekle.UseVisualStyleBackColor = true;
            this.Btn_ekle.Click += new System.EventHandler(this.Btn_ekle_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(378, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 51);
            this.button2.TabIndex = 10;
            this.button2.Text = "Listeden Sil";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_ekle);
            this.Controls.Add(this.listBox_babaadi);
            this.Controls.Add(this.listBox_bolumu);
            this.Controls.Add(this.listBox_adisoyadi);
            this.Controls.Add(this.Txt_babaadi);
            this.Controls.Add(this.Txt_bolumu);
            this.Controls.Add(this.Txt_adisoyadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_adisoyadi;
        private System.Windows.Forms.TextBox Txt_bolumu;
        private System.Windows.Forms.TextBox Txt_babaadi;
        private System.Windows.Forms.ListBox listBox_adisoyadi;
        private System.Windows.Forms.ListBox listBox_bolumu;
        private System.Windows.Forms.ListBox listBox_babaadi;
        private System.Windows.Forms.Button Btn_ekle;
        private System.Windows.Forms.Button button2;
    }
}

