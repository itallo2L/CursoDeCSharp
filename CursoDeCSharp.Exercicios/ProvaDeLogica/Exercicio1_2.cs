using System.Globalization;

namespace CursoDeCSharp.Exercicios.ProvaDeLogica
{
    // Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
    // casas decimais conforme exemplos.
    public class Exercicio1_2 : IExercicio
    {
        public string Nome => "Exercicio1_2";

        public object Executar()
        {
            Console.WriteLine("Este programa calcula a área de um círculo" +
                "\nDigite o valor do raio do círculo:");
            string entrada = Console.ReadLine();
            double raio = double.Parse(entrada, CultureInfo.InvariantCulture);
            return $"A={CalculadoraDeArea.CalcularArea(raio)}";
        }
    }
}