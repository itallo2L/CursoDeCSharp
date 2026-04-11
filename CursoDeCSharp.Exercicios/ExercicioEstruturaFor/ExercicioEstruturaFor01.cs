namespace CursoDeCSharp.Exercicios.ExercicioEstruturaFor
{
    // Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
    // X, se for o caso.
    public class ExercicioEstruturaFor01 : IExercicio
    {
        public string Nome => "ExercicioEstruturaFor01";

        public object Executar()
        {
            Console.WriteLine($"=== {Nome} ===\nEste programa mostra todos os números ímpares de 1 até um valor X" +
                "\nDigite um número inteiro entre 1 e 1000:");
            int entrada = int.Parse(Console.ReadLine());
            
            return ObterImpares(entrada);
        }

        private static string ObterImpares(int entrada)
        {
            string resultado = "";
            for (int i = 1; i <= entrada; i += 2)
                resultado += $"{i}\n";
            
            return resultado.TrimEnd();
        }
    }
}
