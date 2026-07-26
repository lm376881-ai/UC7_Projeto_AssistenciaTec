namespace Projeto_AssistenciaTec
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            TsmPrincipal = new MenuStrip();
            MenuItemArquirvo = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            MenuItemCadastro = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            técnicosToolStripMenuItem = new ToolStripMenuItem();
            MenuItemOS = new ToolStripMenuItem();
            novoOSToolStripMenuItem = new ToolStripMenuItem();
            MenuItemConectar = new ToolStripMenuItem();
            TsmPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // TsmPrincipal
            // 
            TsmPrincipal.Items.AddRange(new ToolStripItem[] { MenuItemArquirvo, MenuItemCadastro, MenuItemOS, MenuItemConectar });
            TsmPrincipal.Location = new Point(0, 0);
            TsmPrincipal.Name = "TsmPrincipal";
            TsmPrincipal.Size = new Size(800, 24);
            TsmPrincipal.TabIndex = 1;
            TsmPrincipal.Text = "menuStrip1";
            // 
            // MenuItemArquirvo
            // 
            MenuItemArquirvo.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            MenuItemArquirvo.Name = "MenuItemArquirvo";
            MenuItemArquirvo.Size = new Size(61, 20);
            MenuItemArquirvo.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(93, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // MenuItemCadastro
            // 
            MenuItemCadastro.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, técnicosToolStripMenuItem });
            MenuItemCadastro.Name = "MenuItemCadastro";
            MenuItemCadastro.Size = new Size(66, 20);
            MenuItemCadastro.Text = "Cadastro";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(180, 22);
            clienteToolStripMenuItem.Text = "Clientes";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // técnicosToolStripMenuItem
            // 
            técnicosToolStripMenuItem.Name = "técnicosToolStripMenuItem";
            técnicosToolStripMenuItem.Size = new Size(180, 22);
            técnicosToolStripMenuItem.Text = "Técnicos";
            técnicosToolStripMenuItem.Click += técnicosToolStripMenuItem_Click;
            // 
            // MenuItemOS
            // 
            MenuItemOS.DropDownItems.AddRange(new ToolStripItem[] { novoOSToolStripMenuItem });
            MenuItemOS.Name = "MenuItemOS";
            MenuItemOS.Size = new Size(34, 20);
            MenuItemOS.Text = "OS";
            // 
            // novoOSToolStripMenuItem
            // 
            novoOSToolStripMenuItem.Name = "novoOSToolStripMenuItem";
            novoOSToolStripMenuItem.Size = new Size(121, 22);
            novoOSToolStripMenuItem.Text = "Novo OS";
            // 
            // MenuItemConectar
            // 
            MenuItemConectar.Name = "MenuItemConectar";
            MenuItemConectar.Size = new Size(67, 20);
            MenuItemConectar.Text = "Conectar";
            MenuItemConectar.Click += MenuItemConectar_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TsmPrincipal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = TsmPrincipal;
            Name = "FrmPrincipal";
            Text = "Gestão de Ordem de Serviços";
            WindowState = FormWindowState.Maximized;
            FormClosing += FrmPrincipal_FormClosing;
            TsmPrincipal.ResumeLayout(false);
            TsmPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip TsmPrincipal;
        private ToolStripMenuItem MenuItemArquirvo;
        private ToolStripMenuItem MenuItemCadastro;
        private ToolStripMenuItem MenuItemOS;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem técnicosToolStripMenuItem;
        private ToolStripMenuItem novoOSToolStripMenuItem;
        private ToolStripMenuItem MenuItemConectar;
    }
}
