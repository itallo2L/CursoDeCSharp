namespace ExercicioFor01
{
    public static class Program
    {
        // Leia um valor inteiro X(1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
        // X, se for o caso.
        public static void Main()
        {
            Console.WriteLine("Este programa mostra todos os números ímpares de 1 até um valor X" +
                "\nDigite um número inteiro entre 1 e 1000:");
            int entrada = int.Parse(Console.ReadLine());

            for (int i = 1; i <= entrada; i+=2)
                Console.WriteLine(i);
        }
    }
}