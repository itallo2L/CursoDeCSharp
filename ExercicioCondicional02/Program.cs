namespace ExercicioCondicional02
{
    // Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Este programa verifica se um número é par ou ímpar" +
                "\nDigite um número inteiro:");
            int numeroInteiro = int.Parse(Console.ReadLine());
            var restoDaDivisao = numeroInteiro % 2;

            if (restoDaDivisao != 0)
                Console.WriteLine("IMPAR");
            else
                Console.WriteLine("PAR");
        }
    }
}