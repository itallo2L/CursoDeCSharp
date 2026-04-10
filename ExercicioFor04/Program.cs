using System.Globalization;

namespace ExercicioFor04
{
    // Fazer um programa para ler um número N.Depois leia N pares de números e mostre a divisão do primeiro pelo
    // segundo.Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
    public static class Program
    {
        public static void Main()
        {
            int entrada = int.Parse(Console.ReadLine());

            for (int i = 0; i < entrada; i++)
            {
                string[] entradas = Console.ReadLine().Split(' ');
                double a = double.Parse(entradas[0]);
                double b = double.Parse(entradas[1]);

                if (b == 0.0)
                {
                    Console.WriteLine("divisao impossivel");
                    continue;
                };

                Console.WriteLine($"{(a / b).ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }
    }
}