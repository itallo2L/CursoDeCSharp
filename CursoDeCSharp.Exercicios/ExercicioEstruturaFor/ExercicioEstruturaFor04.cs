using CursoDeCSharp.Exercicios.Helpers;

namespace CursoDeCSharp.Exercicios.ExercicioEstruturaFor
{
    // Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
    // segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
    public class ExercicioEstruturaFor04 : IExercicio
    {
        public string Nome => "ExercicioEstruturaFor04";
        public int Ordem => 23;

        public object Executar()
        {
            Console.WriteLine($"=== {Nome} ===\nEste programa calcula a divisão de N pares de números" +
                "\nDigite a quantidade de pares, depois pares de números separados por espaço:");
            int entrada = int.Parse(Console.ReadLine());
            
            return HelperExerciciosEstruturaFor.CalcularDivisoes(entrada);
        }
    }
}