using Exercicio2_1;
using System.Globalization;

namespace CursoDeCSharp.Exercicios.ProvaDeLogica
{
    // Com base na tabela de preços ao lado, faça um programa que leia o código de um item e a
    // quantidade deste item.A seguir, calcule e mostre o valor da conta a pagar.
    public class Exercicio2_1 : IExercicio
    {
        public string Nome => "Exercicio2_1";

        public object Executar()
        {
            Console.WriteLine("Este programa calcula o valor da conta com base em uma tabela de preços" +
                "\nDigite o código do item e a quantidade (mesma linha):");
            string entrada = Console.ReadLine();

            string[] valoresItem = entrada.Split(' ');
            int codigo = int.Parse(valoresItem[0], CultureInfo.InvariantCulture);
            int quantidade = int.Parse(valoresItem[1], CultureInfo.InvariantCulture);

            Produto produto = new() { Codigo = codigo };

            return $"Total: R$ {produto.CalcularValorDaConta(quantidade)}";
        }
    }
}