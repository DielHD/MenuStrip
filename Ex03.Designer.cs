namespace AppExemploMenu
{
    partial class Frm_03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_03));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Exibir = new System.Windows.Forms.ToolStripMenuItem();
            this.ExibirAmarelo = new System.Windows.Forms.ToolStripMenuItem();
            this.ExibirLaranja = new System.Windows.Forms.ToolStripMenuItem();
            this.ExibirAzul = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exibir});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // Exibir
            // 
            resources.ApplyResources(this.Exibir, "Exibir");
            this.Exibir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExibirAmarelo,
            this.ExibirLaranja,
            this.ExibirAzul});
            this.Exibir.Name = "Exibir";
            // 
            // ExibirAmarelo
            // 
            resources.ApplyResources(this.ExibirAmarelo, "ExibirAmarelo");
            this.ExibirAmarelo.Name = "ExibirAmarelo";
            this.ExibirAmarelo.Click += new System.EventHandler(this.ExibirAmarelo_Click);
            // 
            // ExibirLaranja
            // 
            resources.ApplyResources(this.ExibirLaranja, "ExibirLaranja");
            this.ExibirLaranja.Name = "ExibirLaranja";
            this.ExibirLaranja.Click += new System.EventHandler(this.ExibirLaranja_Click);
            // 
            // ExibirAzul
            // 
            resources.ApplyResources(this.ExibirAzul, "ExibirAzul");
            this.ExibirAzul.Name = "ExibirAzul";
            this.ExibirAzul.Click += new System.EventHandler(this.ExibirAzul_Click);
            // 
            // Frm_03
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.menuStrip1);
            this.Name = "Frm_03";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Exibir;
        private System.Windows.Forms.ToolStripMenuItem ExibirAmarelo;
        private System.Windows.Forms.ToolStripMenuItem ExibirLaranja;
        private System.Windows.Forms.ToolStripMenuItem ExibirAzul;
    }
}