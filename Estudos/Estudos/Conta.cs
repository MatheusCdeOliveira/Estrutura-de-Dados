using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos
{
    class Conta
    {
       private float saldo;
       private DateTime criacao;

       private static int numero;


       public static int Numero { get => Conta.numero; }

       public float Saldo { get => saldo; }

       public DateTime Criacao { get => criacao; }
        

       public Conta()
        {
            ++numero;
            this.criacao = DateTime.Now;
        }

       public Conta(float saldoInicial)
        {
            ++numero;
            Depositar(saldoInicial);
            this.criacao = DateTime.Now;
        }


        public float Sacar(float value)
        {
            if (value < saldo && value > 0)
            {
                saldo -= value;
                return saldo;
            } else
            {
                Console.WriteLine("Valor insuficiente ou inválido");
                return 0;
            }
        }

        public float Depositar(float value)
        {
            if (value > 0)
            {
                saldo += value;
                return saldo;
            } else
            {
                Console.WriteLine("Valor inválido");
                return 0;
            }
        }
    }
}
