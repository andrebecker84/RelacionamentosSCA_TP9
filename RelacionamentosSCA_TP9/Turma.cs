using System;

namespace RelacionamentosSCA_TP9
{
    public class Turma
    {
        public int Codigo { get; set; }
        public Disciplina Disciplina { get; set; }

        public Turma(Disciplina disciplina)
        {
            Disciplina = disciplina;
        }

        public bool AbrirTurma()
        {
            Console.WriteLine($"A turma {Codigo} foi aberta.");
            return true;
        }

        public string GerarPauta()
        {
            return $"Pauta gerada para a turma {Codigo}.";
        }
    }
}