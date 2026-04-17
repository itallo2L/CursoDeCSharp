using CursoDeCSharp.Exercicios.Helpers;

namespace CursoDeCSharp.Teste.TestesDosHelpers
{
    public class TesteHelperProvaDeLogica
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
            var valorAPagar = HelperProvaDeLogica.CalcularValorAPagar(quantidadeDaPrimeiraPeca, quantidadeDaSegundaPeca, valorUnitarioDaPrimeiraPeca, valorUnitarioDaSegundaPeca);

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
            var valorAPagar = HelperProvaDeLogica.CalcularValorAPagar(quantidadeDaPrimeiraPeca, quantidadeDaSegundaPeca, valorUnitarioDaPrimeiraPeca, valorUnitarioDaSegundaPeca);

            //Assert
            Assert.IsType<string>(valorAPagar);
            Assert.Equal(valorEsperado, valorAPagar);
        }

        #endregion;

        #region CalcularArea;

        [Theory]
        [InlineData(3.00, "28.2743")]
        [InlineData(2.85, "25.5176")]
        [InlineData(6.50, "132.7322")]
        [InlineData(7.99, "200.5594")]
        [InlineData(10.67, "357.6666")]
        public void CalcularArea_QuandoRaioTiverPreenchido_DeveRetornarArea(double raio, string areaEsperada)
        {
            //Arrange & Act
            var areaObtida = HelperProvaDeLogica.CalcularArea(raio);

            //Assert
            Assert.Equal(areaEsperada, areaObtida);
        }

        [Fact]
        public void CalcularArea_QuandoRaioNaoTiverPreenchido_DeveRetornarZero()
        {
            //Arrange
            const double Raio = 00.00;
            const string AreaEsperada = "0.0000";

            //Act
            var areaObtida = HelperProvaDeLogica.CalcularArea(Raio);

            //Assert
            Assert.Equal(AreaEsperada, areaObtida);
        }

        #endregion;
    }
}