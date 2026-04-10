namespace Exercicio01
{
    //  Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
    //  mensagem explicativa
    public static class Program
    {
        public static void Main()
        {
            int primeiroValor = int.Parse(Console.ReadLine());
            int segundoValor = int.Parse(Console.ReadLine());
            Console.WriteLine($"SOMA = {primeiroValor + segundoValor}");
        }
    }
}