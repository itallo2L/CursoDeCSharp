using System.Globalization;

namespace Exercicio1_1
{
    // Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
    // código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Entrada:");
            string entradaUm = Console.ReadLine();
            string entradaDois = Console.ReadLine();

            string[] valoresPecaUm = entradaUm.Split(' ');
            string[] valoresPecaDois = entradaDois.Split(' ');

            int codigoPecaUm = int.Parse(valoresPecaUm[0]);
            int numeroDePecasUm = int.Parse(valoresPecaUm[1]);
            double valorUnitarioPecaUm = double.Parse(valoresPecaUm[2], CultureInfo.InvariantCulture);

            int codigoPecaDois = int.Parse(valoresPecaDois[0]);
            int numeroDePecasDois = int.Parse(valoresPecaDois[1]);
            double valorUnitarioPecaDois = double.Parse(valoresPecaDois[2], CultureInfo.InvariantCulture);

            Console.WriteLine($"VALOR A PAGAR: R$ {CalculadoraDePecas.CalcularValorAPagar(numeroDePecasUm, numeroDePecasDois, valorUnitarioPecaUm, valorUnitarioPecaDois)}");
        }
    }
}