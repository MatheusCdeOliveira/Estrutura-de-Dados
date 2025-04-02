using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Exercises
{

    // 1 - A maioria dos sistemas computacionais que você terá a oportunidade de desenvolver ou trabalhar em sua vida profissional terá um cadastro de elementos.
    // Em outras palavras, uma lista contendo as operações de inserir, ler, atualizar e apagar elementos.
    // Na área de programação de computadores, esse minicadastro é chamado de CRUD, sigla em inglês para as palavras Create, Read, Update e Delete.
    // Traduzindo, temos: criar, ler, atualizar e apagar, respectivamente. Neste exercício, faça um programa contendo um ArrayList
    // que armazena números inteiros e mostra as seguintes opções de escolha para o usuário:
    // 1 - inserir elemento; 2 - remover elemento; 3 - listar elementos; 4 - pesquisar elemento; 5 - ordenar elementos; e 6 - sair.
    // Quando o usuário escolher uma das opções, o programa realiza a operação escolhida no ArrayList.
    class Exercicio01
    {
        public static void Executar()
    {
        int opcao;
        ArrayList al = new ArrayList();
        do
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções:");
            Console.WriteLine("1 - Inserir elemento");
            Console.WriteLine("2 - Remover elemento");
            Console.WriteLine("3 - Listar elementos");
            Console.WriteLine("4 - Pesquisar elemento");
            Console.WriteLine("5 - Ordenar elementos");
            Console.WriteLine("6 - Sair");
            int.TryParse(Console.ReadLine(), out opcao);


            switch (opcao)
            {
                case 1:
                    Console.Write("O que deseja inserir? ");
                    if (int.TryParse(Console.ReadLine(), out int r) && r > 0)
                    {
                        al.Add(r);
                        Console.WriteLine("Elemento adicionado com sucesso \n");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Número inválido, digite um número positivo");
                    }
                    break;
                case 2:
                    Console.Write("Qual elemento deseja remover? ");
                    if (int.TryParse(Console.ReadLine(), out int el) && al.Contains(el))
                    {
                        al.Remove(el);
                        Console.WriteLine("{0} removido com sucesso \n", el);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Número inválido ou não encontrado");
                    }
                    break;
                case 3:
                    Console.WriteLine("Mostrar Array: ");
                    foreach (object o in al)
                    {
                        Console.Write(o + " ");
                    }
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Digite o elemento a ser pesquisado: ");
                    int n = int.Parse(Console.ReadLine());
                    if (al.Contains(n))
                    {
                        Console.WriteLine("Elemento {0} encontrado. \n", n);
                    }
                    else
                    {
                        Console.WriteLine("Elemento não encontrado. \n");
                    }
                    Console.ReadKey();
                    break;
                case 5:
                    al.Sort();
                    Console.WriteLine("Elementos ordeandos com sucesso! \n");
                    Console.ReadKey();
                    break;

                case 6:
                    opcao = 6;
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente");
                    break;
            }
        }
        while (opcao != 6);
    }
}
}
