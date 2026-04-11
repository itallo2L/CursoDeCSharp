namespace CursoDeCSharp.Exercicios.ExercicioEstruturaFor
{
    // Ler um número inteiro N e calcular todos os seus divisores.
    public class ExercicioEstruturaFor06 : IExercicio
    {
        public string Nome => "ExercicioEstruturaFor06";

        public object Executar()
        {
            Console.WriteLine("Este programa calcula e mostra todos os divisores de um número" +
                "\nDigite um número inteiro:");
            int entrada = int.Parse(Console.ReadLine());
            
            return ObterDivisores(entrada);
        }

        private static string ObterDivisores(int entrada)
        {
            string resultado = "";
            
            for (int i = 1; i <= entrada; i++)
                if (entrada % i == 0)
                    resultado += $"{i}\n";
            
            return resultado.TrimEnd();
        }
    }
}
