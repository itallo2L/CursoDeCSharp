using System.Globalization;

namespace ExercicioCondicional06
{
    public static class Program
    {
        // Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
        // seguintes intervalos([0, 25], (25,50], (50,75], (75,100]) este valor se encontra.Obviamente se o valor não estiver em
        // nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
        public static void Main()
        {
            Console.WriteLine("Este programa determina em qual intervalo um valor se encontra" +
                "\nDigite um valor numérico:");
            double valorQualquer = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valorQualquer >= 0.0 && valorQualquer <= 25.0)
                Console.WriteLine("Intervalo (0,25]");
            else if (valorQualquer > 25.0 && valorQualquer <= 50.0)
                Console.WriteLine("Intervalo (25,50]");
            else if (valorQualquer > 50 && valorQualquer <= 75)
                Console.WriteLine("Intervalo (50,75]");
            else if (valorQualquer > 75 && valorQualquer <= 100)
                Console.WriteLine("Intervalo (75,100]");
            else
                Console.WriteLine("Fora de intervalo");
        }
    }
}