using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Linear_e_Flexivel
{
    class Program
    {
        static void Main(string[] args)
        {
            TAD.Exercicio4Pilha tad = new TAD.Exercicio4Pilha();

            for (int i = 0; i < 10; i++)
            {
                tad.Inserir(i);
            }
            Console.WriteLine(tad.Remover());
            tad.Inserir(10);
            Console.WriteLine(tad.Remover());
            tad.Inserir(11);
            Console.WriteLine(tad.Remover());
            tad.Inserir(12);

            Console.WriteLine("======== Mostrar");
            tad.Mostrar();
        }
    }
}
