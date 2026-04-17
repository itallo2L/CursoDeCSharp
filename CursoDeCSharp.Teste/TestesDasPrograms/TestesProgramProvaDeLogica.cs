namespace CursoDeCSharp.Teste.TestesDasPrograms
{
    public class TestesProgramProvaDeLogica : HelperDosTestes
    {
        #region Exercicio1_1;
        const string CodigoDoExercicio1_1 = "1\n";

        [Theory]
        [InlineData("12 5 15.00\n13 7 10.00\n", "145.00")] //Cada \n é lido como "Enter"
        [InlineData("5 12 43.70\n2 3 2.99\n", "533.37")]
        [InlineData("9 1 34.59\n8 2 112.99\n", "260.57")]
        [InlineData("6 100 0.98\n7 4 7.50\n", "128.00")]
        public void Exercicio1_1_QuandoSelecionarOpcao1_DeveRetornarValorCorreto(string entradaDeDados, string valorEsperado)
        {
            // Arrange
            var retornoEsperado = $"VALOR A PAGAR: R$ {valorEsperado}";
            var entradaCompleta = $"{CodigoDoExercicio1_1}{entradaDeDados}";

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
            var entradaCompleta = $"{CodigoDoExercicio1_1}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);

            //Assert
            Assert.Contains(retornoEsperado, retornoNaTela);
        }

        #endregion;

        #region Program1_2;
        const string CodigoDoExercicio1_2 = "2\n";

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
            var entradaCompleta = $"{CodigoDoExercicio1_2}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);

            //Assert
            Assert.Contains(retornoEsperado, retornoNaTela);
        }

        [Fact]
        public void Program1_2_QuandoRaioNaoTiverPreenchido_DeveRetornarZero()
        {
            //Arrange
            const string Entrada = $"{CodigoDoExercicio1_2}00.00";
            const string RetornoEsperado = $"A=0.0000";

            //Act
            var retornoNaTela = ExecutarPrograma(Entrada, Program.Main);

            //Assert
            Assert.Contains(RetornoEsperado, retornoNaTela);
        }

        #endregion;
    }
}