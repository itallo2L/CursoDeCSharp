using System.Globalization;

namespace CursoDeCSharp.Exercicios.ProvaDeLogica.Helpers
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Especificacao { get; set; }
        public double Preco { get; set; }

        public string CalcularValorDaConta(int quantidade)
        {
            Produto produto = ObterProdutoPorCodigo();
            return (produto.Preco * quantidade).ToString("F2", CultureInfo.InvariantCulture);
        }

        public Produto ObterProdutoPorCodigo()
        {
            List<Produto> listaDeProdutos =
            [
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
            ];

            return listaDeProdutos[Codigo - 1];
        }
    }
}