using Microsoft.Data.SqlClient;
using Projeto_AssistenciaTec.Data;
using Projeto_AssistenciaTec.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_AssistenciaTec.Repository
{
    internal class TecnicoRepository
    {
        public int Salvar(Tecnico tecnico)
        {
            //Criar a instrução SQL de INSERT   

            string sql = "INSERT INTO tbl_tecnicos (nome, email, telefone, endereco, especialidade) " +
                "OUTPUT INSERTED.tecnico_id " +
                "VALUES (@Nome, @Email, @Telefone, @Endereco ,@Especialidade)";

            //Criar/abrir a conexão com o banco de dados
            using var conexao = Conexao.GetConexao();

            //Criar o comando que será ernviado ao anco de dados
            using var comando = new SqlCommand(sql, conexao);

            //Preencher os campos da instrução sql com os valores
            comando.Parameters.AddWithValue("@Nome", tecnico.Nome);
            comando.Parameters.AddWithValue("@Email", tecnico.Email);
            comando.Parameters.AddWithValue("@Telefone", tecnico.Telefone);
            comando.Parameters.AddWithValue("@Endereco", tecnico.Endereco);
            comando.Parameters.AddWithValue("@Especialidade", tecnico.Especialidade);

            //Executar o comando
            var novoId = (int)comando.ExecuteScalar();// casting

            return novoId;
        }

        public List<Tecnico> ListarTodos()
        {

            //Criar instrução sql para listar todos
            var sql = "SELECT * FROM tbl_tecnicos ORDER BY nome ASC";

            //Abrir conexão com o banco de dados
            using var conexao = Conexao.GetConexao();

            //Criar o comando
            using var comando = new SqlCommand(sql, conexao);

            // Criar um objeto que guarda o resultado do comando SELECT
            using var resultado = comando.ExecuteReader();
            //Criar uma lista de tecnicos vazia
            List<Tecnico> tecnicos = new List<Tecnico>();

            while (resultado.Read())
            {

                Tecnico tecnico = new Tecnico();
                tecnico.Id = resultado.GetInt32(resultado.GetOrdinal("tecnico_id"));
                tecnico.Nome = resultado.GetString(resultado.GetOrdinal("nome"));
                tecnico.Email = resultado.GetString(resultado.GetOrdinal("email"));
                tecnico.Telefone = resultado.GetString(resultado.GetOrdinal("telefone"));
                tecnico.Endereco = resultado.GetString(resultado.GetOrdinal("endereco"));
                tecnico.Especialidade = resultado.GetString(resultado.GetOrdinal("especialidade"));
                tecnicos.Add(tecnico);

            }
            return tecnicos;

        }
        public int excluir(int id)
        {
            //Instrução de exclusão SQL
            var sql = "DELETE FROM tbl_tecnicos WHERE  tecnico_id = @Id";

            //Abrir conexão com o banco de dados
            using var conexao = Conexao.GetConexao();

            //Criar o comando
            using var comando = new SqlCommand(sql, conexao);

            //Substituir o parâmetro @Id do SQL pelo valor do id cliente
            comando.Parameters.AddWithValue("@Id", id);

            //Executar comando
            var resultado = comando.ExecuteNonQuery();

            return resultado;
        }
        public int atualizar(Tecnico tecnico)
        {
            //Instrução SQl para atualização de tecnico
            var sql = "UPDATE tbl_tecnicos SET nome = @Nome," +
                " email = @Email," +
                " telefone = @Telefone," +
                " endereco = @Endereco," +
                " especialidade = @Especialista" +
                " WHERE tecnico_id = @Id";

            //abrir a conexão com o banco de dados
            using var conexao = Conexao.GetConexao();

            //Criar o comando que será ernviado ao anco de dados
            using var comando = new SqlCommand(sql, conexao);

            //Preencher os campos da instrução sql com os valores
            comando.Parameters.AddWithValue("@Nome", tecnico.Nome);
            comando.Parameters.AddWithValue("@Email", tecnico.Email);
            comando.Parameters.AddWithValue("@Telefone", tecnico.Telefone);
            comando.Parameters.AddWithValue("@Endereco", tecnico.Endereco);
            comando.Parameters.AddWithValue("@Especialidade", tecnico.Especialidade);
            comando.Parameters.AddWithValue("@Id", tecnico.Id);

            //Executar comando
            var resultado = comando.ExecuteNonQuery();

            return resultado;
        }
        public List<Tecnico> ListarPorNome(string nome)
        {


            //Criar instrução sql para listar todos
            var sql = "SELECT * FROM tbl_tecnicos" +
                " WHERE nome LIKE  @Nome " +
                "ORDER BY nome ASC";

            //Abrir conexão com o banco de dados
            using var conexao = Conexao.GetConexao();

            //Criar o comando
            using var comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Nome", "%" + nome + "%");

            // Criar um objeto que guarda o resultado do comando SELECT
            using var resultado = comando.ExecuteReader();

            //Criar uma lista de clientes vazia
            List<Tecnico> tecnicos = new List<Tecnico>();

            while (resultado.Read())
            {
                Tecnico tecnico = new Tecnico();
                tecnico.Id = resultado.GetInt32(resultado.GetOrdinal("cliente_id"));
                tecnico.Nome = resultado.GetString(resultado.GetOrdinal("nome"));
                tecnico.Email = resultado.GetString(resultado.GetOrdinal("email"));
                tecnico.Telefone = resultado.GetString(resultado.GetOrdinal("telefone"));
                tecnico.Endereco = resultado.GetString(resultado.GetOrdinal("endereco"));
                tecnico.Especialidade = resultado.GetString(resultado.GetOrdinal("especialidade"));
                tecnicos.Add(tecnico);



            }

            return tecnicos;

        }
    }
}

