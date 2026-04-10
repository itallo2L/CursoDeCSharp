using System.Globalization;

namespace Exercicio2_1
{
    // Com base na tabela de preços ao lado, faça um programa que leia o código de um item e a
    // quantidade deste item.A seguir, calcule e mostre o valor da conta a pagar.
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Entrada:");
            string entrada = Console.ReadLine();

            string[] valoresItem = entrada.Split(' ');
            int codigo = int.Parse(valoresItem[0], CultureInfo.InvariantCulture);
            int quantidade = int.Parse(valoresItem[1], CultureInfo.InvariantCulture);

            Console.WriteLine($"Total: R$ {CalcularValorDaConta(codigo, quantidade)}");
        }

        private static string CalcularValorDaConta(int codigo, int quantidade)
        {
            Produto produto = ObterProdutoPorCodigo(codigo);
            return (produto.Preco * quantidade).ToString("F2", CultureInfo.InvariantCulture);
        }

        private static Produto ObterProdutoPorCodigo(int codigo)
        {
            List<Produto> listaDeProdutos = new List<Produto>() 
            {
                new()
                {
                    Codigo = 1,
                    Especificacao = "Cachorro Quente",
                    Preco = 4.00
                },
                new()
                {
                    Codigo = 2,
                    Especificacao = "X-Salada",
                    Preco = 4.50
                },
                new()
                {
                    Codigo = 3,
                    Especificacao = "X-Bacon",
                    Preco = 5.00
                },
                new()
                {
                    Codigo = 4,
                    Especificacao = "Torrada simples",
                    Preco = 2.00
                },
                new()
                {
                    Codigo = 5,
                    Especificacao = "Refrigerante",
                    Preco = 1.50
                }
            };

            return listaDeProdutos[codigo - 1];
        }
    }
}