namespace CursoDeCSharp.Teste.TestesDasPrograms
{
    public class TestesProgramExerciciosSecao04 : HelperDosTestes
    {
        #region Secao0401 - Pessoa Mais Velha;

        const string CodigoDoExercicio0401 = "7\n";

        [Theory]
        [InlineData("João\n30\nMaria\n25\n", "Pessoa mais velha: João")]
        [InlineData("João\n25\nMaria\n30\n", "Pessoa mais velha: Maria")]
        [InlineData("Pedro\n40\nAna\n35\n", "Pessoa mais velha: Pedro")]
        public void Secao0401_QuandoDadosDePessoasEstiveremPreenchidos_DeveRetornarPessoaMaisVelha(
            string entradaDeDados, string resultadoEsperado)
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio0401}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);

            //Assert
            Assert.Contains(resultadoEsperado, retornoNaTela);
        }

        [Theory]
        [InlineData("João\n25\nMaria\n25\n", "Ambas têm a mesma idade")]
        [InlineData("Pedro\n30\nAna\n30\n", "Ambas têm a mesma idade")]
        public void Secao0401_QuandoPessoasTemMesmaIdade_DeveRetornarMensagemDeIgualdade(
            string entradaDeDados, string resultadoEsperado)
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio0401}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);

            //Assert
            Assert.Contains(resultadoEsperado, retornoNaTela);
        }

        #endregion;

        #region Secao0402 - Salário Médio;

        const string CodigoDoExercicio0402 = "8\n";

        [Theory]
        [InlineData("João\n1000.00\nMaria\n2000.00\n", "1500.00")]
        [InlineData("Pedro\n5000.00\nAna\n3000.00\n", "4000.00")]
        [InlineData("Carlos\n2500.00\nJulia\n2500.00\n", "2500.00")]
        [InlineData("Roberto\n10000.00\nFernanda\n8000.00\n", "9000.00")]
        public void Secao0402_QuandoDadosDeFuncionariosEstiveremPreenchidos_DeveRetornarSalarioMedio(
            string entradaDeDados, string mediaSalarialEsperada)
        {
            //Arrange
            var retornoEsperado = $"Salário médio = {mediaSalarialEsperada}";
            var entradaCompleta = $"{CodigoDoExercicio0402}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);

            //Assert
            Assert.Contains(retornoEsperado, retornoNaTela);
        }

        [Theory]
        [InlineData("João\n0.00\nMaria\n1000.00\n", "500.00")]
        [InlineData("Pedro\n2000.00\nAna\n0.00\n", "1000.00")]
        [InlineData("Carlos\n0.00\nJulia\n0.00\n", "0.00")]
        public void Secao0402_QuandoUmOuAmbosSalariosForemZero_DeveCalcularMediaCorretamente(
            string entradaDeDados, string mediaSalarialEsperada)
        {
            //Arrange
            var retornoEsperado = $"Salário médio = {mediaSalarialEsperada}";
            var entradaCompleta = $"{CodigoDoExercicio0402}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);

            //Assert
            Assert.Contains(retornoEsperado, retornoNaTela);
        }

        #endregion;

        #region Secao0403 - Retângulo;

        const string CodigoDoExercicio0403 = "9\n";

        [Theory]
        [InlineData("5.0\n4.0\n", new[] { "AREA = 20.00", "PERIMETRO = 18.00", "DIAGONAL = 6.40" })]
        [InlineData("10.0\n10.0\n", new[] { "AREA = 100.00", "PERIMETRO = 40.00", "DIAGONAL = 14.14" })]
        [InlineData("3.0\n4.0\n", new[] { "AREA = 12.00", "PERIMETRO = 14.00", "DIAGONAL = 5.00" })]
        [InlineData("6.0\n8.0\n", new[] { "AREA = 48.00", "PERIMETRO = 28.00", "DIAGONAL = 10.00" })]
        public void Secao0403_QuandoDimensoesDoRetanguloEstiveremPreenchidas_DeveRetornarAreaPerimetroEDiagonal(
            string entradaDeDados, string[] resultadosEsperados)
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio0403}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);

            //Assert
            foreach (var resultado in resultadosEsperados)
            {
                Assert.Contains(resultado, retornoNaTela);
            }
        }

        [Theory]
        [InlineData("0.0\n5.0\n", new[] { "AREA = 0.00", "PERIMETRO = 10.00" })]
        [InlineData("5.0\n0.0\n", new[] { "AREA = 0.00", "PERIMETRO = 10.00" })]
        public void Secao0403_QuandoUmaDimensaoForZero_DeveRetornarAreaZeroMasPerimetroComOValor(
            string entradaDeDados, string[] resultadosEsperados)
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio0403}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);

            //Assert
            foreach (var resultado in resultadosEsperados)
            {
                Assert.Contains(resultado, retornoNaTela);
            }
        }

        #endregion;

        #region Secao0404 - Funcionário;

        const string CodigoDoExercicio0404 = "10\n";

        [Theory]
        [InlineData("João\n2000.00\n300.00\n10\n", new[] { "João, $ 1700", "João, $ 1900" })]
        [InlineData("Maria\n3000.00\n500.00\n20\n", new[] { "Maria, $ 2500", "Maria, $ 3100" })]
        [InlineData("Pedro\n5000.00\n1000.00\n5\n", new[] { "Pedro, $ 4000", "Pedro, $ 4250" })]
        public void Secao0404_QuandoDadosFuncionarioEAumentoEstiveremPreenchidos_DeveExibirSalarioLiquidoAnteriorEPosterior(
            string entradaDeDados, string[] resultadosEsperados)
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio0404}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);

            //Assert
            foreach (var resultado in resultadosEsperados)
            {
                Assert.Contains(resultado, retornoNaTela);
            }
        }

        [Theory]
        [InlineData("Ana\n1000.00\n200.00\n0\n", "Ana, $ 800")] // Sem aumento
        [InlineData("Carlos\n2000.00\n400.00\n0\n", "Carlos, $ 1600")] // Sem aumento
        public void Secao0404_QuandoAumentoForZero_DeveManterSalarioLiquidoIgual(
            string entradaDeDados, string resultadoEsperado)
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio0404}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);

            //Assert
            // Deve aparecer duas vezes com o mesmo valor (antes e depois)
            Assert.Contains($"Funcionário: {resultadoEsperado}", retornoNaTela);
        }

        #endregion;

        #region Secao0405 - Aluno;

        const string CodigoDoExercicio0405 = "11\n";

        [Theory]
        [InlineData("João\n80\n75\n90\n", new[] { "NOTA FINAL = 81.75", "APROVADO" })]
        [InlineData("Maria\n70\n70\n70\n", new[] { "NOTA FINAL = 70.00", "APROVADO" })]
        [InlineData("Pedro\n90\n85\n95\n", new[] { "NOTA FINAL = 90.00", "APROVADO" })]
        [InlineData("Ana\n60\n60\n60\n", new[] { "NOTA FINAL = 60.00", "APROVADO" })]
        public void Secao0405_QuandoNotasForemSuficientes_DeveRetornarAprovado(
            string entradaDeDados, string[] resultadosEsperados)
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio0405}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);

            //Assert
            foreach (var resultado in resultadosEsperados)
            {
                Assert.Contains(resultado, retornoNaTela);
            }
        }

        [Theory]
        [InlineData("Carlos\n40\n50\n55\n", new[] { "NOTA FINAL = 48.75", "REPROVADO", "FALTA = 11.25" })]
        [InlineData("Beatriz\n30\n40\n50\n", new[] { "NOTA FINAL = 40.50", "REPROVADO", "FALTA = 19.50" })]
        [InlineData("Lucas\n0\n0\n0\n", new[] { "NOTA FINAL = 0.00", "REPROVADO", "FALTA = 60.00" })]
        public void Secao0405_QuandoNotasForemInsuficientes_DeveRetornarReprovadoComFalta(
            string entradaDeDados, string[] resultadosEsperados)
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio0405}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);

            //Assert
            foreach (var resultado in resultadosEsperados)
            {
                Assert.Contains(resultado, retornoNaTela);
            }
        }

        [Theory]
        [InlineData("Roberto\n50\n60\n60\n", new[] { "NOTA FINAL = 57.00", "REPROVADO", "FALTA = 3.00" })]
        [InlineData("Fernanda\n59.9\n60\n60\n", new[] { "REPROVADO" })]
        public void Secao0405_QuandoNotaForeMuitoPertoDolimiteDessesenta_DeveRetornarReprovado(
            string entradaDeDados, string[] resultadosEsperados)
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio0405}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);

            //Assert
            Assert.Contains(resultadosEsperados[0], retornoNaTela);
        }

        #endregion;

        #region Secao0406 - Conversor de Moeda;

        const string CodigoDoExercicio0406 = "12\n";

        [Theory]
        [InlineData("4.50\n100.0\n", "477.00")]      // 100 dólares a R$ 4.50 com IOF de 6%: 450 * 1.06 = 477
        [InlineData("5.00\n200.0\n", "1060.00")]     // 200 dólares a R$ 5.00 com IOF de 6%: 1000 * 1.06 = 1060
        [InlineData("3.80\n50.0\n", "201.40")]       // 50 dólares a R$ 3.80 com IOF de 6%: 190 * 1.06 = 201.40
        [InlineData("4.20\n1000.0\n", "4452.00")]    // 1000 dólares a R$ 4.20 com IOF de 6%: 4200 * 1.06 = 4452
        public void Secao0406_QuandoCotacaoEQuantidadeEstiveremPreenchidas_DeveRetornarValorComIOF(
            string entradaDeDados, string valorEsperado)
        {
            //Arrange
            var retornoEsperado = $"Valor a ser pago em reais = {valorEsperado}";
            var entradaCompleta = $"{CodigoDoExercicio0406}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);

            //Assert
            Assert.Contains(retornoEsperado, retornoNaTela);
        }

        [Theory]
        [InlineData("4.50\n0.0\n", "0.00")]      // Sem compra
        [InlineData("5.00\n0.0\n", "0.00")]      // Zero dólares
        public void Secao0406_QuandoQuantidadeDeCompraForZero_DeveRetornarZero(
            string entradaDeDados, string valorEsperado)
        {
            //Arrange
            var retornoEsperado = $"Valor a ser pago em reais = {valorEsperado}";
            var entradaCompleta = $"{CodigoDoExercicio0406}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);

            //Assert
            Assert.Contains(retornoEsperado, retornoNaTela);
        }

        #endregion;
    }
}
