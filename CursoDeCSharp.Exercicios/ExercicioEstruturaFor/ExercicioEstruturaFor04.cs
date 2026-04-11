using System.Globalization;

namespace CursoDeCSharp.Exercicios.ExercicioEstruturaFor
{
    // Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
    // segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
    public class ExercicioEstruturaFor04 : IExercicio
    {
        public string Nome => "ExercicioEstruturaFor04";

        public object Executar()
        {
            Console.WriteLine("Este programa calcula a divisão de N pares de números" +
                "\nDigite a quantidade de pares, depois pares de números separados por espaço:");
            int entrada = int.Parse(Console.ReadLine());
            
            return CalcularDivisoes(entrada);
        }

        private static string CalcularDivisoes(int entrada)
        {
            string resultado = "";
            
            for (int i = 0; i < entrada; i++)
            {
                string[] entradas = Console.ReadLine().Split(' ');
                double a = double.Parse(entradas[0], CultureInfo.InvariantCulture);
                double b = double.Parse(entradas[1], CultureInfo.InvariantCulture);

                if (b == 0.0)
                    resultado += "divisao impossivel\n";
                else
                    resultado += $"{(a / b).ToString("F1", CultureInfo.InvariantCulture)}\n";
            }
            
            return resultado.TrimEnd();
        }
    }
}
