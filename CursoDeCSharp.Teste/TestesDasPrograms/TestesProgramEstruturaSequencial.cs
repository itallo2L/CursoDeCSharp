namespace CursoDeCSharp.Teste.TestesProvaDeLogica
{
    public class TestesProgramEstruturaSequencial : HelperDosTestes
    {
        /// <summary>
        /// Remove o menu inicial da saída do programa e retorna apenas a saída do exercício.
        /// </summary>
        private string RemoverMenuDaSaida(string saida)
        {
            // O menu termina com "=== DIGITE O CÓDIGO DO EXERCÍCIO ESPERADO ===" 
            // A saída do exercício vem depois disso
            var partes = saida.Split(new[] { "=== DIGITE O CÓDIGO DO EXERCÍCIO ESPERADO ===" }, StringSplitOptions.None);
            
            if (partes.Length > 1)
                return partes[partes.Length - 1].Trim();
            
            return saida;
        }

        #region ExercicioSequencial01 - Soma;

        const string CodigoDoExercicio01 = "28\n";  // Exercício na posição 28 (Ordem 29)

        [Theory]
        [InlineData("5\n3\n", "SOMA = 8")]
        [InlineData("10\n20\n", "SOMA = 30")]
        [InlineData("0\n0\n", "SOMA = 0")]
        [InlineData("-5\n5\n", "SOMA = 0")]
        [InlineData("100\n50\n", "SOMA = 150")]
        public void ExercicioSequencial01_QuandoDoisInteirossSaoInformados_DeveRetornaraSoma(
            string entradaDeDados, string somaEsperada)
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio01}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);
            var saidaDoExercicio = RemoverMenuDaSaida(retornoNaTela);

            //Assert
            Assert.Contains(somaEsperada, saidaDoExercicio);
        }

        [Theory]
        [InlineData("-10\n-20\n", "SOMA = -30")]
        [InlineData("-100\n50\n", "SOMA = -50")]
        [InlineData("999\n1\n", "SOMA = 1000")]
        public void ExercicioSequencial01_QuandoValoresNegativosOuGrandes_DeveCalcularCorretamente(
            string entradaDeDados, string somaEsperada)
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio01}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);
            var saidaDoExercicio = RemoverMenuDaSaida(retornoNaTela);

            //Assert
            Assert.Contains(somaEsperada, saidaDoExercicio);
        }

        #endregion;

        #region ExercicioSequencial02 - Diferença;

        const string CodigoDoExercicio02 = "29\n";  // Exercício na posição 29 (Ordem 30)

        [Theory]
        [InlineData("5\n2\n3\n2\n", "DIFERENCA = 4")]     // (5*2) - (3*2) = 10 - 6 = 4
        [InlineData("10\n3\n4\n5\n", "DIFERENCA = 10")]    // (10*3) - (4*5) = 30 - 20 = 10
        [InlineData("2\n2\n2\n2\n", "DIFERENCA = 0")]      // (2*2) - (2*2) = 4 - 4 = 0
        [InlineData("1\n1\n1\n1\n", "DIFERENCA = 0")]      // (1*1) - (1*1) = 1 - 1 = 0
        public void ExercicioSequencial02_QuandoQuatroInteirosInformados_DeveCalcularDiferenca(
            string entradaDeDados, string diferencaEsperada)
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio02}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);
            var saidaDoExercicio = RemoverMenuDaSaida(retornoNaTela);

            //Assert
            Assert.Contains(diferencaEsperada, saidaDoExercicio);
        }

        [Theory]
        [InlineData("100\n2\n10\n5\n", "DIFERENCA = 150")]  // (100*2) - (10*5) = 200 - 50 = 150
        [InlineData("5\n10\n20\n20\n", "DIFERENCA = -350")] // (5*10) - (20*20) = 50 - 400 = -350
        [InlineData("0\n5\n3\n2\n", "DIFERENCA = -6")]      // (0*5) - (3*2) = 0 - 6 = -6
        public void ExercicioSequencial02_ComValoresVariados_DeveCalcularCorretamente(
            string entradaDeDados, string diferencaEsperada)
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio02}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);
            var saidaDoExercicio = RemoverMenuDaSaida(retornoNaTela);

            //Assert
            Assert.Contains(diferencaEsperada, saidaDoExercicio);
        }

        #endregion;

        #region ExercicioSequencial03 - Salário;

        const string CodigoDoExercicio03 = "30\n";  // Exercício na posição 30 (Ordem 31)

        [Theory]
        [InlineData("1\n10\n5.50\n", new[] { "NUMBER = 1", "SALARY = U$ 55.00" })]
        [InlineData("25\n8\n15.50\n", new[] { "NUMBER = 25", "SALARY = U$ 124.00" })]
        [InlineData("100\n40\n10.00\n", new[] { "NUMBER = 100", "SALARY = U$ 400.00" })]
        public void ExercicioSequencial03_QuandoDadosDeFuncionarioInformados_DeveCalcularSalario(
            string entradaDeDados, string[] resultadosEsperados)
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio03}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);
            var saidaDoExercicio = RemoverMenuDaSaida(retornoNaTela);

            //Assert
            foreach (var resultado in resultadosEsperados)
            {
                Assert.Contains(resultado, saidaDoExercicio);
            }
        }

        [Theory]
        [InlineData("50\n0\n10.00\n", new[] { "NUMBER = 50", "SALARY = U$ 0.00" })]
        [InlineData("999\n1\n0.50\n", new[] { "NUMBER = 999", "SALARY = U$ 0.50" })]
        [InlineData("5\n20\n25.75\n", new[] { "NUMBER = 5", "SALARY = U$ 515.00" })]
        public void ExercicioSequencial03_ComValoresEspeciais_DeveFormatarCorretamente(
            string entradaDeDados, string[] resultadosEsperados)
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio03}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);
            var saidaDoExercicio = RemoverMenuDaSaida(retornoNaTela);

            //Assert
            foreach (var resultado in resultadosEsperados)
            {
                Assert.Contains(resultado, saidaDoExercicio);
            }
        }

        #endregion;

        #region ExercicioSequencial04 - Áreas Geométricas;

        const string CodigoDoExercicio04 = "31\n";  // Exercício na posição 31 (Ordem 32)

        [Theory]
        [InlineData("3.0 4.0 5.0\n", new[] { "TRIANGULO: 7.500", "CIRCULO: 78.540", "TRAPEZIO: 17.500", "QUADRADO: 16.000", "RETANGULO: 12.000" })]
        [InlineData("2.0 2.0 2.0\n", new[] { "TRIANGULO: 2.000", "CIRCULO: 12.566", "TRAPEZIO: 4.000", "QUADRADO: 4.000", "RETANGULO: 4.000" })]
        public void ExercicioSequencial04_QuandoTresValoresInformados_DeveCalcularTodasAsAreas(
            string entradaDeDados, string[] areasEsperadas)
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio04}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);
            var saidaDoExercicio = RemoverMenuDaSaida(retornoNaTela);

            //Assert
            foreach (var area in areasEsperadas)
            {
                Assert.Contains(area, saidaDoExercicio);
            }
        }

        [Theory]
        [InlineData("5.0 6.0 10.0\n", new[] { "TRIANGULO: 25.000", "CIRCULO: 314.159", "TRAPEZIO: 55.000", "QUADRADO: 36.000", "RETANGULO: 30.000" })]
        public void ExercicioSequencial04_ComValoresElevados_DeveCalcularCorretamente(
            string entradaDeDados, string[] areasEsperadas)
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio04}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);
            var saidaDoExercicio = RemoverMenuDaSaida(retornoNaTela);

            //Assert
            foreach (var area in areasEsperadas)
            {
                Assert.Contains(area, saidaDoExercicio);
            }
        }

        [Fact]
        public void ExercicioSequencial04_DeveConter5Linhas()
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio04}1.0 1.0 1.0\n";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);
            var saidaDoExercicio = RemoverMenuDaSaida(retornoNaTela).Trim();
            // Conta apenas as linhas que começam com nomes de áreas (ignora cabeçalho e outras linhas)
            var formasGeometricas = new[] { "TRIANGULO:", "CIRCULO:", "TRAPEZIO:", "QUADRADO:", "RETANGULO:" };
            var linhasDeAreas = saidaDoExercicio.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries)
                .Where(l => formasGeometricas.Any(f => l.TrimStart().StartsWith(f))).ToArray();

            //Assert
            Assert.Equal(5, linhasDeAreas.Length);
            Assert.Contains("TRIANGULO", saidaDoExercicio);
            Assert.Contains("CIRCULO", saidaDoExercicio);
            Assert.Contains("TRAPEZIO", saidaDoExercicio);
            Assert.Contains("QUADRADO", saidaDoExercicio);
            Assert.Contains("RETANGULO", saidaDoExercicio);
        }

        #endregion;
    }
}
