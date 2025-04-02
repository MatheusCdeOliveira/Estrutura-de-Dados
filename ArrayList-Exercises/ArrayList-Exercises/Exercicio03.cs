using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Exercises
{
    // 3 - Faça um programa contendo um ArrayListque armazena Alunos (considere a classe Aluno apresentada nesta sessão) e mostra as seguintes
    // opções de escolha para o usuário: 1 - inserir elemento; 2 - remover elemento; 3 - listar elementos; 4 - pesquisar elemento; 5 - ordenar elementos;
    // e 6 - sair. Quando o usuário escolher uma das opções, o programa realiza a operação escolhida no ArrayList.    
    class Exercicio03
    {
       public static void Executar()
        {
            int opcao;
            ArrayList al = new ArrayList();
            do
            {
                ExibirMenu();
                int.TryParse(Console.ReadLine(), out opcao);


                switch (opcao)
                {
                    case 1:
                        Aluno aluno = new Aluno();
                        InserirAluno(aluno);
                        break;
                    case 2:
                        Console.Write("Matricula do aluno a ser removido: ");
                        Aluno alunoARemover = new Aluno { Matricula = int.Parse(Console.ReadLine()) };
                        RemoverAluno(alunoARemover);
                        break;
                    case 3:
                        ListarAlunos();
                        break;
                    case 4:
                        Console.WriteLine("Nome do aluno a pesquisado: ");
                        EncontrarAluno();
                        break;
                    case 5:
                        al.Sort(new CompareAluno());
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


            void ExibirMenu()
            {
                Console.Clear();
                Console.WriteLine("Escolha uma das opções:");
                Console.WriteLine("1 - Inserir elemento");
                Console.WriteLine("2 - Remover elemento");
                Console.WriteLine("3 - Listar elementos");
                Console.WriteLine("4 - Pesquisar elemento");
                Console.WriteLine("5 - Ordenar elementos");
                Console.WriteLine("6 - Sair");
            }

            void InserirAluno(Aluno aluno)
            {
                Console.Write("Nome do Aluno a ser inserido: ");
                aluno.Nome = Console.ReadLine();
                bool valid = false;
                while (!valid)
                {
                Console.Write("Matricula do Aluno a ser inserido: ");
                aluno.Matricula = int.Parse(Console.ReadLine());
                int index = al.BinarySearch(new Aluno("_", aluno.Matricula, ""), new CompareAlunoPorMatricula());
                if (index >= 0)
                {
                    Console.WriteLine("Matrícula já cadastrada, tente novamente");
                } else
                    {
                       valid = true;  

                    }
                }
                Console.Write("Email do Aluno a ser inserido: ");
                aluno.Email = Console.ReadLine();
                al.Add(aluno);
                Console.WriteLine("Aluno adicionado com sucesso");
                Console.ReadKey();
            }

            void RemoverAluno(Aluno alunoARemover)
            {
                if (al.Contains(alunoARemover))
                {
                    al.Remove(alunoARemover);
                    Console.WriteLine("Aluno removido com sucesso");
                }
                else
                {
                    Console.WriteLine("Aluno não encontrado");

                }
                Console.ReadKey();
            }

            void ListarAlunos()
            {
                Console.WriteLine("Mostrar Array: ");
                foreach (object o in al)
                {
                    ((Aluno)o).Mostrar();
                }
                Console.ReadKey();
            }

            void EncontrarAluno()
            {
                al.Sort(new CompareAluno());
                string nome = Console.ReadLine();
                int posicao = al.BinarySearch(new Aluno(nome, 0, ""), new CompareAluno());
                if (posicao >= 0)
                {
                    Console.Write("Aluno encontrado: {0}", al[posicao].ToString());
                }
                else
                {
                    Console.WriteLine("Aluno não encontrado");
                }
                Console.ReadKey();
            }
        }

        
    }
}
