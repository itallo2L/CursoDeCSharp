namespace Exercicio03
{
    // Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
    // de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A* B - C* D).
    public static class Program
    {
        public static void Main()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            Console.WriteLine($"DIFERENCA = {A * B - C * D}");
        }
    }
}