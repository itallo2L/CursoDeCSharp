using CursoDeCSharp.Exercicios.ProvaDeLogica;

namespace CursoDeCSharp.Teste.TestesProvaDeLogica
{
    public class Teste_Exercicio1_1 : HelperDosTestes
    {

        #region CalcularValorAPagar;

        [Theory]
        [InlineData(5, 7, 15.00, 10.00, "145.00")]
        [InlineData(12, 3, 43.70, 2.99, "533.37")]
        [InlineData(1, 2, 34.59, 112.99, "260.57")]
        [InlineData(100, 4, 0.98, 7.50, "128.00")]
        public void CalcularValorAPagar_QuandoTodosOsCamposEstiveremDevidamentePreenchidos_DeveRetornarValorAPagar(
            int quantidadeDaPrimeiraPeca, int quantidadeDaSegundaPeca, 
            double valorUnitarioDaPrimeiraPeca, double valorUnitarioDaSegundaPeca, 
            string valorEsperado)
        {
            //Arrange & Act
            var valorAPagar = CalculadoraDePecas.CalcularValorAPagar(quantidadeDaPrimeiraPeca, quantidadeDaSegundaPeca, valorUnitarioDaPrimeiraPeca, valorUnitarioDaSegundaPeca);

            //Assert
            Assert.IsType<string>(valorAPagar);
            Assert.Equal(valorEsperado, valorAPagar);
        }

        [Theory]
        [InlineData(0, 0, 00.00, 00.00, "0.00")]
        [InlineData(0, 7, 15.00, 10.00, "70.00")]
        [InlineData(5, 0, 15.00, 10.00, "75.00")]
        [InlineData(5, 7, 00.00, 10.00, "70.00")]
        [InlineData(5, 7, 15.00, 00.00, "75.00")]
        public void CalcularValorAPagar_QuandoValoresSaoZero_DeveRetornarValorCalculado(
            int quantidadeDaPrimeiraPeca, int quantidadeDaSegundaPeca,
            double valorUnitarioDaPrimeiraPeca, double valorUnitarioDaSegundaPeca,
            string valorEsperado)
        {
            //Arrange & Act
            var valorAPagar = CalculadoraDePecas.CalcularValorAPagar(quantidadeDaPrimeiraPeca, quantidadeDaSegundaPeca, valorUnitarioDaPrimeiraPeca, valorUnitarioDaSegundaPeca);

            //Assert
            Assert.IsType<string>(valorAPagar);
            Assert.Equal(valorEsperado, valorAPagar);
        }

        #endregion;

        #region Program1_1;
        const string CODIGO_DO_EXERCICIO = "1\n";

        [Theory]
        [InlineData("12 5 15.00\n13 7 10.00\n", "145.00")] //Cada \n é lido como "Enter"
        [InlineData("5 12 43.70\n2 3 2.99\n", "533.37")]
        [InlineData("9 1 34.59\n8 2 112.99\n", "260.57")]
        [InlineData("6 100 0.98\n7 4 7.50\n", "128.00")]
        public void Exercicio1_1_QuandoSelecionarOpcao1_DeveRetornarValorCorreto(string entradaDeDados, string valorEsperado)
        {
            // Arrange
            var retornoEsperado = $"VALOR A PAGAR: R$ {valorEsperado}";
            var entradaCompleta = $"{CODIGO_DO_EXERCICIO}{entradaDeDados}";

            // Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);

            // Assert
            Assert.Contains(retornoEsperado, retornoNaTela);
        }

        [Theory]
        [InlineData("12 0 00.00\n13 0 00.00\n", "0.00")]
        [InlineData("12 0 15.00\n13 7 10.00\n", "70.00")]
        [InlineData("12 5 00.00\n13 7 10.00\n", "70.00")]
        [InlineData("12 5 15.00\n13 0 10.00\n", "75.00")]
        [InlineData("12 5 15.00\n13 7 00.00\n", "75.00")]
        public void Exercicio1_1_QuandoValoresSaoZero_DeveRetornarValorCalculado(string entradaDeDados, string valorEsperado)
        {
            //Arrange
            var retornoEsperado = $"VALOR A PAGAR: R$ {valorEsperado}";
            var entradaCompleta = $"{CODIGO_DO_EXERCICIO}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);

            //Assert
            Assert.Contains(retornoEsperado, retornoNaTela);
        }

        #endregion;
    }
}