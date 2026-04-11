using System.Globalization;

namespace CursoDeCSharp.Exercicios.ExerciciosEstruturaSequencial
{
    // Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre
    // as áreas do triângulo retângulo, círculo, trapézio, quadrado e retângulo.
    public class ExercicioSequencial04 : IExercicio
    {
        public string Nome => "ExercicioSequencial04";

        public object Executar()
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

            string resultado = "";
            resultado += FormatarResultado("TRIANGULO", areaDoTriangulo) + "\n";
            resultado += FormatarResultado("CIRCULO", areaDoCirculo) + "\n";
            resultado += FormatarResultado("TRAPEZIO", areaDoTrapezio) + "\n";
            resultado += FormatarResultado("QUADRADO", areaDoQuadrado) + "\n";
            resultado += FormatarResultado("RETANGULO", areaDoRetangulo);
            
            return resultado;
        }

        private static string FormatarResultado(string mensagem, double resultado)
        {
            const string QuantidadeDeCasasDecimais = "F3";
            return $"{mensagem}: {resultado.ToString(QuantidadeDeCasasDecimais, CultureInfo.InvariantCulture)}";
        }
    }
}
