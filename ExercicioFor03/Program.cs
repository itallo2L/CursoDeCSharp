using System.Globalization;

namespace ExercicioFor03
{
    public static class Program
    {
        // Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir.Cada caso de teste consiste
        // de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
        // conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
        // peso 5.
        public static void Main()
        {
            Console.WriteLine("Este programa calcula a média ponderada de conjuntos de três valores" +
                "\nDigite a quantidade de casos de teste, depois para cada caso três valores:");
            int entrada = int.Parse(Console.ReadLine());

            for (int i = 0; i < entrada; i++)
            {
                string[] entradas = Console.ReadLine().Split(' ');
                double x = double.Parse(entradas[0], CultureInfo.InvariantCulture);
                double y = double.Parse(entradas[1], CultureInfo.InvariantCulture);
                double z = double.Parse(entradas[2], CultureInfo.InvariantCulture);

                double media = ((x * 2.0) + (y * 3.0) + (z * 5.0)) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}