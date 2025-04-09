using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Linear
{

    // Implemente uma classe lista sequencial sem usar o ArrayList
    class Lista
    {
        private readonly int[] array;
        private readonly int capacity;
        private int count;

        public int Count { get => count; }
        public int Capacity { get => capacity; }

        public Lista()
            {
                array = new int[8];
                count = 0;
                capacity = array.Length;
            }

        public Lista(int capacity)
        {
            this.capacity = capacity;
            array = new int[capacity];
            count = 0;
        }


        public void InserirInicio(int value)
        {
            if (count >= array.Length)
            {
                throw new InvalidOperationException("Não é possível inserir, a lista está cheia.");
            }

            for (int i = count; i > count; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = value;
            count++;
        }


        public void InserirFim(int value)
        {
            if (count >= array.Length)
            {
                throw new InvalidOperationException("Não é possível inserir, a lista está cheia.");
            }

            array[count] = value;
            count++;
        }

        public void Inserir(int value, int pos)
        {
            if (count >= array.Length)
            {
                throw new InvalidOperationException("Não é possível inserir, lista está cheia");
            } else if (pos < 0 || pos > count)
            {
                throw new InvalidOperationException("Não é possível inserir, indice fora de alcance");
            }

                for (int i = count; i > pos; i--)
                {
                    array[i] = array[i - 1];
                }

            array[pos] = value;
            count++;
        }

        public int RemoverInicio()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Não é possível remover, a lista está vazia.");
            }
            int response = array[0];
            count--;
            for (int i = 0; i < count; i++)
            {
                array[i] = array[i + 1];
            }
            return response;
        }

        public int RemoverFim()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Não é possível remover, a lista está vazia.");
            }

            int response = array[count];
            count--;

            return response;
        }

        public int Remover(int pos)
        {
            if (count == 0 || pos >= array.Length || pos < 0)
            {
                throw new InvalidOperationException("Não é possível remover, a lista está vazia.");
            }
            int response = array[pos];
            count--;
            for (int i = pos; i < count; i++)
            {
                array[i] = array[i + 1];
            }
            return response;
        }

        public void Mostrar()
        {
            Console.Write("[ ");

            for (int i = 0; i < count; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.Write("]");
        }

        public bool Pesquisar(int x)
        {
            bool response = false;
            for (int i = 0; i < count; i++)
            {
                response = (array[i] == x);
            }
            return response;
        }

        public void Inverter()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Não é possível inverter, a lista está vazia.");
            }
            int start = 0;
            int end = count - 1;
            while (start < end)
            {
                (array[end], array[start]) = (array[start], array[end]);
                start++;
                end--;
            }
        }
    }

}
