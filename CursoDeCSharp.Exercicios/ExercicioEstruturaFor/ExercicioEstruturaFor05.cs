using CursoDeCSharp.Exercicios.Helpers;

namespace CursoDeCSharp.Exercicios.ExercicioEstruturaFor
{
    // Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N - 1) * (N - 2) * (N - 3) * ... * 1.
    // Lembrando que, por definição, fatorial de 0 é 1.
    public class ExercicioEstruturaFor05 : IExercicio
    {
        public string Nome => "ExercicioEstruturaFor05";
        public int Ordem => 24;

        public object Executar()
        {
            Console.WriteLine($"=== {Nome} ===\nEste programa calcula o fatorial de um número" +
                "\nDigite um número inteiro positivo:");
            int entrada = int.Parse(Console.ReadLine());
            
            return HelperExerciciosEstruturaFor.CalcularFatorial(entrada).ToString();
        }
    }
}