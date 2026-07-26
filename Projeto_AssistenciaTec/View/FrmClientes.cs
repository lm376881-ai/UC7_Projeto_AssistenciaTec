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
    public partial class FrmClientes : Form
    {
        private List<Cliente> clientes = new List<Cliente>();

        public FrmClientes()
        {
            InitializeComponent();
            DesabilitarBotoesCancelarSalvar();
            CarregarGridClientes();
        }

        private void CarregarGridClientes()
        {
            //Criar o repositorio
            ClienteRepository clienteRepository = new ClienteRepository();

            //Obter a lista do repositorio
            clientes = clienteRepository.ListarTodos();

            //Carregar o DatagridView com os dados
            DatagridViewClientes.Columns.Clear();
            DatagridViewClientes.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colunaId = new DataGridViewTextBoxColumn();
            colunaId.DataPropertyName = "Id";
            colunaId.HeaderText = "ClienteId";
            colunaId.Width = 80;
            DatagridViewClientes.Columns.Add(colunaId);

            DataGridViewTextBoxColumn colunaNome = new DataGridViewTextBoxColumn();
            colunaNome.DataPropertyName = "Nome";
            colunaNome.HeaderText = "Nome do Cliente";
            colunaNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatagridViewClientes.Columns.Add(colunaNome);

            //Informar de onde vem os dados do datagridview
            DatagridViewClientes.DataSource = clientes;

        }
        private void CarregarGridClientes(string nome)
        {
            //Criar o repositorio
            ClienteRepository clienteRepository = new ClienteRepository();

            //Obter a lista do repositorio
            clientes = clienteRepository.ListarPorNome(nome);

            //Carregar o DatagridView com os dados
            DatagridViewClientes.Columns.Clear();
            DatagridViewClientes.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colunaId = new DataGridViewTextBoxColumn();
            colunaId.DataPropertyName = "Id";
            colunaId.HeaderText = "ClienteId";
            colunaId.Width = 80;
            DatagridViewClientes.Columns.Add(colunaId);

            DataGridViewTextBoxColumn colunaNome = new DataGridViewTextBoxColumn();
            colunaNome.DataPropertyName = "Nome";
            colunaNome.HeaderText = "Nome do Cliente";
            colunaNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatagridViewClientes.Columns.Add(colunaNome);

            //Informar de onde vem os dados do datagridview
            DatagridViewClientes.DataSource = clientes;

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
            TxtNome.Clear();
            TxtEmail.Clear();
            TxtTelefone.Clear();
            TxtEndereco.Clear();
            LabelId.Text = "";
            TxtNome.Focus();
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
            Cliente cliente = new Cliente();

            errorProvider1.Clear();
            LimparControlesPreenchidos();

            try
            {
                cliente.Nome = TxtNome.Text;
                cliente.Email = TxtEmail.Text;
                cliente.Telefone = TxtTelefone.Text;
                cliente.Endereco = TxtEndereco.Text;
            }
            catch (ArgumentException erro)
            {
                if (erro.ParamName == "Nome")
                {
                    errorProvider1.SetError(TxtNome, "Este campo é obrigatório");
                    TxtNome.BackColor = Color.LightCoral;
                }
                else if (erro.ParamName == "Endereco") // ou "Endereço", dependendo de como está na sua classe
                {
                    errorProvider1.SetError(TxtEndereco, "Este campo é obrigatório");
                    TxtEndereco.BackColor = Color.LightCoral;
                }
                else if (erro.ParamName == "Email")
                {
                    errorProvider1.SetError(TxtEmail, "Este campo é obrigatório");
                    TxtEmail.BackColor = Color.LightCoral;
                }
                else if (erro.ParamName == "Telefone")
                {
                    errorProvider1.SetError(TxtTelefone, "Este campo é obrigatório");
                    TxtTelefone.BackColor = Color.LightCoral;
                }

                return;

            }
            errorProvider1.Clear();


            //Criar um repositorio do cliente
            ClienteRepository clienteRepository = new ClienteRepository();

            if (LabelId.Text == String.Empty)
            {
                var clienteId = clienteRepository.Salvar(cliente);

                //Mostrar o id do novo cliente cadastrado
                LabelId.Text = clienteId.ToString();
            }
            else
            {
                cliente.Id = int.Parse(LabelId.Text);
                clienteRepository.atualizar(cliente);
                MessageBox.Show(
                       "Cliente atualizado com sucesso!",
                       "Atualização de cliente",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information

                   );
            }

            DesabilitarBotoesCancelarSalvar();
            CarregarGridClientes();
        }

        private void LimparControlesPreenchidos()
        {
            if (TxtNome.Text != String.Empty)
            {
                TxtNome.BackColor = Color.White;
            }
        }

        private void DatagridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            exibirDadosDoCliente(e);
        }

        private void DatagridViewClientes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            exibirDadosDoCliente(e);
        }

        private void exibirDadosDoCliente(DataGridViewCellEventArgs e)
        {
            var linha = e.RowIndex;

            if (linha == -1)
            {
                linha = 0;
            }
            //Recuperar os dados da linha  que foi clicada
            var linhaSelecionada = DatagridViewClientes.Rows[linha];
            var clienteSelecionado = linhaSelecionada.DataBoundItem as Cliente;

            LabelId.Text = clienteSelecionado.Id.ToString();
            TxtNome.Text = clienteSelecionado.Nome;
            TxtEmail.Text = clienteSelecionado.Email;
            TxtEndereco.Text = clienteSelecionado.Endereco;
            TxtTelefone.Text = clienteSelecionado.Telefone;
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
                var clienteRepository = new ClienteRepository();
                var idSelecionado = int.Parse(LabelId.Text);

                var excluidos = clienteRepository.excluir(idSelecionado);

                if (excluidos > 0)
                {
                    MessageBox.Show(
                        "Cliente excluido com sucesso!",
                        "Exclusão de cliente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information

                    );
                    CarregarGridClientes();
                }
            }

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CarregarGridClientes(TxtBuscarPorNome.Text);
        }

        private void LabelId_Click(object sender, EventArgs e)
        {

        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtNome, string.Empty);
            TxtNome.BackColor = Color.White;
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtEmail, string.Empty);
            TxtEmail.BackColor = Color.White;
        }

        private void TxtTelefone_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtTelefone, string.Empty);
            TxtTelefone.BackColor = Color.White;

        }

        private void TxtEndereco_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtEndereco, string.Empty);
            TxtEndereco.BackColor = Color.White;
        }
    }
}
