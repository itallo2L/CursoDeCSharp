namespace ExercicioFor05
{
    public static class Program
    {
        // Ler um valor N.Calcular e escrever seu respectivo fatorial.Fatorial de N = N * (N - 1) * (N - 2) * (N - 3) * ... *1.
        // Lembrando que, por definição, fatorial de 0 é 1.
        public static void Main()
        {
            Console.WriteLine("Este programa calcula o fatorial de um número" +
                "\nDigite um número inteiro positivo:");
            int entrada = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int i = 1; i <= entrada; i++)
                fatorial = fatorial * i;

            Console.WriteLine(fatorial);
        }
    }
}