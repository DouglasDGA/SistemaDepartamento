using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDepartamento
{
    class Pessoa
    {
        private string nome;
        private string endereço;
        private DateTime dtNascimento;
        private string telefone;
        private string email;
        public override string ToString()
        {
            return nome;
        }
        public string Nome
        {
            get { return nome; }
        }

        public string Endereco
        {
            get { return endereço; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public DateTime DtNascimento
        {
            get { return dtNascimento; }
        }

        public Pessoa(string nome, string endereço,
            DateTime dtNascimento, string telefone, string email)
        {
            this.nome = nome;
            this.endereço = endereço;
            this.dtNascimento = dtNascimento;
            this.telefone = telefone;
            this.email = email;
        }
    }
}
