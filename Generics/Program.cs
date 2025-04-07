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
        //4 - Faça o método public void VaiProFundo<T> (Stack<T> origem, T elemento) que empilha o elemento passado como parâmetro
        //no fundo da Stack<T> origem, ao invés de empilhar no topo.
        public static void VaiProFundo<T> (Stack<T> origem, T elemento)
        {
            Stack<T> pilha = new Stack<T>();
            int size = origem.Count;
            for (int i = 0; i < size; i++)
            {
               pilha.Push(origem.Pop());
            }
            origem.Push(elemento);
            for (int i = 0; i < size; i++)
            {
                origem.Push(pilha.Pop());
            }
        }
        // 5 - Faça o método public void InverteQueue<T> (Queue<T> q) que inverte a ordem dos elementos da Queue<T> q, no próprio Queue.
        // Fique à vontade para utilizar outras estruturas que julgar necessárias. Nesse exercício, você não deve utilizar o método Reverse.
        public static void InverteQueue<T> (Queue<T> q)
        {
            Stack<T> pilha = new Stack<T>();
            for (int i = 0; q.Count > 0; i++)
            {
                pilha.Push(q.Dequeue());
            }

            for (int i = 0; pilha.Count > 0; i++)
            {
                q.Enqueue(pilha.Pop());
            }
        }
        // 6 - Faça o método public void InverteStack<T> (Stack<T>  s) que inverte a ordem dos elementos do Stack<T> s,
        // no próprio Stack. Nesse exercício, você não deve utilizar o método Reverse.
        public static void InverteStack<T>(Stack<T> s)
        {
            List<T> listaTemp = new List<T>();
            while (s.Count > 0)
            {
                T item = s.Pop();
                listaTemp.Add(item);
            }

            for (int i = 0; i < listaTemp.Count; i++)
            {
                s.Push(listaTemp[i]);
            }
        }
        static void Main(string[] args)
        {
            // EXECUÇÃO EXERCICIO 01
            //List<string> lista = new List<string>() { "Maçã", "Uva", "Pêra", "Abacaxi", "Melão", "Melancia", "Uva", "Maçã", "Uva", "Uva" };
            //int response = QtdeOcorrencias(lista, "Uva");
            //Console.Write($"O elemento passado, aparece {response} {(response > 1 || response == 0 ? "vezes" : "vez")}");

            Queue<int> fila = new Queue<int>();
            Stack<int> pilha = new Stack<int>();

            for (int i = 0; i <= 9; i++)
            {
                fila.Enqueue(i * 10);
            }

            for (int i = 0; i <= 9; i++)
            {
                pilha.Push(i * 10);
            }
            // EXECUÇÃO EXERCICIO 02
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

            // EXECUÇÃO EXERCICIO 03
            //Console.WriteLine();
            //Queue novaFila = CopiaQueue(fila);

            //foreach (int n in novaFila)
            //{
            //    Console.Write(n + " ");
            //}

            // EXECUÇÃO EXERCICIO 04
            //VaiProFundo(pilha, 500);

            //foreach (int n in pilha)
            //{
            //    Console.Write(n + " ");
            //}

            // EXECUÇÃO EXERCICIO 05
            //InverteQueue(fila);
            //foreach (int n in fila)
            //{
            //    Console.Write(n + " ");
            //}


            // EXECUÇÃO EXERCICIO 06
            InverteStack(pilha);

            foreach (int n in pilha)
            {
                Console.Write(n + " ");
            }
        }
    }
}
