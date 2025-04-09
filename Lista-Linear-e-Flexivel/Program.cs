using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lista_Linear;

namespace Lista_Linear_e_Flexivel
{
    class Program
    {
        static void Main(string[] args)
        {
            //TAD.Exercicio4Pilha tad = new TAD.Exercicio4Pilha();

            //for (int i = 0; i < 10; i++)
            //{
            //    tad.Inserir(i);
            //}
            //Console.WriteLine(tad.Remover());
            //tad.Inserir(10);
            //Console.WriteLine(tad.Remover());
            //tad.Inserir(11);
            //Console.WriteLine(tad.Remover());
            //tad.Inserir(12);

            //Console.WriteLine("======== Mostrar");
            //tad.Mostrar();

            Lista lista = new Lista();
            int x1, x2, x3;

            lista.InserirInicio(1);
            lista.InserirInicio(7);
            lista.InserirFim(2);
            lista.InserirFim(3);
            lista.Inserir(4, 3);
            lista.Inserir(5, 2);

            Console.Write("Apos insercoes: ");
            lista.Mostrar();

            x1 = lista.RemoverInicio();
            x2 = lista.RemoverFim();
            x3 = lista.Remover(2);

            Console.Write("Apos remocoes (" + x1 + ", " + x2 + ", " + x3 + "):");
            lista.Mostrar();
        }
    }
}
