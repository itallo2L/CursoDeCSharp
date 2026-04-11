using System.Globalization;

namespace ExercicioUmSec04
{
    // Fazer um programa para ler os valores da largura e altura
    // de um retângulo.Em seguida, mostrar na tela o valor de
    // sua área, perímetro e diagonal.Usar uma classe como
    // mostrado no projeto ao lado.
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Este programa calcula área, perímetro e diagonal de um retângulo" +
                "\nDigite a largura e altura do retângulo (um por linha):");
            Retangulo retangulo = new Retangulo();

            string altura = Console.ReadLine();
            string largura = Console.ReadLine();

            retangulo.Altura = double.Parse(altura, CultureInfo.InvariantCulture);
            retangulo.Largura = double.Parse(largura, CultureInfo.InvariantCulture);
            
            Console.WriteLine(retangulo.Area());
            Console.WriteLine(retangulo.Perimetro());
            Console.WriteLine(retangulo.Diagonal());
        }
    }
}