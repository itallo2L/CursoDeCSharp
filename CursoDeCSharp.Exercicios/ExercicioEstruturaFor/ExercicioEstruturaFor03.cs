using CursoDeCSharp.Exercicios.Helpers;

namespace CursoDeCSharp.Exercicios.ExercicioEstruturaFor
{
    // Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
    // de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
    // conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
    // peso 5.
    public class ExercicioEstruturaFor03 : IExercicio
    {
        public string Nome => "ExercicioEstruturaFor03";
        public int Ordem => 22;

        public object Executar()
        {
            Console.WriteLine($"=== {Nome} ===\nEste programa calcula a média ponderada de conjuntos de três valores" +
                "\nDigite a quantidade de casos de teste, depois para cada caso três valores:");
            int entrada = int.Parse(Console.ReadLine());
            
            return HelperExerciciosEstruturaFor.CalcularMediasPonderadas(entrada);
        }
    }
}