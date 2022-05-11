namespace AppExemploMenu
{
    partial class Frm_01
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Exibir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ExibirAmarelo = new System.Windows.Forms.ToolStripMenuItem();
            this.ExibirLaranja = new System.Windows.Forms.ToolStripMenuItem();
            this.ExibirAzul = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exibir
            // 
            this.Exibir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExibirAmarelo,
            this.ExibirLaranja,
            this.ExibirAzul});
            this.Exibir.Name = "Exibir";
            this.Exibir.Size = new System.Drawing.Size(47, 20);
            this.Exibir.Text = "Exibir";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exibir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ExibirAmarelo
            // 
            this.ExibirAmarelo.Name = "ExibirAmarelo";
            this.ExibirAmarelo.Size = new System.Drawing.Size(180, 22);
            this.ExibirAmarelo.Text = "Amarelo";
            this.ExibirAmarelo.Click += new System.EventHandler(this.ExibirAmarelo_Click);
            // 
            // ExibirLaranja
            // 
            this.ExibirLaranja.Name = "ExibirLaranja";
            this.ExibirLaranja.Size = new System.Drawing.Size(180, 22);
            this.ExibirLaranja.Text = "Laranja";
            this.ExibirLaranja.Click += new System.EventHandler(this.ExibirLaranja_Click);
            // 
            // ExibirAzul
            // 
            this.ExibirAzul.Name = "ExibirAzul";
            this.ExibirAzul.Size = new System.Drawing.Size(180, 22);
            this.ExibirAzul.Text = "Azul";
            this.ExibirAzul.Click += new System.EventHandler(this.ExibirAzul_Click);
            // 
            // Frm_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ex01";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem Exibir;
        private System.Windows.Forms.ToolStripMenuItem ExibirAmarelo;
        private System.Windows.Forms.ToolStripMenuItem ExibirLaranja;
        private System.Windows.Forms.ToolStripMenuItem ExibirAzul;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

