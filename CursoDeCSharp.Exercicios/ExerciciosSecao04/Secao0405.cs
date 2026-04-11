using System.Globalization;

namespace CursoDeCSharp.Exercicios.ExerciciosSecao04
{
    // Fazer um programa para ler o nome de um aluno e as três notas do ano
    public class Secao0405 : IExercicio
    {
        public string Nome => "Secao0405";

        public object Executar()
        {
            Console.WriteLine("Este programa lê dados de um aluno e calcula a nota final anual" +
                "\nDigite o nome do aluno, depois as três notas (uma por linha):");
            Aluno aluno = new Aluno();
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.NotaPrimeiroTrimestre = ObterEntradaDouble();
            aluno.NotaSegundoTrimestre = ObterEntradaDouble();
            aluno.NotaTerceiroTrimestre = ObterEntradaDouble();

            return aluno.CalcularNotaFinal();
        }

        private static double ObterEntradaDouble()
        {
            return double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
    }

    public class Aluno
    {
        public string Nome { get; set; }
        public double NotaPrimeiroTrimestre { get; set; }
        public double NotaSegundoTrimestre { get; set; }
        public double NotaTerceiroTrimestre { get; set; }

        public string CalcularNotaFinal()
        {
            double notaFinal = (NotaPrimeiroTrimestre * 0.3) + (NotaSegundoTrimestre * 0.35) + (NotaTerceiroTrimestre * 0.35);
            
            string resultado = $"NOTA FINAL = {notaFinal.ToString("F2", CultureInfo.InvariantCulture)}\n";
            
            if (notaFinal >= 60)
                resultado += "APROVADO";
            else
            {
                resultado += "REPROVADO\n";
                resultado += $"FALTA = {(60 - notaFinal).ToString("F2", CultureInfo.InvariantCulture)}";
            }
            
            return resultado;
        }
    }
}
