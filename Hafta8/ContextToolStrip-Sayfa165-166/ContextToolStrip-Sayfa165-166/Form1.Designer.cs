
namespace ContextToolStrip_Sayfa165_166
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.büyükHarfeÇEvirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.küçükHarfeÇevirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.Location = new System.Drawing.Point(539, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 20);
            this.textBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.büyükHarfeÇEvirToolStripMenuItem,
            this.küçükHarfeÇevirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(170, 48);
            // 
            // büyükHarfeÇEvirToolStripMenuItem
            // 
            this.büyükHarfeÇEvirToolStripMenuItem.Name = "büyükHarfeÇEvirToolStripMenuItem";
            this.büyükHarfeÇEvirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.büyükHarfeÇEvirToolStripMenuItem.Text = "Büyük Harfe Çevir";
            this.büyükHarfeÇEvirToolStripMenuItem.Click += new System.EventHandler(this.büyükHarfeÇEvirToolStripMenuItem_Click);
            // 
            // küçükHarfeÇevirToolStripMenuItem
            // 
            this.küçükHarfeÇevirToolStripMenuItem.Name = "küçükHarfeÇevirToolStripMenuItem";
            this.küçükHarfeÇevirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.küçükHarfeÇevirToolStripMenuItem.Text = "Küçük Harfe Çevir";
            this.küçükHarfeÇevirToolStripMenuItem.Click += new System.EventHandler(this.küçükHarfeÇevirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Context Menü İle Büyük-Küçüh Harfe Çevirme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Textboxta sağ tıklayın";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem büyükHarfeÇEvirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem küçükHarfeÇevirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

