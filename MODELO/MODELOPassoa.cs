using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class MODELOPassoa
    {
        /*Atributos da tabela Pessoa*/
        private Int32 id;
        private string nome;
        private DateTime dataNascimento;
        private string sexo;
        private string email;
        private string cpf;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public DateTime DataNascimento
        {
            get
            {
                return dataNascimento;
            }

            set
            {
                dataNascimento = value;
            }
        }

        public string Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }
    }
}
