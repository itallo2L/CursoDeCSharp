namespace CursoDeCSharp.Exercicios.ExerciciosEstruturaCondicional
{
    // Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
    public class ExercicioCondicional02 : IExercicio
    {
        public string Nome => "ExercicioCondicional02";

        public object Executar()
        {
            Console.WriteLine($"=== {Nome} ===\nEste programa verifica se um número é par ou ímpar" +
                "\nDigite um número inteiro:");
            int numeroInteiro = int.Parse(Console.ReadLine());
            var restoDaDivisao = numeroInteiro % 2;

            if (restoDaDivisao != 0)
                return "IMPAR";
            else
                return "PAR";
        }
    }
}
