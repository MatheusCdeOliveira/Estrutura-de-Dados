using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAD
{

    // 1 - Faça uma classe Fila contendo um atributo do tipo ArrayList, os métodos inserir, remover e mostrar os elementos da sua fila.
    class Exercicio1Fila
    {
        ArrayList al;

        public Exercicio1Fila()
        {
            this.al = new ArrayList();
        }

        public void Inserir<T>(T valor)
        {
            al.Add(valor);
        }

        public object Remover()
        {
          object response = al[0];
          al.RemoveAt(0);
          return response;
        }

        public void Mostrar()
        {
            foreach (object el in al)
            {
                Console.Write(el + " ");
            }
        }
    }
}
