
namespace pictureBoxicindeResim_Syfa154
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
            this.button_dosyadanYukle = new System.Windows.Forms.Button();
            this.button_panodanyapistir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_normal = new System.Windows.Forms.RadioButton();
            this.radioButoon_sigdir = new System.Windows.Forms.RadioButton();
            this.radioButton_otoboyut = new System.Windows.Forms.RadioButton();
            this.radioButton_ortala = new System.Windows.Forms.RadioButton();
            this.checkBox_dose = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_dosyadanYukle
            // 
            this.button_dosyadanYukle.Location = new System.Drawing.Point(12, 23);
            this.button_dosyadanYukle.Name = "button_dosyadanYukle";
            this.button_dosyadanYukle.Size = new System.Drawing.Size(232, 23);
            this.button_dosyadanYukle.TabIndex = 0;
            this.button_dosyadanYukle.Text = "Resmi Dosyadan Yükle";
            this.button_dosyadanYukle.UseVisualStyleBackColor = true;
            this.button_dosyadanYukle.Click += new System.EventHandler(this.button_dosyadanYukle_Click);
            // 
            // button_panodanyapistir
            // 
            this.button_panodanyapistir.Location = new System.Drawing.Point(12, 52);
            this.button_panodanyapistir.Name = "button_panodanyapistir";
            this.button_panodanyapistir.Size = new System.Drawing.Size(232, 23);
            this.button_panodanyapistir.TabIndex = 1;
            this.button_panodanyapistir.Text = "Resmi Panodan Yapıştır";
            this.button_panodanyapistir.UseVisualStyleBackColor = true;
            this.button_panodanyapistir.Click += new System.EventHandler(this.button_panodanyapistir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gösterim Modu";
            // 
            // radioButton_normal
            // 
            this.radioButton_normal.AutoSize = true;
            this.radioButton_normal.Location = new System.Drawing.Point(272, 52);
            this.radioButton_normal.Name = "radioButton_normal";
            this.radioButton_normal.Size = new System.Drawing.Size(58, 17);
            this.radioButton_normal.TabIndex = 3;
            this.radioButton_normal.TabStop = true;
            this.radioButton_normal.Text = "Normal";
            this.radioButton_normal.UseVisualStyleBackColor = true;
            this.radioButton_normal.CheckedChanged += new System.EventHandler(this.radioButton_normal_CheckedChanged);
            // 
            // radioButoon_sigdir
            // 
            this.radioButoon_sigdir.AutoSize = true;
            this.radioButoon_sigdir.Location = new System.Drawing.Point(345, 52);
            this.radioButoon_sigdir.Name = "radioButoon_sigdir";
            this.radioButoon_sigdir.Size = new System.Drawing.Size(51, 17);
            this.radioButoon_sigdir.TabIndex = 4;
            this.radioButoon_sigdir.TabStop = true;
            this.radioButoon_sigdir.Text = "Sığdır";
            this.radioButoon_sigdir.UseVisualStyleBackColor = true;
            this.radioButoon_sigdir.CheckedChanged += new System.EventHandler(this.radioButoon_sigdir_CheckedChanged);
            // 
            // radioButton_otoboyut
            // 
            this.radioButton_otoboyut.AutoSize = true;
            this.radioButton_otoboyut.Location = new System.Drawing.Point(421, 52);
            this.radioButton_otoboyut.Name = "radioButton_otoboyut";
            this.radioButton_otoboyut.Size = new System.Drawing.Size(122, 17);
            this.radioButton_otoboyut.TabIndex = 5;
            this.radioButton_otoboyut.TabStop = true;
            this.radioButton_otoboyut.Text = "Otomatik Boyutlandır";
            this.radioButton_otoboyut.UseVisualStyleBackColor = true;
            this.radioButton_otoboyut.CheckedChanged += new System.EventHandler(this.radioButton_otoboyut_CheckedChanged);
            // 
            // radioButton_ortala
            // 
            this.radioButton_ortala.AutoSize = true;
            this.radioButton_ortala.Location = new System.Drawing.Point(549, 52);
            this.radioButton_ortala.Name = "radioButton_ortala";
            this.radioButton_ortala.Size = new System.Drawing.Size(53, 17);
            this.radioButton_ortala.TabIndex = 6;
            this.radioButton_ortala.TabStop = true;
            this.radioButton_ortala.Text = "Ortala";
            this.radioButton_ortala.UseVisualStyleBackColor = true;
            this.radioButton_ortala.CheckedChanged += new System.EventHandler(this.radioButton_ortala_CheckedChanged);
            // 
            // checkBox_dose
            // 
            this.checkBox_dose.AutoSize = true;
            this.checkBox_dose.Location = new System.Drawing.Point(624, 52);
            this.checkBox_dose.Name = "checkBox_dose";
            this.checkBox_dose.Size = new System.Drawing.Size(51, 17);
            this.checkBox_dose.TabIndex = 7;
            this.checkBox_dose.Text = "Döşe";
            this.checkBox_dose.UseVisualStyleBackColor = true;
            this.checkBox_dose.CheckedChanged += new System.EventHandler(this.checkBox_dose_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 158);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 575);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox_dose);
            this.Controls.Add(this.radioButton_ortala);
            this.Controls.Add(this.radioButton_otoboyut);
            this.Controls.Add(this.radioButoon_sigdir);
            this.Controls.Add(this.radioButton_normal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_panodanyapistir);
            this.Controls.Add(this.button_dosyadanYukle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_dosyadanYukle;
        private System.Windows.Forms.Button button_panodanyapistir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_normal;
        private System.Windows.Forms.RadioButton radioButoon_sigdir;
        private System.Windows.Forms.RadioButton radioButton_otoboyut;
        private System.Windows.Forms.RadioButton radioButton_ortala;
        private System.Windows.Forms.CheckBox checkBox_dose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

