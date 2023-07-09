
namespace FontIslemleri_Sayfa62
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
            this.buttonKalin = new System.Windows.Forms.Button();
            this.buttonEgik = new System.Windows.Forms.Button();
            this.buttonAlt = new System.Windows.Forms.Button();
            this.button4ust = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 0;
            // 
            // buttonKalin
            // 
            this.buttonKalin.Location = new System.Drawing.Point(34, 360);
            this.buttonKalin.Name = "buttonKalin";
            this.buttonKalin.Size = new System.Drawing.Size(103, 38);
            this.buttonKalin.TabIndex = 1;
            this.buttonKalin.Text = "Kalın";
            this.buttonKalin.UseVisualStyleBackColor = true;
            this.buttonKalin.Click += new System.EventHandler(this.buttonKalin_Click);
            // 
            // buttonEgik
            // 
            this.buttonEgik.Location = new System.Drawing.Point(171, 360);
            this.buttonEgik.Name = "buttonEgik";
            this.buttonEgik.Size = new System.Drawing.Size(103, 38);
            this.buttonEgik.TabIndex = 2;
            this.buttonEgik.Text = "Eğik";
            this.buttonEgik.UseVisualStyleBackColor = true;
            this.buttonEgik.Click += new System.EventHandler(this.buttonEgik_Click);
            // 
            // buttonAlt
            // 
            this.buttonAlt.Location = new System.Drawing.Point(305, 360);
            this.buttonAlt.Name = "buttonAlt";
            this.buttonAlt.Size = new System.Drawing.Size(103, 38);
            this.buttonAlt.TabIndex = 3;
            this.buttonAlt.Text = "Altı Çizili";
            this.buttonAlt.UseVisualStyleBackColor = true;
            this.buttonAlt.Click += new System.EventHandler(this.buttonAlt_Click);
            // 
            // button4ust
            // 
            this.button4ust.Location = new System.Drawing.Point(440, 360);
            this.button4ust.Name = "button4ust";
            this.button4ust.Size = new System.Drawing.Size(103, 38);
            this.button4ust.TabIndex = 4;
            this.button4ust.Text = "Üstü Çizili";
            this.button4ust.UseVisualStyleBackColor = true;
            this.button4ust.Click += new System.EventHandler(this.button4ust_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(658, 371);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Font Boyutu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button4ust);
            this.Controls.Add(this.buttonAlt);
            this.Controls.Add(this.buttonEgik);
            this.Controls.Add(this.buttonKalin);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonKalin;
        private System.Windows.Forms.Button buttonEgik;
        private System.Windows.Forms.Button buttonAlt;
        private System.Windows.Forms.Button button4ust;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}

