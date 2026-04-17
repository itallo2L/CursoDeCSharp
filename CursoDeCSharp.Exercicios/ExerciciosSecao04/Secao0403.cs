using CursoDeCSharp.Exercicios.Helpers;
using System.Globalization;

namespace CursoDeCSharp.Exercicios.ExerciciosSecao04
{
    // Fazer um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área
    public class Secao0403 : IExercicio
    {
        public string Nome => "Secao0403";
        public int Ordem => 9;

        public object Executar()
        {
            Console.WriteLine($"=== {Nome} ===\nEste programa calcula área, perímetro e diagonal de um retângulo" +
                "\nDigite a largura e altura do retângulo (um por linha):");
            Retangulo retangulo = new Retangulo();

            string altura = Console.ReadLine();
            string largura = Console.ReadLine();

            retangulo.Altura = double.Parse(altura, CultureInfo.InvariantCulture);
            retangulo.Largura = double.Parse(largura, CultureInfo.InvariantCulture);

            return $"{retangulo.Area()}\n{retangulo.Perimetro()}\n{retangulo.Diagonal()}";
        }
    }
}