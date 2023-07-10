
namespace Koordinat_Sayfa65_66
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
            this.numericUpDownSol = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGenislik = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownUst = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYukseklik = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenislik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYukseklik)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 0;
            // 
            // numericUpDownSol
            // 
            this.numericUpDownSol.Location = new System.Drawing.Point(101, 230);
            this.numericUpDownSol.Name = "numericUpDownSol";
            this.numericUpDownSol.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSol.TabIndex = 1;
            this.numericUpDownSol.ValueChanged += new System.EventHandler(this.numericUpDownSol_ValueChanged);
            // 
            // numericUpDownGenislik
            // 
            this.numericUpDownGenislik.Location = new System.Drawing.Point(101, 292);
            this.numericUpDownGenislik.Name = "numericUpDownGenislik";
            this.numericUpDownGenislik.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownGenislik.TabIndex = 2;
            this.numericUpDownGenislik.ValueChanged += new System.EventHandler(this.numericUpDownGenislik_ValueChanged);
            // 
            // numericUpDownUst
            // 
            this.numericUpDownUst.Location = new System.Drawing.Point(354, 230);
            this.numericUpDownUst.Name = "numericUpDownUst";
            this.numericUpDownUst.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownUst.TabIndex = 3;
            this.numericUpDownUst.ValueChanged += new System.EventHandler(this.numericUpDownUst_ValueChanged);
            // 
            // numericUpDownYukseklik
            // 
            this.numericUpDownYukseklik.Location = new System.Drawing.Point(354, 292);
            this.numericUpDownYukseklik.Name = "numericUpDownYukseklik";
            this.numericUpDownYukseklik.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownYukseklik.TabIndex = 4;
            this.numericUpDownYukseklik.ValueChanged += new System.EventHandler(this.numericUpDownYukseklik_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Genişlik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yükseklik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Üst";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownYukseklik);
            this.Controls.Add(this.numericUpDownUst);
            this.Controls.Add(this.numericUpDownGenislik);
            this.Controls.Add(this.numericUpDownSol);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenislik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYukseklik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownSol;
        private System.Windows.Forms.NumericUpDown numericUpDownGenislik;
        private System.Windows.Forms.NumericUpDown numericUpDownUst;
        private System.Windows.Forms.NumericUpDown numericUpDownYukseklik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

