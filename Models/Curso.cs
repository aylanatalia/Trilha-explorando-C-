using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_explorando_C_.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        //método  adicionar aluno ao curso
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ContarAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de ${Nome}");

            for (int contador00 = 0; contador00 < Alunos.Count; contador00++)
            {
                //string texto = "Numero " + contador00 + " - " + Alunos[contador00].NomeCompleto;
                string texto =$"Número {contador00 + 1} - {Alunos[contador00].NomeCompleto}";
                Console.WriteLine(texto);
            }

            // foreach(Pessoa aluno in Alunos)
            // {
            //     Console.WriteLine(aluno.NomeCompleto);
            // }
        }
    }
}