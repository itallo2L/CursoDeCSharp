using System.Globalization;

namespace CursoDeCSharp.Exercicios.ProvaDeLogica
{
    // Ler os valores dos três coeficientes "a", "b" e "c" de uma equação do segundo grau (ax² + bx + c = 0)
    // Em seguida, mostrar os valores das raízes da equação, conforme exemplos, usando a fórmula de Bhaskara.
    // Se a equação não possuir raízes (o valor de "a" não pode ser zero, e o valor de "delta" não pode ser
    // negativo), mostrar uma mensagem "Impossivel calcular".
    public class Exercicio2_2 : IExercicio
    {
        public string Nome => "Exercicio2_2";

        public object Executar()
        {
            Console.WriteLine($"=== {Nome} ===\nEste programa calcula as raízes de uma equação de segundo grau" +
                "\nDigite três números na mesma linha (a, b e c):");
            string[] valoresABC = Console.ReadLine().Split(' ');
            return CalcularEquacaoDeSegundoGrau(valoresABC);
        }

        private static string CalcularEquacaoDeSegundoGrau(string[] valoresABC)
        {
            const string MensagemImpossivelCalcular = "Impossível calcular";
            double a = double.Parse(valoresABC[0]);

            if (a == 0)
                return MensagemImpossivelCalcular;

            double b = double.Parse(valoresABC[1]);
            double c = double.Parse(valoresABC[2]);

            double delta = (b * b) - (4 * a * c);

            if (delta < 0)
                return MensagemImpossivelCalcular;

            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            return $"X1 = {x1.ToString("F5", CultureInfo.InvariantCulture)}\nX2 = {x2.ToString("F5", CultureInfo.InvariantCulture)}";
        }
    }
}
