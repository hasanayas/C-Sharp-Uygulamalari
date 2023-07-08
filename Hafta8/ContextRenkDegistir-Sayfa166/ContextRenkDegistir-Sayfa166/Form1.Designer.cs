
namespace ContextRenkDegistir_Sayfa166
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.renkDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simgeDurumunaKüçültToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekranıKaplaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renkDeğiştirToolStripMenuItem,
            this.simgeDurumunaKüçültToolStripMenuItem,
            this.ekranıKaplaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(205, 92);
            // 
            // textBox1
            // 
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.Location = new System.Drawing.Point(469, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 20);
            this.textBox1.TabIndex = 1;
            // 
            // renkDeğiştirToolStripMenuItem
            // 
            this.renkDeğiştirToolStripMenuItem.Name = "renkDeğiştirToolStripMenuItem";
            this.renkDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.renkDeğiştirToolStripMenuItem.Text = "Renk Değiştir";
            this.renkDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.renkDeğiştirToolStripMenuItem_Click);
            // 
            // simgeDurumunaKüçültToolStripMenuItem
            // 
            this.simgeDurumunaKüçültToolStripMenuItem.Name = "simgeDurumunaKüçültToolStripMenuItem";
            this.simgeDurumunaKüçültToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.simgeDurumunaKüçültToolStripMenuItem.Text = "Simge Durumuna Küçült";
            this.simgeDurumunaKüçültToolStripMenuItem.Click += new System.EventHandler(this.simgeDurumunaKüçültToolStripMenuItem_Click);
            // 
            // ekranıKaplaToolStripMenuItem
            // 
            this.ekranıKaplaToolStripMenuItem.Name = "ekranıKaplaToolStripMenuItem";
            this.ekranıKaplaToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.ekranıKaplaToolStripMenuItem.Text = "Ekranı Kapla";
            this.ekranıKaplaToolStripMenuItem.Click += new System.EventHandler(this.ekranıKaplaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem renkDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simgeDurumunaKüçültToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekranıKaplaToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
    }
}

