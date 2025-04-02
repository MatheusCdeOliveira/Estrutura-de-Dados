using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack_Exercises.Fila
{
    // Implemente um programa que contém um objeto do tipo fila e que leia
    //10 caracteres.Para cada caractere, se ele for uma letra maiúscula,
    //insira-o na fila.Senão, se ele for uma letra minúscula, retire um
    //caractere da fila e mostre o na tela.Caso contrário (o caractere não é
    //uma letra), mostre o próximo elemento a ser removido da fila

    class Exercicio02
    {
        public static void Executar()
        {
            Queue fila = new Queue();

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um caracter: ");
                string entrada = Console.ReadLine();

                if (string.IsNullOrEmpty(entrada))
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                    i--;
                }
                char c = entrada[0];

                if (char.IsUpper(c))
                {
                    fila.Enqueue(c);
                    Console.WriteLine($"Caracter adicionado");
                } else if (char.IsLower(c))
                {
                    if (fila.Count > 0)
                    {
                        Console.WriteLine($"Caracter '{fila.Dequeue()}' removido");
                    } else
                    {
                        Console.WriteLine("Fila vazia, não é possivel remover elementos");
                        i--;
                    }
                } else
                {
                    Console.WriteLine($"Próximo caracter a ser removido: {fila.Peek()}");
                }

            }
        }
    }
}
