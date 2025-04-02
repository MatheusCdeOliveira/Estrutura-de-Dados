using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack_Exercises
{
    // Seja a estrutura de fila, faça um programa que:
    // Insere os números 1, 2, 3, 4 e 5 na estrutura
    // Mostra o número de elementos na estrutura
    // Remove um elemento
    //Escreve na tela “sim/não” indicando se existe o 1 na estrutura
    // Escreve na tela “sim/não” indicando se existe o 5 na estrutura
    // Mostra o próximo elemento a ser removido da estrutura
    // Insere os números 6, 7, 8, 9 e 10 na estrutura
    // Remove dois elementos da estrutura e os mostra na tela
    // Limpa a estrutura e mostra o número de elementos existentes


    class Exercicio01
    {
        public static void Executar()
        {
            Queue fila = new Queue();
            fila.Enqueue(1);
            fila.Enqueue(2);
            fila.Enqueue(3);
            fila.Enqueue(4);
            fila.Enqueue(5);

            Console.WriteLine("Quantidade de elementos na fila: {0}", fila.Count);

            fila.Dequeue();
            string check = fila.Contains(1) ? "sim" : "não";
            Console.WriteLine($"Existe o número 1 na fila? {check}");
            check = fila.Contains(5) ? "sim" : "não";
            Console.WriteLine($"Existe o número 5 na fila? {check}");

            Console.WriteLine($"Próximo elemento a ser removido da fila: {fila.Peek()}");

            fila.Enqueue(6);
            fila.Enqueue(7);
            fila.Enqueue(8);
            fila.Enqueue(9);
            fila.Enqueue(10);

            Console.WriteLine($"Elemento {fila.Dequeue()} removido");
            Console.WriteLine($"Elemento {fila.Dequeue()} removido");

            fila.Clear();
            Console.WriteLine($"Lista esvaziada, número de elementos: {fila.Count}");
        }
    }
}
