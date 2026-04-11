namespace ExercicioFor06
{
    // Ler um número inteiro N e calcular todos os seus divisores.
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Este programa calcula e mostra todos os divisores de um número" +
                "\nDigite um número inteiro:");
            int entrada = int.Parse(Console.ReadLine());

            for (int i = 1; i <= entrada; i++)
                if (entrada % i == 0)
                    Console.WriteLine(i);
        }
    }
}