using System.Globalization;

namespace CursoDeCSharp.Exercicios.Helpers
{
    public static class HelperExerciciosSecao04
    {
        public static string ObterNomeDaPessoaMaisVelha(Pessoa pessoaUm, Pessoa pessoaDois)
        {
            if (pessoaUm.Idade > pessoaDois.Idade)
                return $"Pessoa mais velha: {pessoaUm.Nome}";
            else if (pessoaDois.Idade > pessoaUm.Idade)
                return $"Pessoa mais velha: {pessoaDois.Nome}";

            return "Ambas têm a mesma idade";
        }

        public static double ObterEntradaDouble()
        {
            return double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public static class ConversorDeMoeda
        {
            public static double IOF = 0.06;

            public static string ConverterMoeda(double cotacao, double quantidade)
            {
                double valorTotal = quantidade * cotacao * (1.0 + IOF);
                return valorTotal.ToString("F2", CultureInfo.InvariantCulture);
            }
        }
    }
}