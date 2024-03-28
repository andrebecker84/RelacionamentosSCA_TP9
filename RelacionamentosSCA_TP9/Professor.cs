namespace RelacionamentosSCA_TP9
{
    public class Professor
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public Disciplina Disciplina { get; set; }

        public Professor(int matricula, string nome, Disciplina disciplina)
        {
            Matricula = matricula;
            Nome = nome;
            Disciplina = disciplina;
        }
    }
}