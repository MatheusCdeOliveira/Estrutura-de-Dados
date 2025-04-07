using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        // 1 - Faça o método public int QtdeOcorrencias(List<String> origem, String elemento) que retorna a quantidade de vezes
        // que o elemento passado como parâmetro está armazenado no List<String> origem.
        public static int QtdeOcorrencias(List<string> origem, string elemento)
        {
            int count = 0;
            for (int i = 0; i < origem.Count; i++)
            {
                if (origem[i] == elemento) count++;
            }
            return count;
        }

        // 2 - Faça o método public void ApagaQueue(Queue<int> origem, int início, int final) que apaga todos os elementos no intervalo
        // determinado pelos parâmetros início e final. Por exemplo, ApagaQueue(q, 7, 10) => apaga os elementos entre as posições 7 e 10.

        public static void ApagaQueue(Queue<int> origem, int inicio, int final)
        {
            if (inicio > final)
            {
                Console.WriteLine("índice inicio maior que o final");
            }
            else if (final >= origem.Count)
            {
                Console.WriteLine("Índice final é maior ou igual ao tamanho da fila");
            } else
            {
                int size = origem.Count;

                for (int i = 0; i < inicio; i++)
                {
                    origem.Enqueue(origem.Dequeue());
                }

                for (int i = inicio; i <= final; i++)
                {
                    origem.Dequeue();
                }
                for (int i = final + 1; i < size; i++)
                {
                    origem.Enqueue(origem.Dequeue());
                }
            }
        }
        //3 - Faça o método public Queue CopiaQueue(Queue<int> origem) que copia todos os dados do Queue<int> origem e retorna
        //o novo Queue (não genérico) criado.

        public static Queue CopiaQueue(Queue<int> origem)
        {
            return new Queue(origem.ToArray());
        }
        static void Main(string[] args)
        {
            // Execução exercicio 01
            //List<string> lista = new List<string>() { "Maçã", "Uva", "Pêra", "Abacaxi", "Melão", "Melancia", "Uva", "Maçã", "Uva", "Uva" };
            //int response = QtdeOcorrencias(lista, "Uva");
            //Console.Write($"O elemento passado, aparece {response} {(response > 1 || response == 0 ? "vezes" : "vez")}");

            // Execução exercicio 02
            Queue<int> fila = new Queue<int>();
            for (int i = 0; i <= 9; i++)
            {
                fila.Enqueue(i * 10);
            }
            //foreach(int n in fila)
            //{
            //    Console.Write(n + " ");
            //}

            //ApagaQueue(fila, 6, 10);
            //Console.WriteLine();
            //foreach (int n in fila)
            //{
            //    Console.Write(n + " ");
            //}

            // Execução exercicio 03
            foreach (int n in fila)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            Queue novaFila = CopiaQueue(fila);

            foreach (int n in novaFila)
            {
                Console.Write(n + " ");
            }
        }
    }
}
