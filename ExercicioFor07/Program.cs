namespace ExercicioFor07
{
    public static class Program
    {
        // Fazer um programa para ler um número inteiro positivo N.O programa deve então mostrar na tela N linhas,
        // começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
        // exemplo.
        public static void Main()
        {
            int entrada = int.Parse(Console.ReadLine());

            for (int i = 1; i <= entrada; i++)
            {
                Console.WriteLine($"{i} {i * i} {i * i * i}");
            };
        }
    }
}