namespace ExercicioFor06
{
    // Ler um número inteiro N e calcular todos os seus divisores.
    public static class Program
    {
        public static void Main()
        {
            int entrada = int.Parse(Console.ReadLine());

            for (int i = 1; i <= entrada; i++)
                if (entrada % i == 0)
                    Console.WriteLine(i);
        }
    }
}