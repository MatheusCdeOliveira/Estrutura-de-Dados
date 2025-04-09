using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAD
{

    //2 - Faça uma classe Pilha contendo um atributo do tipo ArrayList, os métodos inserir, remover e mostrar os elementos da sua pilha.
    class Exercicio2Pilha
    {
        ArrayList al;

        public Exercicio2Pilha()
        {
            this.al = new ArrayList();
        }

        public void Inserir<T>(T valor)
        {
            al.Add(valor);
        }

        public object Remover()
        {
            object response = al[al.Count - 1];
            al.RemoveAt(al.Count - 1);
            return response;
        }

        public void Mostrar()
        {
           for (int i = al.Count - 1; i >= 0; i--)
            {
                Console.Write(al[i] + " ");
            }
        }
    }
}
