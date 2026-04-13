namespace CursoDeCSharp.Exercicios.ExerciciosEstruturaCondicional
{
    // Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não
    public class ExercicioCondicional01 : IExercicio
    {
        public string Nome => "ExercicioCondicional01";
        public int Ordem => 13;

        public object Executar()
        {
            Console.WriteLine($"=== {Nome} ===\nEste programa verifica se um número é negativo ou não" +
                "\nDigite um número inteiro:");
            int valorInteiro = int.Parse(Console.ReadLine());

            if (valorInteiro < 0)
                return "NEGATIVO";
            else
                return "NAO NEGATIVO";
        }
    }
}
