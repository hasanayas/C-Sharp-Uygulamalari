
namespace HScrollBar_BackColor
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
            this.hScrollBar_kirmizi = new System.Windows.Forms.HScrollBar();
            this.hScrollBar_yesil = new System.Windows.Forms.HScrollBar();
            this.hScrollBar_mavi = new System.Windows.Forms.HScrollBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hScrollBar_kirmizi
            // 
            this.hScrollBar_kirmizi.Location = new System.Drawing.Point(127, 278);
            this.hScrollBar_kirmizi.Name = "hScrollBar_kirmizi";
            this.hScrollBar_kirmizi.Size = new System.Drawing.Size(345, 24);
            this.hScrollBar_kirmizi.TabIndex = 0;
            this.hScrollBar_kirmizi.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_kirmizi_Scroll);
            // 
            // hScrollBar_yesil
            // 
            this.hScrollBar_yesil.Location = new System.Drawing.Point(127, 324);
            this.hScrollBar_yesil.Name = "hScrollBar_yesil";
            this.hScrollBar_yesil.Size = new System.Drawing.Size(345, 24);
            this.hScrollBar_yesil.TabIndex = 1;
            this.hScrollBar_yesil.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_yesil_Scroll);
            // 
            // hScrollBar_mavi
            // 
            this.hScrollBar_mavi.Location = new System.Drawing.Point(127, 374);
            this.hScrollBar_mavi.Name = "hScrollBar_mavi";
            this.hScrollBar_mavi.Size = new System.Drawing.Size(345, 24);
            this.hScrollBar_mavi.TabIndex = 2;
            this.hScrollBar_mavi.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_mavi_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kırmızı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yeşil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mavi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(525, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.hScrollBar_mavi);
            this.Controls.Add(this.hScrollBar_yesil);
            this.Controls.Add(this.hScrollBar_kirmizi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar_kirmizi;
        private System.Windows.Forms.HScrollBar hScrollBar_yesil;
        private System.Windows.Forms.HScrollBar hScrollBar_mavi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

