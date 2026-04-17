using CursoDeCSharp.Exercicios.Helpers;

namespace CursoDeCSharp.Exercicios.ExercicioEstruturaFor
{
    // Ler um número inteiro N e calcular todos os seus divisores.
    public class ExercicioEstruturaFor06 : IExercicio
    {
        public string Nome => "ExercicioEstruturaFor06";
        public int Ordem => 25;

        public object Executar()
        {
            Console.WriteLine($"=== {Nome} ===\nEste programa calcula e mostra todos os divisores de um número" +
                "\nDigite um número inteiro:");
            int entrada = int.Parse(Console.ReadLine());
            
            return HelperExerciciosEstruturaFor.ObterDivisores(entrada);
        }
    }
}