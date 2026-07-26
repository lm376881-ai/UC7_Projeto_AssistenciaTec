using Projeto_AssistenciaTec.Model;
using Projeto_AssistenciaTec.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_AssistenciaTec.View
{
    public partial class FrmTecnicos : Form
    {
        private List<Tecnico> tecnicos = new List<Tecnico>();
        public FrmTecnicos()
        {
            InitializeComponent();
            DesabilitarBotoesCancelarSalvar();
            CarregarGridTecnicos();
        }
        private void CarregarGridTecnicos()
        {
            //Criar o repositorio
            TecnicoRepository tecnicoRepository = new TecnicoRepository();

            //Obter a lista do repositorio
            tecnicos = tecnicoRepository.ListarTodos();

            //Carregar o DatagridView com os dados
            DatagridViewTecnicos.Columns.Clear();
            DatagridViewTecnicos.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colunaId = new DataGridViewTextBoxColumn();
            colunaId.DataPropertyName = "Id";
            colunaId.HeaderText = "TecnicoId";
            colunaId.Width = 80;
            DatagridViewTecnicos.Columns.Add(colunaId);

            DataGridViewTextBoxColumn colunaNome = new DataGridViewTextBoxColumn();
            colunaNome.DataPropertyName = "Nome";
            colunaNome.HeaderText = "Nome do Tecnico";
            colunaNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatagridViewTecnicos.Columns.Add(colunaNome);

            //Informar de onde vem os dados do datagridview
            DatagridViewTecnicos.DataSource = tecnicos;

        }
        private void CarregarGridTecnicos(string nome)
        {
            //Criar o repositorio
            TecnicoRepository tecnicoRepository = new TecnicoRepository();

            //Obter a lista do repositorio
            tecnicos = tecnicoRepository.ListarPorNome(nome);

            //Carregar o DatagridView com os dados
            DatagridViewTecnicos.Columns.Clear();
            DatagridViewTecnicos.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colunaId = new DataGridViewTextBoxColumn();
            colunaId.DataPropertyName = "Id";
            colunaId.HeaderText = "ClienteId";
            colunaId.Width = 80;
            DatagridViewTecnicos.Columns.Add(colunaId);

            DataGridViewTextBoxColumn colunaNome = new DataGridViewTextBoxColumn();
            colunaNome.DataPropertyName = "Nome";
            colunaNome.HeaderText = "Nome do Cliente";
            colunaNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatagridViewTecnicos.Columns.Add(colunaNome);

            //Informar de onde vem os dados do datagridview
            DatagridViewTecnicos.DataSource = tecnicos;

        }


        private void DesabilitarBotoesCancelarSalvar()
        {
            toolStripButtonNovo.Enabled = true;
            toolStripButtonEditar.Enabled = true;
            toolStripButtonDeletar.Enabled = true;
            toolStripButtonSalvar.Enabled = false;
            toolStripButtonCancelar.Enabled = false;
            GroupBoxDadosCliente.Enabled = false;
        }

        private void HabilitarBotoesCancelarSalvar()
        {
            toolStripButtonNovo.Enabled = false;
            toolStripButtonEditar.Enabled = false;
            toolStripButtonDeletar.Enabled = false;
            toolStripButtonSalvar.Enabled = true;
            toolStripButtonCancelar.Enabled = true;
            GroupBoxDadosCliente.Enabled = true;
        }

        private void toolStripButtonNovo_Click(object sender, EventArgs e)
        {
            HabilitarBotoesCancelarSalvar();
            LimparCampos();
        }

        private void LimparCampos()
        {
            TxtNomeTecnico.Clear();
            TxtEmailTecnico.Clear();
            TxtTelefoneTecnico.Clear();
            TxtEspecialidadeTecnico.Clear();
            TxtEndereco.Clear();
            LabelId.Text = "";
            TxtNomeTecnico.Focus();
        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            HabilitarBotoesCancelarSalvar();
        }
        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarBotoesCancelarSalvar();
        }

        private void toolStripButtonSalvar_Click(object sender, EventArgs e)
        {
            //Criar um objeto Cliente
            Tecnico tecnico = new Tecnico();

            errorProvider1.Clear();
            LimparControlesPreenchidos();

            try
            {
                tecnico.Nome = TxtNomeTecnico.Text;
                tecnico.Email = TxtEmailTecnico.Text;
                tecnico.Telefone = TxtTelefoneTecnico.Text;
                tecnico.Endereco = TxtEndereco.Text;
                tecnico.Especialidade = TxtEspecialidadeTecnico.Text;
            }
            catch (ArgumentException erro)
            {
                if (erro.ParamName == "Nome")
                {
                    errorProvider1.SetError(TxtNomeTecnico, "Este campo é obrigatório");
                    TxtNomeTecnico.BackColor = Color.LightCoral;
                }
                else if (erro.ParamName == "Endereco") // ou "Endereço", dependendo de como está na sua classe
                {
                    errorProvider1.SetError(TxtEndereco, "Este campo é obrigatório");
                    TxtEndereco.BackColor = Color.LightCoral;
                }
                else if (erro.ParamName == "Email")
                {
                    errorProvider1.SetError(TxtEmailTecnico, "Este campo é obrigatório");
                    TxtEmailTecnico.BackColor = Color.LightCoral;
                }
                else if (erro.ParamName == "Telefone")
                {
                    errorProvider1.SetError(TxtTelefoneTecnico, "Este campo é obrigatório");
                    TxtTelefoneTecnico.BackColor = Color.LightCoral;
                }
                else if (erro.ParamName == "Especialidade")
                {
                    errorProvider1.SetError(TxtEspecialidadeTecnico, "Este campo é obrigatório");
                    TxtEspecialidadeTecnico.BackColor = Color.LightCoral;
                }

                return;

            }
            errorProvider1.Clear();


            //Criar um repositorio do cliente
            TecnicoRepository tecnicoRepository = new TecnicoRepository();

            if (LabelId.Text == String.Empty)
            {
                var clienteId = tecnicoRepository.Salvar(tecnico);

                //Mostrar o id do novo cliente cadastrado
                LabelId.Text = clienteId.ToString();
            }
            else
            {
                tecnico.Id = int.Parse(LabelId.Text);
                tecnicoRepository.atualizar(tecnico);
                MessageBox.Show(
                       "Cliente atualizado com sucesso!",
                       "Atualização de cliente",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information

                   );
            }

            DesabilitarBotoesCancelarSalvar();
            CarregarGridTecnicos();
        }

        private void LimparControlesPreenchidos()
        {
            if (TxtNomeTecnico.Text != String.Empty)
            {
                TxtNomeTecnico.BackColor = Color.White;
            }
        }

        private void toolStripButtonDeletar_Click(object sender, EventArgs e)
        {

            //Confirmar se a exclusão deverá ocorrer
            var resposta = MessageBox.Show(
                "Confirma a exclusão do cliente selecionado?",
                   "Exclusão de cliente",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question
               );
            if (resposta == DialogResult.Yes)
            {
                var tecnicoRepository = new TecnicoRepository();
                var idSelecionado = int.Parse(LabelId.Text);

                var excluidos = tecnicoRepository.excluir(idSelecionado);

                if (excluidos > 0)
                {
                    MessageBox.Show(
                        "Cliente excluido com sucesso!",
                        "Exclusão de cliente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information

                    );
                    CarregarGridTecnicos();
                }
            }
        }
        private void exibirDadosDoTecnico(DataGridViewCellEventArgs e)
        {
            var linha = e.RowIndex;

            if (linha == -1)
            {
                linha = 0;
            }
            //Recuperar os dados da linha  que foi clicada
            var linhaSelecionada = DatagridViewTecnicos.Rows[linha];
            var tecnicoSelecionado = linhaSelecionada.DataBoundItem as Tecnico;

            LabelId.Text = tecnicoSelecionado.Id.ToString();
            TxtNomeTecnico.Text = tecnicoSelecionado.Nome;
            TxtEmailTecnico.Text = tecnicoSelecionado.Email;
            TxtEndereco.Text = tecnicoSelecionado.Endereco;
            TxtTelefoneTecnico.Text = tecnicoSelecionado.Telefone;
            TxtEspecialidadeTecnico.Text = tecnicoSelecionado.Especialidade;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CarregarGridTecnicos(TxtBuscarPorNome.Text);
        }

        private void DatagridViewTecnicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            exibirDadosDoTecnico(e);
        }

        private void DatagridViewTecnicos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            exibirDadosDoTecnico(e);
        }

        private void TxtNomeTecnico_TextChanged(object sender, EventArgs e)
        {
            TxtNomeTecnico.BackColor = Color.White;
            errorProvider1.SetError(TxtNomeTecnico, string.Empty);
        }


        private void TxtEmailTecnico_TextChanged_1(object sender, EventArgs e)
        {
            TxtEmailTecnico.BackColor = Color.White;
            errorProvider1.SetError(TxtEmailTecnico, string.Empty);
        }

        private void TxtTelefoneTecnico_TextChanged_1(object sender, EventArgs e)
        {
            TxtTelefoneTecnico.BackColor = Color.White;
            errorProvider1.SetError(TxtTelefoneTecnico, string.Empty);
        }

        private void TxtEndereco_TextChanged_1(object sender, EventArgs e)
        {
            TxtEndereco.BackColor = Color.White;
            errorProvider1.SetError(TxtEndereco, string.Empty);
        }

        private void TxtEspecialidadeTecnico_TextChanged_1(object sender, EventArgs e)
        {
            TxtEspecialidadeTecnico.BackColor = Color.White;
            errorProvider1.SetError(TxtEspecialidadeTecnico, string.Empty);
        }
    }
}
