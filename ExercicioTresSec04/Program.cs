using System.Globalization;

namespace ExercicioTresSec04
{
    // Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
    // (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
    // ano.Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam para o
    // aluno obter o mínimo para ser aprovado(que é 60 pontos). Você deve criar uma classe Aluno para resolver este
    // problema.
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Este programa lê dados de um aluno e calcula a nota final anual" +
                "\nDigite o nome do aluno, depois as três notas (uma por linha):");
            Aluno aluno = new Aluno();
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.NotaPrimeiroTrimeste = ObterEntradaDouble();
            aluno.NotaSegundoTrimeste = ObterEntradaDouble();
            aluno.NotaTerceiroTrimeste = ObterEntradaDouble();

            Console.WriteLine(aluno.CalcularNotaFinal());
        }

        private static double ObterEntradaDouble()
        {
            return double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
    }
}