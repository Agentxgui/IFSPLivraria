namespace IFSPLivraria.App
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            menuStrip1 = new MenuStrip();
            cADASTROCIDADEToolStripMenuItem = new ToolStripMenuItem();
            cidadeToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            livroToolStripMenuItem = new ToolStripMenuItem();
            emprestimoToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblUsuario = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cADASTROCIDADEToolStripMenuItem });
            menuStrip1.Location = new Point(3, 85);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(908, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cADASTROCIDADEToolStripMenuItem
            // 
            cADASTROCIDADEToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cidadeToolStripMenuItem, clienteToolStripMenuItem, cadastrosToolStripMenuItem, livroToolStripMenuItem, emprestimoToolStripMenuItem });
            cADASTROCIDADEToolStripMenuItem.Image = (Image)resources.GetObject("cADASTROCIDADEToolStripMenuItem.Image");
            cADASTROCIDADEToolStripMenuItem.Name = "cADASTROCIDADEToolStripMenuItem";
            cADASTROCIDADEToolStripMenuItem.Size = new Size(108, 24);
            cADASTROCIDADEToolStripMenuItem.Text = "Cadastros";
            // 
            // cidadeToolStripMenuItem
            // 
            cidadeToolStripMenuItem.Image = (Image)resources.GetObject("cidadeToolStripMenuItem.Image");
            cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            cidadeToolStripMenuItem.Size = new Size(172, 26);
            cidadeToolStripMenuItem.Text = "&Cidade";
            cidadeToolStripMenuItem.Click += cidadeToolStripMenuItem_Click_1;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Image = (Image)resources.GetObject("clienteToolStripMenuItem.Image");
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(172, 26);
            clienteToolStripMenuItem.Text = "&Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.Image = (Image)resources.GetObject("cadastrosToolStripMenuItem.Image");
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(172, 26);
            cadastrosToolStripMenuItem.Text = "&Editora";
            cadastrosToolStripMenuItem.Click += cadastrosToolStripMenuItem_Click;
            // 
            // livroToolStripMenuItem
            // 
            livroToolStripMenuItem.Image = (Image)resources.GetObject("livroToolStripMenuItem.Image");
            livroToolStripMenuItem.Name = "livroToolStripMenuItem";
            livroToolStripMenuItem.Size = new Size(172, 26);
            livroToolStripMenuItem.Text = "&Livro";
            livroToolStripMenuItem.Click += livroToolStripMenuItem_Click;
            // 
            // emprestimoToolStripMenuItem
            // 
            emprestimoToolStripMenuItem.Image = (Image)resources.GetObject("emprestimoToolStripMenuItem.Image");
            emprestimoToolStripMenuItem.Name = "emprestimoToolStripMenuItem";
            emprestimoToolStripMenuItem.Size = new Size(172, 26);
            emprestimoToolStripMenuItem.Text = "&Emprestimo";
            emprestimoToolStripMenuItem.Click += emprestimoToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUsuario });
            statusStrip1.Location = new Point(3, 570);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(908, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(66, 20);
            lblUsuario.Text = "Usuário: ";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Principal";
            Padding = new Padding(3, 85, 3, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Livraria.com";
            WindowState = FormWindowState.Maximized;
            FormClosing += Principal_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cADASTROCIDADEToolStripMenuItem;
        private ToolStripMenuItem cidadeToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem livroToolStripMenuItem;
        private ToolStripMenuItem emprestimoToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblUsuario;
    }
}