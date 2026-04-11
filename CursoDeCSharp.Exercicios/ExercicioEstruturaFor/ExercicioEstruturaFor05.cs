namespace CursoDeCSharp.Exercicios.ExercicioEstruturaFor
{
    // Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N - 1) * (N - 2) * (N - 3) * ... * 1.
    // Lembrando que, por definição, fatorial de 0 é 1.
    public class ExercicioEstruturaFor05 : IExercicio
    {
        public string Nome => "ExercicioEstruturaFor05";

        public object Executar()
        {
            Console.WriteLine($"=== {Nome} ===\nEste programa calcula o fatorial de um número" +
                "\nDigite um número inteiro positivo:");
            int entrada = int.Parse(Console.ReadLine());
            
            return CalcularFatorial(entrada).ToString();
        }

        private static long CalcularFatorial(int entrada)
        {
            long fatorial = 1;

            for (int i = 1; i <= entrada; i++)
                fatorial = fatorial * i;

            return fatorial;
        }
    }
}
