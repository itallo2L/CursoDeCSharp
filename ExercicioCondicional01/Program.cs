namespace ExercicioCondicional01
{
    // Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não
    public static class Program
    {
        public static void Main()
        {
            int valorInteiro = int.Parse(Console.ReadLine());

            if (valorInteiro < 0)
                Console.WriteLine("NEGATIVO");
            else
                Console.WriteLine("NAO NEGATIVO");
        }
    }
}