using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Exercises { 


    class CompareAluno : IComparer
{
    public int Compare(Object a1, Object a2)
    {
       return ((Aluno)a1).Nome.CompareTo(((Aluno)a2).Nome);
    }
}

    class CompareAlunoPorMatricula : IComparer
    {
        public int Compare(Object a1, Object a2)
        {
            return ((Aluno)a1).Matricula.CompareTo(((Aluno)a2).Matricula);
        }
    }


    class Aluno
    {
        private string nome;
        private int matricula;
        private string email;

        public string Nome { get => nome; set => nome = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Nome não pode ser vazio.") : value; }
        public int Matricula { get => matricula; set => matricula = (value >= 0) ? value : throw new ArgumentOutOfRangeException("Matricula não pode ser negativa."); }
        public string Email { get => email; set => email = value; }

        public Aluno()
        {

        }

        public Aluno(string nome, int matricula, string email)
        {
            Nome = nome;
            Matricula = matricula;
            Email = email;
        }


        public void Mostrar()
        {
            Console.WriteLine($"Nome: {Nome} - Matricula: {Matricula} - Email: {Email}");
        }

        public override string ToString()
        {
            return $"Nome: {Nome} - Matricula: {Matricula} - Email: {Email}";
        }

        public override bool Equals(object obj)
        {
            return obj is Aluno aluno &&
                   matricula == aluno.matricula;
        }

        public override int GetHashCode()
        {
            return 1182032079 + matricula.GetHashCode();
        }
    }
}
