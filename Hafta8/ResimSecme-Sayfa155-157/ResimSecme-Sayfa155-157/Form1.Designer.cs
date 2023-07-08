
namespace ResimSecme_Sayfa155_157
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
            this.resimyukle = new System.Windows.Forms.Button();
            this.kes = new System.Windows.Forms.Button();
            this.sagacevir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // resimyukle
            // 
            this.resimyukle.Location = new System.Drawing.Point(35, 30);
            this.resimyukle.Name = "resimyukle";
            this.resimyukle.Size = new System.Drawing.Size(105, 59);
            this.resimyukle.TabIndex = 0;
            this.resimyukle.Text = "Resim Yükle\r\n";
            this.resimyukle.UseVisualStyleBackColor = true;
            this.resimyukle.Click += new System.EventHandler(this.resimyukle_Click);
            // 
            // kes
            // 
            this.kes.Location = new System.Drawing.Point(194, 30);
            this.kes.Name = "kes";
            this.kes.Size = new System.Drawing.Size(105, 59);
            this.kes.TabIndex = 1;
            this.kes.Text = "Kes";
            this.kes.UseVisualStyleBackColor = true;
            this.kes.Click += new System.EventHandler(this.kes_Click);
            // 
            // sagacevir
            // 
            this.sagacevir.Location = new System.Drawing.Point(359, 30);
            this.sagacevir.Name = "sagacevir";
            this.sagacevir.Size = new System.Drawing.Size(105, 59);
            this.sagacevir.TabIndex = 2;
            this.sagacevir.Text = "20 Derece Sağa Çevir";
            this.sagacevir.UseVisualStyleBackColor = true;
            this.sagacevir.Click += new System.EventHandler(this.sagacevir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 99);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sagacevir);
            this.Controls.Add(this.kes);
            this.Controls.Add(this.resimyukle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resimyukle;
        private System.Windows.Forms.Button kes;
        private System.Windows.Forms.Button sagacevir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

