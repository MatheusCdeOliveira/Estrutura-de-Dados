using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack_Exercises.Pilha

// Seja a estrutura de pilha, faça um programa que:
// Insere os números 1, 2, 3, 4 e 5 na estrutura
// Mostra o número de elementos na estrutura
// Remove um elemento
//Escreve na tela “sim/não” indicando se existe o 1 na estrutura
// Escreve na tela “sim/não” indicando se existe o 5 na estrutura
// Mostra o próximo elemento a ser removido da estrutura
// Insere os números 6, 7, 8, 9 e 10 na estrutura
// Remove dois elementos da estrutura e os mostra na tela
// Limpa a estrutura e mostra o número de elementos existentes
{
    class Exercicio01
    {
        public static void Executar()
        {
            Stack pilha = new Stack();
            pilha.Push(1);
            pilha.Push(2);
            pilha.Push(3);
            pilha.Push(4);
            pilha.Push(5);

            Console.WriteLine("Quantidade de elementos na fila: {0}", pilha.Count);

            pilha.Pop();
            string check = pilha.Contains(1) ? "sim" : "não";
            Console.WriteLine($"Existe o número 1 na pilha {check}");
            check = pilha.Contains(5) ? "sim" : "não";
            Console.WriteLine($"Existe o número 5 na pilha? {check}");

            Console.WriteLine($"Próximo elemento a ser removido da pilha: {pilha.Peek()}");

            pilha.Push(6);
            pilha.Push(7);
            pilha.Push(8);
            pilha.Push(9);
            pilha.Push(10);

            Console.WriteLine($"Elemento {pilha.Pop()} removido");
            Console.WriteLine($"Elemento {pilha.Pop()} removido");

            pilha.Clear();
            Console.WriteLine($"Pilha esvaziada, número de elementos: {pilha.Count}");
        }
    }
}
