using System;
using System.Collections.Generic;

namespace RelacionamentosSCA_TP9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definindo cores para os títulos
            ConsoleColor tituloColor = ConsoleColor.Blue;

            // Definindo cores para os conteúdos
            ConsoleColor conteudoColor = ConsoleColor.White;

            // Definindo cor vermelha para as informações sobre os alunos
            ConsoleColor alunoColor = ConsoleColor.Red;

            // Definindo cor verde para informações adicionais sobre as turmas
            ConsoleColor turmaInfoColor = ConsoleColor.Green;

            // Criando disciplinas
            Disciplina disciplina1 = new Disciplina(1, "Desenvolvimento Web com .NET e Bases de Dados");
            Disciplina disciplina2 = new Disciplina(2, "Desenvolvimento de Serviços Web e Testes com Java");
            Disciplina disciplina3 = new Disciplina(3, "Projeto de Bloco: Desenvolvimento Back-end");

            // Criando professores
            Professor professor1 = new Professor(101, "Ricardo Frohlich da Silva", disciplina1);
            Professor professor2 = new Professor(102, "Elberth Lins Costa de Moraes", disciplina2);
            Professor professor3 = new Professor(103, "Luiz Paulo Bomeny Maia", disciplina3);

            // Criando alunos
            List<Aluno> alunos = new List<Aluno>
            {
                new Aluno(1, "André Luis Becker"),
                new Aluno(2, "Calebe Correia Machado"),
                new Aluno(3, "Igor Castro Hoffmann")
            };

            // Criando turmas
            List<Turma> turmas = new List<Turma>
            {
                new Turma(disciplina1) { Codigo = 101 },
                new Turma(disciplina2) { Codigo = 102 },
                new Turma(disciplina3) { Codigo = 103 }
            };

            // Alterando a cor do título para azul
            Console.ForegroundColor = tituloColor;

            // Exibindo os professores
            Console.WriteLine("Professores:");
            Console.WriteLine("------------");

            // Alterando a cor do conteúdo para branca
            Console.ForegroundColor = conteudoColor;

            // Exibindo informações dos professores usando foreach
            foreach (var professor in new Professor[] { professor1, professor2, professor3 })
            {
                // Exibindo nome do professor
                Console.WriteLine($"Nome: {professor.Nome}");
                // Exibindo disciplina associada ao professor
                Console.WriteLine($"Disciplina: {professor.Disciplina.Nome}");
                // Pulando uma linha após a exibição de cada professor
                Console.WriteLine();
            }

            // Pulando uma linha após a exibição dos professores
            Console.WriteLine();

            // Alterando a cor do título para azul
            Console.ForegroundColor = tituloColor;

            // Exibindo as disciplinas
            Console.WriteLine("Disciplinas:");
            Console.WriteLine("------------");

            // Alterando a cor do conteúdo para branca
            Console.ForegroundColor = conteudoColor;

            // Exibindo informações das disciplinas usando foreach
            foreach (var disciplina in new Disciplina[] { disciplina1, disciplina2, disciplina3 })
            {
                // Exibindo código da disciplina
                Console.WriteLine($"Código: {disciplina.Codigo}");
                // Exibindo nome da disciplina
                Console.WriteLine($"Nome: {disciplina.Nome}");
                // Pulando uma linha após a exibição de cada disciplina
                Console.WriteLine();
            }

            // Pulando uma linha após a exibição das disciplinas
            Console.WriteLine();

            // Alterando a cor do título para azul
            Console.ForegroundColor = tituloColor;

            // Exibindo a adição de alunos às turmas
            Console.WriteLine("Adicionando alunos às turmas:");
            Console.WriteLine("-----------------------------");

            // Alterando a cor do conteúdo para branca
            Console.ForegroundColor = conteudoColor;

            // Exibindo informações das turmas e associando disciplinas usando foreach
            foreach (var aluno in alunos)
            {
                // Alterando a cor para vermelha
                Console.ForegroundColor = alunoColor;
                Console.WriteLine($"Aluno: {aluno.Nome}");
                // Resetando a cor para branca
                Console.ForegroundColor = conteudoColor;
                // Adicionando alunos às turmas e verificando se foi bem-sucedido
                if (aluno.AddTurma(turmas[0]))
                {
                    Console.WriteLine($"{aluno.Nome} adicionado à turma {turmas[0].Codigo} com sucesso!");
                    Console.WriteLine();
                }
                if (aluno.AddTurma(turmas[1]))
                {
                    Console.WriteLine($"{aluno.Nome} adicionado à turma {turmas[1].Codigo} com sucesso!");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            // Pulando uma linha após a adição de alunos às turmas
            Console.WriteLine();

            // Alterando a cor do título para azul
            Console.ForegroundColor = tituloColor;

            // Exibindo as turmas dos alunos
            Console.WriteLine("Exibindo as turmas dos alunos:");
            Console.WriteLine("------------------------------");

            // Alterando a cor do conteúdo para branca
            Console.ForegroundColor = conteudoColor;

            // Exibindo informações das turmas dos alunos usando foreach
            foreach (var aluno in alunos)
            {
                // Alterando a cor para vermelha
                Console.ForegroundColor = alunoColor;
                Console.WriteLine($"Aluno: {aluno.Nome}");
                // Resetando a cor para branca
                Console.ForegroundColor = conteudoColor;
                Console.WriteLine(aluno.ExibirTurmas());
                Console.WriteLine();
            }

            // Resetando a cor para o padrão
            Console.ResetColor();
        }
    }
}