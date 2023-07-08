
namespace SaveFileDialog
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
            this.button_ac = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.button_farklikaydet = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // button_ac
            // 
            this.button_ac.Location = new System.Drawing.Point(49, 334);
            this.button_ac.Name = "button_ac";
            this.button_ac.Size = new System.Drawing.Size(161, 49);
            this.button_ac.TabIndex = 0;
            this.button_ac.Text = "Aç";
            this.button_ac.UseVisualStyleBackColor = true;
            this.button_ac.Click += new System.EventHandler(this.button_ac_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(49, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(635, 302);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // button_kaydet
            // 
            this.button_kaydet.Location = new System.Drawing.Point(290, 334);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(161, 49);
            this.button_kaydet.TabIndex = 2;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // button_farklikaydet
            // 
            this.button_farklikaydet.Location = new System.Drawing.Point(523, 334);
            this.button_farklikaydet.Name = "button_farklikaydet";
            this.button_farklikaydet.Size = new System.Drawing.Size(161, 49);
            this.button_farklikaydet.TabIndex = 3;
            this.button_farklikaydet.Text = "Farklı Kaydet";
            this.button_farklikaydet.UseVisualStyleBackColor = true;
            this.button_farklikaydet.Click += new System.EventHandler(this.button_farklikaydet_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_farklikaydet);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button_ac);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_ac;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.Button button_farklikaydet;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

