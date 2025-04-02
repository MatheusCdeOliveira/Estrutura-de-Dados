using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Queue_Stack_Exercises.HashTable
{
    // Seja a estrutura de Hashtable, faça um programa que:
    // Insere os pares chave/valor: 1/10, 2/20, 3/30, 4/40 e 5/50
    // Mostra o número de elementos na tabela
    // Remove o elemento com chave 1
    // Escreve “sim/não” indicando se existe um objeto com chave 1
    // Escreve “sim/não” indicando se existe um objeto com valor 5
    // Insere os pares chave/valor: 6/60, 7/70, 8/80, 9/90 e 10/100
    // Remove e mostra os elementos com as chaves 5 e 8
    // Limpa a estrutura e mostra o número de elementos existentes

    class Exercicio01
    {
        public static void Executar()
        {
            Hashtable h = new Hashtable
            {
                { 1, 10 },
                { 2, 20 },
                { 3, 30 },
                { 4, 40 },
                { 5, 50 }
            };

            Console.WriteLine("Número de elementos na tabela: {0}", h.Count);
            h.Remove(1);
            string check = h.ContainsKey(1) ? "Sim" : "Não";
            Console.WriteLine($"Existe um objeto com chave 1 na tabela? {check}");
            check = h.Contains(5) ? "Sim" : "Não";
            Console.WriteLine($"Existe um objeto com valor 5 na tabela? {check}");

            h.Add(6, 60);
            h.Add(7, 70);
            h.Add(8, 80);
            h.Add(9, 90);
            h.Add(10, 100);
           
            h.Remove(5);
            h.Remove(8);
            Console.WriteLine("Elemento com a chave 5 removido");
            Console.WriteLine("Elemento com a chave 8 removido");

            h.Clear();
            Console.WriteLine("Hashtable apagada, numeros de elementos: {0}", h.Count);
        }
    }
}
