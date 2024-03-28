using System;
using System.Collections.Generic;
using System.Text;

namespace RelacionamentosSCA_TP9
{
    public class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public List<Turma> Turmas { get; set; }

        public Aluno(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
            Turmas = new List<Turma>();
        }

        public bool AddTurma(Turma turma)
        {
            Turmas.Add(turma);
            // Alterando a cor para verde
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Adicionando {Nome} à turma {turma.Codigo}...");
            // Resetando a cor para branca
            Console.ForegroundColor = ConsoleColor.White;
            return true;
        }

        public string ExibirTurmas()
        {
            StringBuilder resultBuilder = new StringBuilder();
            foreach (var turma in Turmas)
            {
                resultBuilder.Append($"Turma:\n   {turma.Codigo}\nDisciplina:\n   {turma.Disciplina.Nome}\n\n");
            }
            return resultBuilder.ToString();
        }
    }
}