using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAD
{

    //3 - Faça uma classe Fila contendo dois atributos do tipo Stack, os métodos inserir, remover e mostrar os elementos da sua fila.
    class Exercicio3Fila
    {
        Stack pilha1;
        Stack pilha2;

        public Exercicio3Fila()
        {
            this.pilha1 = new Stack();
            this.pilha2 = new Stack();
        }

        public void Inserir<T>(T valor)
        {
            pilha1.Push(valor);
        }

        public object Remover()
        {
            while (pilha1.Count > 0) {
                pilha2.Push(pilha1.Pop());
            }
            object res = pilha2.Pop();
            while (pilha2.Count > 0)
            {
                pilha1.Push(pilha2.Pop());
            }
            return res;
        }

        public void Mostrar()
        {
            object[] array = pilha1.ToArray();
            for (int i = pilha1.Count - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
