namespace Compromissos
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porAssuntoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porPeríodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deHojeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.próximosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblAutor = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem,
            this.removerToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(522, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.inserirToolStripMenuItem.Text = "Inserir";
            this.inserirToolStripMenuItem.Click += new System.EventHandler(this.inserirToolStripMenuItem_Click);
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.removerToolStripMenuItem.Text = "Remover";
            this.removerToolStripMenuItem.Click += new System.EventHandler(this.removerToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosToolStripMenuItem,
            this.porAssuntoToolStripMenuItem,
            this.porPeríodoToolStripMenuItem,
            this.deHojeToolStripMenuItem,
            this.próximosToolStripMenuItem});
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.listarToolStripMenuItem.Text = "Listar";
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.todosToolStripMenuItem.Text = "Todos";
            this.todosToolStripMenuItem.Click += new System.EventHandler(this.todosToolStripMenuItem_Click);
            // 
            // porAssuntoToolStripMenuItem
            // 
            this.porAssuntoToolStripMenuItem.Name = "porAssuntoToolStripMenuItem";
            this.porAssuntoToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.porAssuntoToolStripMenuItem.Text = "Por Assunto";
            this.porAssuntoToolStripMenuItem.Click += new System.EventHandler(this.porAssuntoToolStripMenuItem_Click);
            // 
            // porPeríodoToolStripMenuItem
            // 
            this.porPeríodoToolStripMenuItem.Name = "porPeríodoToolStripMenuItem";
            this.porPeríodoToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.porPeríodoToolStripMenuItem.Text = "Por Período";
            this.porPeríodoToolStripMenuItem.Click += new System.EventHandler(this.porPeríodoToolStripMenuItem_Click);
            // 
            // deHojeToolStripMenuItem
            // 
            this.deHojeToolStripMenuItem.Name = "deHojeToolStripMenuItem";
            this.deHojeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.deHojeToolStripMenuItem.Text = "De Hoje";
            this.deHojeToolStripMenuItem.Click += new System.EventHandler(this.deHojeToolStripMenuItem_Click);
            // 
            // próximosToolStripMenuItem
            // 
            this.próximosToolStripMenuItem.Name = "próximosToolStripMenuItem";
            this.próximosToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.próximosToolStripMenuItem.Text = "Próximos";
            this.próximosToolStripMenuItem.Click += new System.EventHandler(this.próximosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // LblAutor
            // 
            this.LblAutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAutor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LblAutor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAutor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblAutor.Location = new System.Drawing.Point(-1, 319);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(523, 35);
            this.LblAutor.TabIndex = 1;
            this.LblAutor.Text = "Aluno: Carlos Vinicius dos Santos Dias";
            this.LblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 354);
            this.Controls.Add(this.LblAutor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda de Compromissos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porAssuntoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porPeríodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deHojeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem próximosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label LblAutor;
    }
}

