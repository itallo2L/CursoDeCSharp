using CursoDeCSharp.Exercicios.Helpers;

namespace CursoDeCSharp.Exercicios.ExerciciosSecao04
{
    // Fazer um programa para ler o nome de um aluno e as três notas do ano
    public class Secao0405 : IExercicio
    {
        public string Nome => "Secao0405";
        public int Ordem => 11;

        public object Executar()
        {
            Console.WriteLine($"=== {Nome} ===\nEste programa lê dados de um aluno e calcula a nota final anual" +
                "\nDigite o nome do aluno, depois as três notas (uma por linha):");
            Aluno aluno = new Aluno();
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.NotaPrimeiroTrimestre = HelperExerciciosSecao04.ObterEntradaDouble();
            aluno.NotaSegundoTrimestre = HelperExerciciosSecao04.ObterEntradaDouble();
            aluno.NotaTerceiroTrimestre = HelperExerciciosSecao04.ObterEntradaDouble();

            return aluno.CalcularNotaFinal();
        }
    }
}