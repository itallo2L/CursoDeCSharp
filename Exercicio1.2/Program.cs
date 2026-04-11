using System.Globalization;

namespace Exercicio1_2
{
    // Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
    // casas decimais conforme exemplos.
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Este programa calcula a área de um círculo" +
                "\nDigite o valor do raio do círculo:");
            string entrada = Console.ReadLine();
            double raio = double.Parse(entrada, CultureInfo.InvariantCulture);
            Console.WriteLine($"A={CalculadoraDeArea.CalcularArea(raio)}");
        }
    }
}