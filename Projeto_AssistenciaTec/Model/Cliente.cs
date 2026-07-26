using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_AssistenciaTec.Model
{
    public class Cliente
    {
        public int Id { get; set; }

        private string _nome;
        private string _email;
        private string _telefone;
        private string _endereco;

        public string Nome
        {

            get { return _nome; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        " O campo nome é obrigatório!",
                        nameof(Nome)
                    );
                }
                _nome = value;
            }
        }


        public string Email
        {
            get { return _email; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        " O campo email é obrigatório!",
                        nameof(Email)
                    );
                }
                _email = value;
            }
        }
        public string Telefone
        {
            get { return _telefone; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        " O campo telefone é obrigatório!",
                        nameof(Telefone)
                    );
                }
                _telefone = value;
            }
        }
        public string Endereco
        {
            get { return _endereco; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        " O campo endereco é obrigatório!",
                        nameof(Endereco)
                    );
                }
                _endereco = value;
            }
        }

    }
}
