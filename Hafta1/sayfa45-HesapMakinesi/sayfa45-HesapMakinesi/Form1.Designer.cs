namespace sayfa45_HesapMakinesi
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txt_sayi_giris = new System.Windows.Forms.TextBox();
            this.btn_MC = new System.Windows.Forms.Button();
            this.btn_MR = new System.Windows.Forms.Button();
            this.btn_Marti = new System.Windows.Forms.Button();
            this.btn_Meksi = new System.Windows.Forms.Button();
            this.btn_artieksi = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_karekok = new System.Windows.Forms.Button();
            this.btn_CE = new System.Windows.Forms.Button();
            this.btn_gerial = new System.Windows.Forms.Button();
            this.btn_kare = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btn_bol = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btn_birbolu = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.btn_carp = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.btn_cikar = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.btn_ondalikvirgul = new System.Windows.Forms.Button();
            this.btn_topla = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.btn_esittir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_sayi_giris
            // 
            this.txt_sayi_giris.Location = new System.Drawing.Point(55, 35);
            this.txt_sayi_giris.Name = "txt_sayi_giris";
            this.txt_sayi_giris.Size = new System.Drawing.Size(493, 20);
            this.txt_sayi_giris.TabIndex = 0;
            this.txt_sayi_giris.Click += new System.EventHandler(this.rakam_girisleri);
            this.txt_sayi_giris.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sayi_girisKeyPress);
            // 
            // btn_MC
            // 
            this.btn_MC.Location = new System.Drawing.Point(55, 74);
            this.btn_MC.Name = "btn_MC";
            this.btn_MC.Size = new System.Drawing.Size(72, 23);
            this.btn_MC.TabIndex = 1;
            this.btn_MC.Text = "MC";
            this.btn_MC.UseVisualStyleBackColor = true;
            this.btn_MC.Click += new System.EventHandler(this.hafiza_islem);
            // 
            // btn_MR
            // 
            this.btn_MR.Location = new System.Drawing.Point(158, 74);
            this.btn_MR.Name = "btn_MR";
            this.btn_MR.Size = new System.Drawing.Size(72, 23);
            this.btn_MR.TabIndex = 2;
            this.btn_MR.Text = "MR";
            this.btn_MR.UseVisualStyleBackColor = true;
            this.btn_MR.Click += new System.EventHandler(this.hafiza_islem);
            // 
            // btn_Marti
            // 
            this.btn_Marti.Location = new System.Drawing.Point(278, 74);
            this.btn_Marti.Name = "btn_Marti";
            this.btn_Marti.Size = new System.Drawing.Size(72, 23);
            this.btn_Marti.TabIndex = 4;
            this.btn_Marti.Text = "M+";
            this.btn_Marti.UseVisualStyleBackColor = true;
            this.btn_Marti.Click += new System.EventHandler(this.hafiza_islem);
            // 
            // btn_Meksi
            // 
            this.btn_Meksi.Location = new System.Drawing.Point(379, 74);
            this.btn_Meksi.Name = "btn_Meksi";
            this.btn_Meksi.Size = new System.Drawing.Size(72, 23);
            this.btn_Meksi.TabIndex = 3;
            this.btn_Meksi.Text = "M-";
            this.btn_Meksi.UseVisualStyleBackColor = true;
            this.btn_Meksi.Click += new System.EventHandler(this.hafiza_islem);
            // 
            // btn_artieksi
            // 
            this.btn_artieksi.Location = new System.Drawing.Point(476, 74);
            this.btn_artieksi.Name = "btn_artieksi";
            this.btn_artieksi.Size = new System.Drawing.Size(72, 23);
            this.btn_artieksi.TabIndex = 6;
            this.btn_artieksi.Text = "+ -";
            this.btn_artieksi.UseVisualStyleBackColor = true;
            this.btn_artieksi.Click += new System.EventHandler(this.btn_artieksi_Click);
            // 
            // btn_C
            // 
            this.btn_C.Location = new System.Drawing.Point(375, 120);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(72, 23);
            this.btn_C.TabIndex = 10;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_karekok
            // 
            this.btn_karekok.Location = new System.Drawing.Point(476, 120);
            this.btn_karekok.Name = "btn_karekok";
            this.btn_karekok.Size = new System.Drawing.Size(72, 23);
            this.btn_karekok.TabIndex = 9;
            this.btn_karekok.Text = "SQRT";
            this.btn_karekok.UseVisualStyleBackColor = true;
            this.btn_karekok.Click += new System.EventHandler(this.diger_islemler);
            // 
            // btn_CE
            // 
            this.btn_CE.Location = new System.Drawing.Point(278, 120);
            this.btn_CE.Name = "btn_CE";
            this.btn_CE.Size = new System.Drawing.Size(72, 23);
            this.btn_CE.TabIndex = 8;
            this.btn_CE.Text = "CE";
            this.btn_CE.UseVisualStyleBackColor = true;
            this.btn_CE.Click += new System.EventHandler(this.btn_CE_Click);
            // 
            // btn_gerial
            // 
            this.btn_gerial.Location = new System.Drawing.Point(55, 120);
            this.btn_gerial.Name = "btn_gerial";
            this.btn_gerial.Size = new System.Drawing.Size(175, 23);
            this.btn_gerial.TabIndex = 7;
            this.btn_gerial.Text = "<--------";
            this.btn_gerial.UseVisualStyleBackColor = true;
            this.btn_gerial.Click += new System.EventHandler(this.btn_gerial_Click);
            // 
            // btn_kare
            // 
            this.btn_kare.Location = new System.Drawing.Point(476, 170);
            this.btn_kare.Name = "btn_kare";
            this.btn_kare.Size = new System.Drawing.Size(72, 23);
            this.btn_kare.TabIndex = 15;
            this.btn_kare.Text = "X2";
            this.btn_kare.UseVisualStyleBackColor = true;
            this.btn_kare.Click += new System.EventHandler(this.diger_islemler);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(278, 170);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(72, 23);
            this.button11.TabIndex = 14;
            this.button11.Text = "9";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.rakam_girisleri);
            // 
            // btn_bol
            // 
            this.btn_bol.Location = new System.Drawing.Point(379, 170);
            this.btn_bol.Name = "btn_bol";
            this.btn_bol.Size = new System.Drawing.Size(72, 23);
            this.btn_bol.TabIndex = 13;
            this.btn_bol.Text = "/";
            this.btn_bol.UseVisualStyleBackColor = true;
            this.btn_bol.Click += new System.EventHandler(this.dort_islem);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(158, 170);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(72, 23);
            this.button13.TabIndex = 12;
            this.button13.Text = "8";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.rakam_girisleri);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(55, 170);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(72, 23);
            this.button14.TabIndex = 11;
            this.button14.Text = "7";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.rakam_girisleri);
            // 
            // btn_birbolu
            // 
            this.btn_birbolu.Location = new System.Drawing.Point(476, 221);
            this.btn_birbolu.Name = "btn_birbolu";
            this.btn_birbolu.Size = new System.Drawing.Size(72, 23);
            this.btn_birbolu.TabIndex = 20;
            this.btn_birbolu.Text = "1/x";
            this.btn_birbolu.UseVisualStyleBackColor = true;
            this.btn_birbolu.Click += new System.EventHandler(this.diger_islemler);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(278, 221);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(72, 23);
            this.button16.TabIndex = 19;
            this.button16.Text = "6";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.rakam_girisleri);
            // 
            // btn_carp
            // 
            this.btn_carp.Location = new System.Drawing.Point(379, 221);
            this.btn_carp.Name = "btn_carp";
            this.btn_carp.Size = new System.Drawing.Size(72, 23);
            this.btn_carp.TabIndex = 18;
            this.btn_carp.Text = "x";
            this.btn_carp.UseVisualStyleBackColor = true;
            this.btn_carp.Click += new System.EventHandler(this.dort_islem);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(158, 221);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(72, 23);
            this.button18.TabIndex = 17;
            this.button18.Text = "5";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.rakam_girisleri);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(55, 221);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(72, 23);
            this.button19.TabIndex = 16;
            this.button19.Text = "4";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.rakam_girisleri);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(278, 269);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(72, 23);
            this.button20.TabIndex = 24;
            this.button20.Text = "3";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.rakam_girisleri);
            // 
            // btn_cikar
            // 
            this.btn_cikar.Location = new System.Drawing.Point(379, 269);
            this.btn_cikar.Name = "btn_cikar";
            this.btn_cikar.Size = new System.Drawing.Size(72, 23);
            this.btn_cikar.TabIndex = 23;
            this.btn_cikar.Text = "-";
            this.btn_cikar.UseVisualStyleBackColor = true;
            this.btn_cikar.Click += new System.EventHandler(this.dort_islem);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(158, 269);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(72, 23);
            this.button22.TabIndex = 22;
            this.button22.Text = "2";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.rakam_girisleri);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(55, 269);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(72, 23);
            this.button23.TabIndex = 21;
            this.button23.Text = "1";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.rakam_girisleri);
            // 
            // btn_ondalikvirgul
            // 
            this.btn_ondalikvirgul.Location = new System.Drawing.Point(278, 315);
            this.btn_ondalikvirgul.Name = "btn_ondalikvirgul";
            this.btn_ondalikvirgul.Size = new System.Drawing.Size(72, 23);
            this.btn_ondalikvirgul.TabIndex = 26;
            this.btn_ondalikvirgul.Text = ".";
            this.btn_ondalikvirgul.UseVisualStyleBackColor = true;
            this.btn_ondalikvirgul.Click += new System.EventHandler(this.btn_ondalikvirgul_Click);
            // 
            // btn_topla
            // 
            this.btn_topla.Location = new System.Drawing.Point(379, 315);
            this.btn_topla.Name = "btn_topla";
            this.btn_topla.Size = new System.Drawing.Size(72, 23);
            this.btn_topla.TabIndex = 25;
            this.btn_topla.Text = "+";
            this.btn_topla.UseVisualStyleBackColor = true;
            this.btn_topla.Click += new System.EventHandler(this.dort_islem);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(55, 315);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(175, 23);
            this.button27.TabIndex = 27;
            this.button27.Text = "0";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.rakam_girisleri);
            // 
            // btn_esittir
            // 
            this.btn_esittir.Location = new System.Drawing.Point(476, 269);
            this.btn_esittir.Name = "btn_esittir";
            this.btn_esittir.Size = new System.Drawing.Size(72, 69);
            this.btn_esittir.TabIndex = 28;
            this.btn_esittir.Text = "=";
            this.btn_esittir.UseVisualStyleBackColor = true;
            this.btn_esittir.Click += new System.EventHandler(this.btn_esittir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_esittir);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.btn_ondalikvirgul);
            this.Controls.Add(this.btn_topla);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.btn_cikar);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.btn_birbolu);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.btn_carp);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.btn_kare);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btn_bol);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_karekok);
            this.Controls.Add(this.btn_CE);
            this.Controls.Add(this.btn_gerial);
            this.Controls.Add(this.btn_artieksi);
            this.Controls.Add(this.btn_Marti);
            this.Controls.Add(this.btn_Meksi);
            this.Controls.Add(this.btn_MR);
            this.Controls.Add(this.btn_MC);
            this.Controls.Add(this.txt_sayi_giris);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.hafiza_islem);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txt_sayi_giris;
        private System.Windows.Forms.Button btn_MC;
        private System.Windows.Forms.Button btn_MR;
        private System.Windows.Forms.Button btn_Marti;
        private System.Windows.Forms.Button btn_Meksi;
        private System.Windows.Forms.Button btn_artieksi;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_karekok;
        private System.Windows.Forms.Button btn_CE;
        private System.Windows.Forms.Button btn_gerial;
        private System.Windows.Forms.Button btn_kare;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btn_bol;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btn_birbolu;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button btn_carp;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button btn_cikar;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button btn_ondalikvirgul;
        private System.Windows.Forms.Button btn_topla;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button btn_esittir;
    }
}

