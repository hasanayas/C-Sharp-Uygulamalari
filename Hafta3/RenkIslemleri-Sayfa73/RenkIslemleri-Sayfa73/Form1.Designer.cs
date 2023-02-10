namespace RenkIslemleri_Sayfa73
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.numericUpDown1_red = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2_green = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3_blue = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3_blue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(345, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasan Ayas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Arka plan Renk değiş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(383, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Yazı renk değiş";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1_red
            // 
            this.numericUpDown1_red.Location = new System.Drawing.Point(188, 283);
            this.numericUpDown1_red.Name = "numericUpDown1_red";
            this.numericUpDown1_red.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1_red.TabIndex = 3;
            this.numericUpDown1_red.ValueChanged += new System.EventHandler(this.numericUpDown1_red_ValueChanged);
            // 
            // numericUpDown2_green
            // 
            this.numericUpDown2_green.Location = new System.Drawing.Point(383, 283);
            this.numericUpDown2_green.Name = "numericUpDown2_green";
            this.numericUpDown2_green.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2_green.TabIndex = 4;
            this.numericUpDown2_green.ValueChanged += new System.EventHandler(this.numericUpDown2_green_ValueChanged);
            // 
            // numericUpDown3_blue
            // 
            this.numericUpDown3_blue.Location = new System.Drawing.Point(607, 282);
            this.numericUpDown3_blue.Name = "numericUpDown3_blue";
            this.numericUpDown3_blue.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3_blue.TabIndex = 5;
            this.numericUpDown3_blue.ValueChanged += new System.EventHandler(this.numericUpDown3_blue_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(527, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Panel için renk değerleri";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(593, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 42);
            this.button3.TabIndex = 8;
            this.button3.Text = "Kareler oluştur";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numericUpDown3_blue);
            this.Controls.Add(this.numericUpDown2_green);
            this.Controls.Add(this.numericUpDown1_red);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3_blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDown1_red;
        private System.Windows.Forms.NumericUpDown numericUpDown2_green;
        private System.Windows.Forms.NumericUpDown numericUpDown3_blue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}

