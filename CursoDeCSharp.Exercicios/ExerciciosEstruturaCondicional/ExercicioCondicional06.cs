using System.Globalization;

namespace CursoDeCSharp.Exercicios.ExerciciosEstruturaCondicional
{
    // Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
    // seguintes intervalos ([0, 25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
    // nenhum destes intervalos, deverá ser impressa a mensagem "Fora de intervalo".
    public class ExercicioCondicional06 : IExercicio
    {
        public string Nome => "ExercicioCondicional06";
        public int Ordem => 17;

        public object Executar()
        {
            Console.WriteLine($"=== {Nome} ===\nEste programa determina em qual intervalo um valor se encontra" +
                "\nDigite um valor numérico:");
            double valorQualquer = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valorQualquer >= 0.0 && valorQualquer <= 25.0)
                return "Intervalo (0,25]";
            else if (valorQualquer > 25.0 && valorQualquer <= 50.0)
                return "Intervalo (25,50]";
            else if (valorQualquer > 50 && valorQualquer <= 75)
                return "Intervalo (50,75]";
            else if (valorQualquer > 75 && valorQualquer <= 100)
                return "Intervalo (75,100]";
            else
                return "Fora de intervalo";
        }
    }
}
