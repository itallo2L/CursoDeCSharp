using System.Globalization;

namespace CursoDeCSharp.Exercicios.ExerciciosSecao04
{
    // Fazer um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área
    public class Secao0403 : IExercicio
    {
        public string Nome => "Secao0403";

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

    public class Retangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public string Area()
        {
            return $"AREA = {(Largura * Altura).ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public string Perimetro()
        {
            return $"PERIMETRO = {(2 * (Largura + Altura)).ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public string Diagonal()
        {
            return $"DIAGONAL = {Math.Sqrt(Largura * Largura + Altura * Altura).ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
