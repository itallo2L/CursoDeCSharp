namespace ExercicioCondicional01
{
    // Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Este programa verifica se um número é negativo ou não" +
                "\nDigite um número inteiro:");
            int valorInteiro = int.Parse(Console.ReadLine());

            if (valorInteiro < 0)
                Console.WriteLine("NEGATIVO");
            else
                Console.WriteLine("NAO NEGATIVO");
        }
    }
}