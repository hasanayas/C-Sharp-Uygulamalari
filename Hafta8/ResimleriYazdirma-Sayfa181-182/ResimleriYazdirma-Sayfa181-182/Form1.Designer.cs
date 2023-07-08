
namespace ResimleriYazdirma_Sayfa181_182
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resimSec = new System.Windows.Forms.Button();
            this.yazdir = new System.Windows.Forms.Button();
            this.onizle = new System.Windows.Forms.Button();
            this.sayfaYapisi = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 302);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // resimSec
            // 
            this.resimSec.Location = new System.Drawing.Point(388, 22);
            this.resimSec.Name = "resimSec";
            this.resimSec.Size = new System.Drawing.Size(142, 37);
            this.resimSec.TabIndex = 1;
            this.resimSec.Text = "Resim Seç";
            this.resimSec.UseVisualStyleBackColor = true;
            this.resimSec.Click += new System.EventHandler(this.resimSec_Click);
            // 
            // yazdir
            // 
            this.yazdir.Location = new System.Drawing.Point(388, 81);
            this.yazdir.Name = "yazdir";
            this.yazdir.Size = new System.Drawing.Size(142, 37);
            this.yazdir.TabIndex = 2;
            this.yazdir.Text = "Yazdır";
            this.yazdir.UseVisualStyleBackColor = true;
            this.yazdir.Click += new System.EventHandler(this.yazdir_Click);
            // 
            // onizle
            // 
            this.onizle.Location = new System.Drawing.Point(388, 141);
            this.onizle.Name = "onizle";
            this.onizle.Size = new System.Drawing.Size(142, 37);
            this.onizle.TabIndex = 3;
            this.onizle.Text = "Baskı Önizleme";
            this.onizle.UseVisualStyleBackColor = true;
            this.onizle.Click += new System.EventHandler(this.onizle_Click);
            // 
            // sayfaYapisi
            // 
            this.sayfaYapisi.Location = new System.Drawing.Point(388, 208);
            this.sayfaYapisi.Name = "sayfaYapisi";
            this.sayfaYapisi.Size = new System.Drawing.Size(142, 37);
            this.sayfaYapisi.TabIndex = 4;
            this.sayfaYapisi.Text = "Sayfa Yapısı";
            this.sayfaYapisi.UseVisualStyleBackColor = true;
            this.sayfaYapisi.Click += new System.EventHandler(this.sayfaYapisi_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(388, 268);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Resmi Sayfaya Sığdır";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(388, 306);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(128, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Resmi Sayfada Ortala";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.sayfaYapisi);
            this.Controls.Add(this.onizle);
            this.Controls.Add(this.yazdir);
            this.Controls.Add(this.resimSec);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button resimSec;
        private System.Windows.Forms.Button yazdir;
        private System.Windows.Forms.Button onizle;
        private System.Windows.Forms.Button sayfaYapisi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

