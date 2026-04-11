using System.Globalization;

namespace Exercicio05
{
    // Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
    // mostre:
    // a) a área do triângulo retângulo que tem A por base e C por altura.
    // b) a área do círculo de raio C. (pi = 3.14159)
    // c) a área do trapézio que tem A e B por bases e C por altura.
    // d) a área do quadrado que tem lado B.
    // e) a área do retângulo que tem lados A e B.
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Este programa calcula áreas de várias formas geométricas: triângulo, círculo, trapézio, quadrado e retângulo" +
                "\nDigite três valores (A, B e C) separados por espaços:");
            const double Pi = 3.14159;
            string[] arrayDeValores = Console.ReadLine().Split(' ');
            double A = double.Parse(arrayDeValores[0], CultureInfo.InvariantCulture);
            double B = double.Parse(arrayDeValores[1], CultureInfo.InvariantCulture);
            double C = double.Parse(arrayDeValores[2], CultureInfo.InvariantCulture);

            double areaDoTriangulo = (A * C) / 2;
            double areaDoCirculo = Pi * (C * C);
            double areaDoTrapezio = ((A + B) * C) / 2;
            double areaDoQuadrado = B * B;
            double areaDoRetangulo = A * B;

            Console.WriteLine(FormatarResultado("TRIANGULO", areaDoTriangulo));
            Console.WriteLine(FormatarResultado("CIRCULO", areaDoCirculo));
            Console.WriteLine(FormatarResultado("TRAPEZIO", areaDoTrapezio));
            Console.WriteLine(FormatarResultado("QUADRADO", areaDoQuadrado));
            Console.WriteLine(FormatarResultado("RETANGULO", areaDoRetangulo));
        }

        private static string FormatarResultado(string mensagem, double resultado)
        {
            const string QuantidadeDeCasasDecimais = "F3";
            return $"{mensagem}: {resultado.ToString(QuantidadeDeCasasDecimais, CultureInfo.InvariantCulture)}";
        }
    }
}