using CursoDeCSharp.Exercicios.Helpers;
using System.Globalization;

namespace CursoDeCSharp.Exercicios.ExerciciosSecao04
{
    // Faça um programa para ler a cotação do dólar, e depois um valor em dólares para converter em reais
    public class Secao0406 : IExercicio
    {
        public string Nome => "Secao0406";
        public int Ordem => 12;

        public object Executar()
        {
            Console.WriteLine($"=== {Nome} ===\nEste programa calcula o valor a pagar em reais para compra de dólares com IOF" +
                "\nDigite a cotação do dólar e a quantidade de dólares a comprar (um por linha):");
            Console.Write("Qual é a cotação do dólar? ");
            double cotacaoDoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double quantidadeDeDolarParaComprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return $"Valor a ser pago em reais = {HelperExerciciosSecao04.ConversorDeMoeda.ConverterMoeda(cotacaoDoDolar, quantidadeDeDolarParaComprar)}";
        }
    }
}