using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAD
{
    // 4 - Faça uma classe Pilha contendo dois atributos do tipo Queue, os métodos inserir, remover e mostrar os elementos da sua pilha.
    class Exercicio4Pilha
    {
        Queue fila1;
        Queue fila2;

        public Exercicio4Pilha()
        {
            this.fila1 = new Queue();
            this.fila2 = new Queue();
        }

        public void Inserir<T>(T valor)
        {
            fila1.Enqueue(valor);
        }

        public object Remover()
        {
            while (fila1.Count > 1)
            {
                fila2.Enqueue(fila1.Dequeue());
            }
            object res = fila1.Dequeue();
            while (fila2.Count > 0)
            {
                fila1.Enqueue(fila2.Dequeue());
            }
            return res;
        }

        public void Mostrar()
        {
            object[] array = fila1.ToArray();
            for (int i = fila1.Count - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
