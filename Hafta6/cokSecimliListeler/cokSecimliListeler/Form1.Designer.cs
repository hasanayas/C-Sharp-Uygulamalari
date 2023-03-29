namespace cokSecimliListeler
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_siil = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_sagaAktar = new System.Windows.Forms.Button();
            this.btn_solaAktar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(37, 96);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 1;
            this.btn_ekle.Text = "ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_siil
            // 
            this.btn_siil.Location = new System.Drawing.Point(162, 96);
            this.btn_siil.Name = "btn_siil";
            this.btn_siil.Size = new System.Drawing.Size(75, 23);
            this.btn_siil.TabIndex = 2;
            this.btn_siil.Text = "sil";
            this.btn_siil.UseVisualStyleBackColor = true;
            this.btn_siil.Click += new System.EventHandler(this.btn_siil_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(37, 179);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 173);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(341, 179);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(200, 173);
            this.listBox2.TabIndex = 4;
            // 
            // btn_sagaAktar
            // 
            this.btn_sagaAktar.Location = new System.Drawing.Point(260, 217);
            this.btn_sagaAktar.Name = "btn_sagaAktar";
            this.btn_sagaAktar.Size = new System.Drawing.Size(60, 23);
            this.btn_sagaAktar.TabIndex = 5;
            this.btn_sagaAktar.Text = ">>";
            this.btn_sagaAktar.UseVisualStyleBackColor = true;
            this.btn_sagaAktar.Click += new System.EventHandler(this.btn_sagaAktar_Click);
            // 
            // btn_solaAktar
            // 
            this.btn_solaAktar.Location = new System.Drawing.Point(260, 269);
            this.btn_solaAktar.Name = "btn_solaAktar";
            this.btn_solaAktar.Size = new System.Drawing.Size(60, 23);
            this.btn_solaAktar.TabIndex = 6;
            this.btn_solaAktar.Text = "<<";
            this.btn_solaAktar.UseVisualStyleBackColor = true;
            this.btn_solaAktar.Click += new System.EventHandler(this.btn_solaAktar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_solaAktar);
            this.Controls.Add(this.btn_sagaAktar);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_siil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_siil;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_sagaAktar;
        private System.Windows.Forms.Button btn_solaAktar;
    }
}

