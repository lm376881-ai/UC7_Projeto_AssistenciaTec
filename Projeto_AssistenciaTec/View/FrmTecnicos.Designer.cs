namespace Projeto_AssistenciaTec.View
{
    partial class FrmTecnicos
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTecnicos));
            panel2 = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripButtonNovo = new ToolStripButton();
            toolStripButtonEditar = new ToolStripButton();
            toolStripButtonDeletar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButtonCancelar = new ToolStripButton();
            toolStripButtonSalvar = new ToolStripButton();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            DatagridViewTecnicos = new DataGridView();
            BtnBuscar = new Button();
            TxtBuscarPorNome = new TextBox();
            LblBuscarTecnicoPorNome = new Label();
            GroupBoxDadosCliente = new GroupBox();
            TxtEndereco = new TextBox();
            LblEndereco = new Label();
            TxtEspecialidadeTecnico = new TextBox();
            LblEspecialidade = new Label();
            TxtTelefoneTecnico = new TextBox();
            LblTelefoneTecnico = new Label();
            TxtEmailTecnico = new TextBox();
            LblEmailTecnico = new Label();
            TxtNomeTecnico = new TextBox();
            LblNomeTecnico = new Label();
            LabelId = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel2.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DatagridViewTecnicos).BeginInit();
            GroupBoxDadosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(toolStrip1);
            panel2.Location = new Point(-3, 581);
            panel2.Name = "panel2";
            panel2.Size = new Size(995, 44);
            panel2.TabIndex = 9;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonNovo, toolStripButtonEditar, toolStripButtonDeletar, toolStripSeparator1, toolStripButtonCancelar, toolStripButtonSalvar });
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolStrip1.Location = new Point(0, 10);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(158, 31);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNovo
            // 
            toolStripButtonNovo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonNovo.Image = (Image)resources.GetObject("toolStripButtonNovo.Image");
            toolStripButtonNovo.ImageTransparentColor = Color.Magenta;
            toolStripButtonNovo.Name = "toolStripButtonNovo";
            toolStripButtonNovo.Size = new Size(28, 28);
            toolStripButtonNovo.Text = "Novo Tecnico";
            toolStripButtonNovo.ToolTipText = "Novo Tecnico";
            toolStripButtonNovo.Click += toolStripButtonNovo_Click;
            // 
            // toolStripButtonEditar
            // 
            toolStripButtonEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonEditar.Image = (Image)resources.GetObject("toolStripButtonEditar.Image");
            toolStripButtonEditar.ImageTransparentColor = Color.Magenta;
            toolStripButtonEditar.Name = "toolStripButtonEditar";
            toolStripButtonEditar.Size = new Size(28, 28);
            toolStripButtonEditar.Text = "Editar";
            toolStripButtonEditar.Click += toolStripButtonEditar_Click;
            // 
            // toolStripButtonDeletar
            // 
            toolStripButtonDeletar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonDeletar.Image = (Image)resources.GetObject("toolStripButtonDeletar.Image");
            toolStripButtonDeletar.ImageTransparentColor = Color.Magenta;
            toolStripButtonDeletar.Name = "toolStripButtonDeletar";
            toolStripButtonDeletar.Size = new Size(28, 28);
            toolStripButtonDeletar.Text = "Deletar";
            toolStripButtonDeletar.Click += toolStripButtonDeletar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // toolStripButtonCancelar
            // 
            toolStripButtonCancelar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonCancelar.Image = (Image)resources.GetObject("toolStripButtonCancelar.Image");
            toolStripButtonCancelar.ImageTransparentColor = Color.Magenta;
            toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            toolStripButtonCancelar.Size = new Size(28, 28);
            toolStripButtonCancelar.Text = "Cancelar";
            toolStripButtonCancelar.Click += toolStripButtonCancelar_Click;
            // 
            // toolStripButtonSalvar
            // 
            toolStripButtonSalvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSalvar.Image = (Image)resources.GetObject("toolStripButtonSalvar.Image");
            toolStripButtonSalvar.ImageTransparentColor = Color.Magenta;
            toolStripButtonSalvar.Name = "toolStripButtonSalvar";
            toolStripButtonSalvar.Size = new Size(28, 28);
            toolStripButtonSalvar.Text = "Salvar";
            toolStripButtonSalvar.Click += toolStripButtonSalvar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(2, 26, 61);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(995, 89);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(137, 53);
            label2.Name = "label2";
            label2.Size = new Size(218, 21);
            label2.TabIndex = 2;
            label2.Text = "Exibindo dados do Técnico";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(137, 9);
            label6.Name = "label6";
            label6.Size = new Size(384, 41);
            label6.TabIndex = 0;
            label6.Text = "Cadastro de Técnicos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DatagridViewTecnicos);
            groupBox1.Controls.Add(BtnBuscar);
            groupBox1.Controls.Add(TxtBuscarPorNome);
            groupBox1.Controls.Add(LblBuscarTecnicoPorNome);
            groupBox1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(336, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(656, 481);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de técnicos cadastrados:";
            // 
            // DatagridViewTecnicos
            // 
            DatagridViewTecnicos.AllowUserToResizeColumns = false;
            DatagridViewTecnicos.AllowUserToResizeRows = false;
            DatagridViewTecnicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DatagridViewTecnicos.Location = new Point(-15, 108);
            DatagridViewTecnicos.Name = "DatagridViewTecnicos";
            DatagridViewTecnicos.ReadOnly = true;
            DatagridViewTecnicos.Size = new Size(671, 362);
            DatagridViewTecnicos.TabIndex = 5;
            DatagridViewTecnicos.CellClick += DatagridViewTecnicos_CellClick;
            DatagridViewTecnicos.CellEnter += DatagridViewTecnicos_CellEnter;
            // 
            // BtnBuscar
            // 
            BtnBuscar.FlatAppearance.BorderSize = 0;
            BtnBuscar.FlatStyle = FlatStyle.Flat;
            BtnBuscar.Image = (Image)resources.GetObject("BtnBuscar.Image");
            BtnBuscar.Location = new Point(521, 44);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(47, 42);
            BtnBuscar.TabIndex = 4;
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // TxtBuscarPorNome
            // 
            TxtBuscarPorNome.Location = new Point(6, 55);
            TxtBuscarPorNome.Name = "TxtBuscarPorNome";
            TxtBuscarPorNome.Size = new Size(509, 26);
            TxtBuscarPorNome.TabIndex = 3;
            // 
            // LblBuscarTecnicoPorNome
            // 
            LblBuscarTecnicoPorNome.AutoSize = true;
            LblBuscarTecnicoPorNome.Location = new Point(6, 32);
            LblBuscarTecnicoPorNome.Name = "LblBuscarTecnicoPorNome";
            LblBuscarTecnicoPorNome.Size = new Size(202, 20);
            LblBuscarTecnicoPorNome.TabIndex = 2;
            LblBuscarTecnicoPorNome.Text = "Buscar técnico por nome :";
            // 
            // GroupBoxDadosCliente
            // 
            GroupBoxDadosCliente.Controls.Add(TxtEndereco);
            GroupBoxDadosCliente.Controls.Add(LblEndereco);
            GroupBoxDadosCliente.Controls.Add(TxtEspecialidadeTecnico);
            GroupBoxDadosCliente.Controls.Add(LblEspecialidade);
            GroupBoxDadosCliente.Controls.Add(TxtTelefoneTecnico);
            GroupBoxDadosCliente.Controls.Add(LblTelefoneTecnico);
            GroupBoxDadosCliente.Controls.Add(TxtEmailTecnico);
            GroupBoxDadosCliente.Controls.Add(LblEmailTecnico);
            GroupBoxDadosCliente.Controls.Add(TxtNomeTecnico);
            GroupBoxDadosCliente.Controls.Add(LblNomeTecnico);
            GroupBoxDadosCliente.Controls.Add(LabelId);
            GroupBoxDadosCliente.Controls.Add(label1);
            GroupBoxDadosCliente.Enabled = false;
            GroupBoxDadosCliente.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBoxDadosCliente.Location = new Point(11, 105);
            GroupBoxDadosCliente.Name = "GroupBoxDadosCliente";
            GroupBoxDadosCliente.Size = new Size(319, 470);
            GroupBoxDadosCliente.TabIndex = 6;
            GroupBoxDadosCliente.TabStop = false;
            GroupBoxDadosCliente.Text = "Dados do técnico:";
            // 
            // TxtEndereco
            // 
            TxtEndereco.Location = new Point(6, 271);
            TxtEndereco.Multiline = true;
            TxtEndereco.Name = "TxtEndereco";
            TxtEndereco.Size = new Size(282, 71);
            TxtEndereco.TabIndex = 9;
            TxtEndereco.TextChanged += TxtEndereco_TextChanged_1;
            // 
            // LblEndereco
            // 
            LblEndereco.AutoSize = true;
            LblEndereco.Location = new Point(9, 248);
            LblEndereco.Name = "LblEndereco";
            LblEndereco.Size = new Size(170, 20);
            LblEndereco.TabIndex = 8;
            LblEndereco.Text = "Endereço do técnico:";
            // 
            // TxtEspecialidadeTecnico
            // 
            TxtEspecialidadeTecnico.Location = new Point(6, 377);
            TxtEspecialidadeTecnico.Multiline = true;
            TxtEspecialidadeTecnico.Name = "TxtEspecialidadeTecnico";
            TxtEspecialidadeTecnico.Size = new Size(279, 79);
            TxtEspecialidadeTecnico.TabIndex = 11;
            TxtEspecialidadeTecnico.TextChanged += TxtEspecialidadeTecnico_TextChanged_1;
            // 
            // LblEspecialidade
            // 
            LblEspecialidade.AutoSize = true;
            LblEspecialidade.Location = new Point(6, 354);
            LblEspecialidade.Name = "LblEspecialidade";
            LblEspecialidade.Size = new Size(201, 20);
            LblEspecialidade.TabIndex = 10;
            LblEspecialidade.Text = "Especialidade do técnico:";
            // 
            // TxtTelefoneTecnico
            // 
            TxtTelefoneTecnico.Location = new Point(9, 219);
            TxtTelefoneTecnico.Name = "TxtTelefoneTecnico";
            TxtTelefoneTecnico.Size = new Size(157, 26);
            TxtTelefoneTecnico.TabIndex = 7;
            TxtTelefoneTecnico.TextChanged += TxtTelefoneTecnico_TextChanged_1;
            // 
            // LblTelefoneTecnico
            // 
            LblTelefoneTecnico.AutoSize = true;
            LblTelefoneTecnico.Location = new Point(9, 196);
            LblTelefoneTecnico.Name = "LblTelefoneTecnico";
            LblTelefoneTecnico.Size = new Size(160, 20);
            LblTelefoneTecnico.TabIndex = 6;
            LblTelefoneTecnico.Text = "Telefone do técnico:";
            // 
            // TxtEmailTecnico
            // 
            TxtEmailTecnico.Location = new Point(9, 155);
            TxtEmailTecnico.Name = "TxtEmailTecnico";
            TxtEmailTecnico.Size = new Size(276, 26);
            TxtEmailTecnico.TabIndex = 5;
            TxtEmailTecnico.TextChanged += TxtEmailTecnico_TextChanged_1;
            // 
            // LblEmailTecnico
            // 
            LblEmailTecnico.AutoSize = true;
            LblEmailTecnico.Location = new Point(6, 132);
            LblEmailTecnico.Name = "LblEmailTecnico";
            LblEmailTecnico.Size = new Size(140, 20);
            LblEmailTecnico.TabIndex = 4;
            LblEmailTecnico.Text = "E-mail do técnico:";
            // 
            // TxtNomeTecnico
            // 
            TxtNomeTecnico.Location = new Point(9, 89);
            TxtNomeTecnico.Name = "TxtNomeTecnico";
            TxtNomeTecnico.Size = new Size(276, 26);
            TxtNomeTecnico.TabIndex = 3;
            TxtNomeTecnico.TextChanged += TxtNomeTecnico_TextChanged;
            // 
            // LblNomeTecnico
            // 
            LblNomeTecnico.AutoSize = true;
            LblNomeTecnico.Location = new Point(6, 66);
            LblNomeTecnico.Name = "LblNomeTecnico";
            LblNomeTecnico.Size = new Size(138, 20);
            LblNomeTecnico.TabIndex = 2;
            LblNomeTecnico.Text = "Nome do técnico";
            // 
            // LabelId
            // 
            LabelId.BackColor = Color.MintCream;
            LabelId.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelId.ForeColor = Color.FromArgb(2, 26, 61);
            LabelId.Location = new Point(148, 29);
            LabelId.Name = "LabelId";
            LabelId.Size = new Size(59, 26);
            LabelId.TabIndex = 1;
            LabelId.Text = "496";
            LabelId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "ID do técnico:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmTecnicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 631);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(GroupBoxDadosCliente);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmTecnicos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Tecnicos";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DatagridViewTecnicos).EndInit();
            GroupBoxDadosCliente.ResumeLayout(false);
            GroupBoxDadosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonNovo;
        private ToolStripButton toolStripButtonEditar;
        private ToolStripButton toolStripButtonDeletar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonCancelar;
        private ToolStripButton toolStripButtonSalvar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label6;
        private GroupBox groupBox1;
        private DataGridView DatagridViewTecnicos;
        private Button BtnBuscar;
        private TextBox TxtBuscarPorNome;
        private Label LblBuscarTecnicoPorNome;
        private GroupBox GroupBoxDadosCliente;
        private TextBox TxtEspecialidadeTecnico;
        private Label LblEspecialidade;
        private TextBox TxtTelefoneTecnico;
        private Label LblTelefoneTecnico;
        private TextBox TxtEmailTecnico;
        private Label LblEmailTecnico;
        private TextBox TxtNomeTecnico;
        private Label LblNomeTecnico;
        private Label LabelId;
        private Label label1;
        private ErrorProvider errorProvider1;
        private TextBox TxtEndereco;
        private Label LblEndereco;
        private Label label2;
    }
}