namespace Exercicio01
{
    //  Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
    //  mensagem explicativa
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Este programa lé dois valores inteiros e mostra a soma desses números" +
                "\nDigite dois valores inteiros (um por linha):");
            int primeiroValor = int.Parse(Console.ReadLine());
            int segundoValor = int.Parse(Console.ReadLine());
            Console.WriteLine($"SOMA = {primeiroValor + segundoValor}");
        }
    }
}