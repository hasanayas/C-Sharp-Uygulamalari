
namespace BirdenFazlaSyfYazdirma_Sayfa175_176
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
            this.yazdir = new System.Windows.Forms.Button();
            this.baskionizleme = new System.Windows.Forms.Button();
            this.sayfaayari = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // yazdir
            // 
            this.yazdir.Location = new System.Drawing.Point(214, 75);
            this.yazdir.Name = "yazdir";
            this.yazdir.Size = new System.Drawing.Size(135, 62);
            this.yazdir.TabIndex = 0;
            this.yazdir.Text = "Yazdır";
            this.yazdir.UseVisualStyleBackColor = true;
            this.yazdir.Click += new System.EventHandler(this.yazdir_Click);
            // 
            // baskionizleme
            // 
            this.baskionizleme.Location = new System.Drawing.Point(214, 181);
            this.baskionizleme.Name = "baskionizleme";
            this.baskionizleme.Size = new System.Drawing.Size(135, 62);
            this.baskionizleme.TabIndex = 1;
            this.baskionizleme.Text = "Baskı Ön İzleme";
            this.baskionizleme.UseVisualStyleBackColor = true;
            this.baskionizleme.Click += new System.EventHandler(this.baskionizleme_Click);
            // 
            // sayfaayari
            // 
            this.sayfaayari.Location = new System.Drawing.Point(214, 300);
            this.sayfaayari.Name = "sayfaayari";
            this.sayfaayari.Size = new System.Drawing.Size(135, 62);
            this.sayfaayari.TabIndex = 2;
            this.sayfaayari.Text = "Sayfa Ayarı";
            this.sayfaayari.UseVisualStyleBackColor = true;
            this.sayfaayari.Click += new System.EventHandler(this.sayfaayari_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sayfaayari);
            this.Controls.Add(this.baskionizleme);
            this.Controls.Add(this.yazdir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yazdir;
        private System.Windows.Forms.Button baskionizleme;
        private System.Windows.Forms.Button sayfaayari;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

