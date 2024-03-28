namespace RelacionamentosSCA_TP9
{
    public class Disciplina
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Disciplina(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
    }
}