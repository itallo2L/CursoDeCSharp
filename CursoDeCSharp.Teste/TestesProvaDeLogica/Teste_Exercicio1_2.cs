using CursoDeCSharp.Exercicios.ProvaDeLogica;

namespace CursoDeCSharp.Teste.TestesProvaDeLogica
{
    public class Teste_Exercicio1_2 : HelperDosTestes
    {
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
            var areaObtida = CalculadoraDeArea.CalcularArea(raio);

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
            var areaObtida = CalculadoraDeArea.CalcularArea(Raio);

            //Assert
            Assert.Equal(AreaEsperada, areaObtida);
        }

        #endregion;

        #region Program1_2;
        const string CodigoDoExercicio = "2\n";

        [Theory]
        [InlineData("3.00", "28.2743")]
        [InlineData("2.85", "25.5176")]
        [InlineData("6.50", "132.7322")]
        [InlineData("7.99", "200.5594")]
        [InlineData("10.67", "357.6666")]
        public void Program1_2_QuandoRaioTiverPreenchido_DeveRetornarArea(string entradaDeDados, string valorEsperado)
        {
            //Arrange
            var retornoEsperado = $"A={valorEsperado}";
            var entradaCompleta = $"{CodigoDoExercicio}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);

            //Assert
            Assert.Contains(retornoEsperado, retornoNaTela);
        }

        [Fact]
        public void Program1_2_QuandoRaioNaoTiverPreenchido_DeveRetornarZero()
        {
            //Arrange
            const string Entrada = $"{CodigoDoExercicio}00.00";
            const string RetornoEsperado = $"A=0.0000";

            //Act
            var retornoNaTela = ExecutarPrograma(Entrada, Program.Main);

            //Assert
            Assert.Contains(RetornoEsperado, retornoNaTela);
        }

        #endregion;
    }
}