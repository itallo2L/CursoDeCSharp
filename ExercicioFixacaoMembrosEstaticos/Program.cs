using System.Globalization;

namespace ExercicioFixacaoMembrosEstaticos
{
    public static class Program
    {
        // Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por
        // uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda
        // que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda
        // para ser responsável pelos cálculos.
        public static void Main()
        {
            Console.WriteLine("Este programa calcula o valor a pagar em reais para compra de dólares com IOF" +
                "\nDigite a cotação do dólar e a quantidade de dólares a comprar (um por linha):");
            Console.Write("Qual é a cotação do dólar? ");
            double cotacaoDoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double quantidadeDeDolarParaComprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
            Console.Write($"Valor a ser pago em reais = {ConversorDeMoeda.ConverterModeda(cotacaoDoDolar, quantidadeDeDolarParaComprar)}");
        }
    }
}