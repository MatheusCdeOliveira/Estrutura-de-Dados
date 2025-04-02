using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos
{
    class Pessoa
    {
       private string primeiroNome;
       private string sobrenome;
       private string endereco;
       private string telefone;

       public Pessoa(string primeiroNome, string sobrenome, string endereco, string telefone)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            Endereco = endereco;
            Telefone = telefone;
        }

        public Pessoa()
        {
        }

        public string PrimeiroNome
        {
            get => primeiroNome;
            set { if (value.Length > 3) primeiroNome = value;  }
        }

        public string Sobrenome
        {
            get => sobrenome;
            set { if (value.Length > 3) sobrenome = value; }
        }

        public string NomeCompleto{ get => primeiroNome + " " + sobrenome; }

        public string Endereco
        {
            get => endereco;
            set { if (value.Length > 4) endereco = value; }
        }

        public string Telefone
        {
            get => telefone;
            set { if (value.Length > 8) telefone = value; }
        }
    }

}
