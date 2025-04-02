using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Matheus", "Campos", "Rua da Adoração", "592170");

            Console.WriteLine("Primeiro Nome: {0}", pessoa.PrimeiroNome);
            Console.WriteLine("Segundoo Nome: {0}", pessoa.Sobrenome);
            Console.WriteLine("Nome completo: {0}", pessoa.NomeCompleto);
            Console.WriteLine("Endereço: {0}", pessoa.Endereco);
            Console.WriteLine("Telefone: {0}", pessoa.Telefone);

            //    Conta conta = new Conta();
            //    Conta conta2 = new Conta(1000);
            //    Conta conta3 = new Conta(2000);
            //    conta2.Depositar(100);
            //    conta3.Sacar(500);
            //    Console.WriteLine("Contador: {0}", Conta.Numero);
            //    Console.WriteLine("Saldo conta 2: {0}", conta2.Saldo);
            //    Console.WriteLine("Saldo conta 2: {0}", conta3.Saldo);
            }
        }
}
