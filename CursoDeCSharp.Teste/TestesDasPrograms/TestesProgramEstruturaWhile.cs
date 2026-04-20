namespace CursoDeCSharp.Teste.TestesProvaDeLogica
{
    public class TestesProgramEstruturaWhile : HelperDosTestes
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

        #region ExercicioEstruturaWhile01 - Quadrantes;

        const string CodigoDoExercicio01 = "26\n";  // Exercício na posição 26 (Ordem 27)

        [Theory]
        [InlineData("1 1\n0 0\n", "primeiro")]
        [InlineData("2 3\n0 0\n", "primeiro")]
        [InlineData("-1 1\n0 0\n", "segundo")]
        [InlineData("-2 3\n0 0\n", "segundo")]
        [InlineData("-1 -1\n0 0\n", "terceiro")]
        [InlineData("-2 -3\n0 0\n", "terceiro")]
        [InlineData("1 -1\n0 0\n", "quarto")]
        [InlineData("2 -3\n0 0\n", "quarto")]
        public void ExercicioEstruturaWhile01_QuandoUmPontoEhInformado_DeveRetornarQuadranteCorrecto(
            string entradaDeDados, string quadranteEsperado)
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio01}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);
            var saidaDoExercicio = RemoverMenuDaSaida(retornoNaTela);

            //Assert
            Assert.Contains(quadranteEsperado, saidaDoExercicio);
        }

        [Theory]
        [InlineData("1 1\n-1 -1\n0 0\n", new[] { "primeiro", "terceiro" })]
        [InlineData("2 2\n-2 2\n-2 -2\n2 -2\n0 0\n", new[] { "primeiro", "segundo", "terceiro", "quarto" })]
        [InlineData("5 5\n-3 4\n-1 -2\n3 -1\n0 0\n", new[] { "primeiro", "segundo", "terceiro", "quarto" })]
        public void ExercicioEstruturaWhile01_QuandoMultiplosPontosEhInformados_DeveRetornarTodosOsQuadrantes(
            string entradaDeDados, string[] quadrantesEsperados)
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio01}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);
            var saidaDoExercicio = RemoverMenuDaSaida(retornoNaTela);

            //Assert
            foreach (var quadrante in quadrantesEsperados)
            {
                Assert.Contains(quadrante, saidaDoExercicio);
            }
        }

        [Theory]
        [InlineData("0 5\n", "")]         // X = 0 (encerra imediatamente)
        [InlineData("5 0\n", "")]         // Y = 0 (encerra imediatamente)
        [InlineData("0 0\n", "")]         // Ambos 0 (encerra imediatamente)
        public void ExercicioEstruturaWhile01_QuandoUmaCoordEhZero_DevencerraImediatamente(
            string entradaDeDados, string resultadoEsperado)
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio01}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);
            var saidaDoExercicio = RemoverMenuDaSaida(retornoNaTela);

            //Assert
            Assert.DoesNotContain("primeiro", saidaDoExercicio);
            Assert.DoesNotContain("segundo", saidaDoExercicio);
            Assert.DoesNotContain("terceiro", saidaDoExercicio);
            Assert.DoesNotContain("quarto", saidaDoExercicio);
        }

        [Theory]
        [InlineData("1 2\n3 4\n5 6\n0 1\n", new[] { "primeiro", "primeiro", "primeiro" })]
        [InlineData("-1 1\n-2 3\n1 1\n0 0\n", new[] { "segundo", "segundo", "primeiro" })]
        public void ExercicioEstruturaWhile01_QuandoMultiplosPontosNosMesmosQuadrantes_DeveRetornarTodos(
            string entradaDeDados, string[] quadrantesEsperados)
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio01}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);
            var saidaDoExercicio = RemoverMenuDaSaida(retornoNaTela);

            //Assert
            foreach (var quadrante in quadrantesEsperados)
            {
                Assert.Contains(quadrante, saidaDoExercicio);
            }
        }

        #endregion;

        #region ExercicioEstruturaWhile02 - Combustível;

        const string CodigoDoExercicio02 = "27\n";  // Exercício na posição 27 (Ordem 28)

        [Theory]
        [InlineData("1\n4\n", "Alcool: 1")]
        [InlineData("2\n4\n", "Gasolina: 1")]
        [InlineData("3\n4\n", "Diesel: 1")]
        public void ExercicioEstruturaWhile02_QuandoUmTipoDeCombustivelEhInformado_DeveContar(
            string entradaDeDados, string resultadoEsperado)
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio02}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);
            var saidaDoExercicio = RemoverMenuDaSaida(retornoNaTela);

            //Assert
            Assert.Contains(resultadoEsperado, saidaDoExercicio);
            Assert.Contains("MUITO OBRIGADO", saidaDoExercicio);
        }

        [Theory]
        [InlineData("1\n1\n1\n4\n", new[] { "Alcool: 3", "Gasolina: 0", "Diesel: 0" })]
        [InlineData("2\n2\n2\n4\n", new[] { "Alcool: 0", "Gasolina: 3", "Diesel: 0" })]
        [InlineData("3\n3\n4\n", new[] { "Alcool: 0", "Gasolina: 0", "Diesel: 2" })]
        public void ExercicioEstruturaWhile02_QuandoMultiplosDeMesmoTipo_DeveContarCorretamente(
            string entradaDeDados, string[] resultadosEsperados)
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio02}{entradaDeDados}";

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
        [InlineData("1\n2\n3\n1\n2\n3\n4\n", new[] { "Alcool: 2", "Gasolina: 2", "Diesel: 2" })]
        [InlineData("1\n1\n2\n2\n3\n3\n1\n4\n", new[] { "Alcool: 3", "Gasolina: 2", "Diesel: 2" })]
        [InlineData("2\n1\n3\n2\n1\n4\n", new[] { "Alcool: 2", "Gasolina: 2", "Diesel: 1" })]
        public void ExercicioEstruturaWhile02_QuandoMultiplosTiposDeCombustivelSaoAbastecidos_DeveContarTodos(
            string entradaDeDados, string[] resultadosEsperados)
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio02}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);
            var saidaDoExercicio = RemoverMenuDaSaida(retornoNaTela);

            //Assert
            foreach (var resultado in resultadosEsperados)
            {
                Assert.Contains(resultado, saidaDoExercicio);
            }
        }

        [Fact]
        public void ExercicioEstruturaWhile02_QuandoCodigoQuatroEhInformadoImediatamente_DeveMostrarMensagemFinal()
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio02}4\n";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);
            var saidaDoExercicio = RemoverMenuDaSaida(retornoNaTela);

            //Assert
            Assert.Contains("MUITO OBRIGADO", saidaDoExercicio);
            Assert.Contains("Alcool: 0", saidaDoExercicio);
            Assert.Contains("Gasolina: 0", saidaDoExercicio);
            Assert.Contains("Diesel: 0", saidaDoExercicio);
        }

        [Theory]
        [InlineData("1\n1\n1\n1\n1\n4\n", "Alcool: 5")]
        [InlineData("2\n2\n2\n2\n2\n2\n4\n", "Gasolina: 6")]
        [InlineData("3\n3\n3\n4\n", "Diesel: 3")]
        public void ExercicioEstruturaWhile02_QuandoMuitosAbastecimentosDeMesmoTipo_DeveContarTodos(
            string entradaDeDados, string resultadoEsperado)
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio02}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);
            var saidaDoExercicio = RemoverMenuDaSaida(retornoNaTela);

            //Assert
            Assert.Contains(resultadoEsperado, saidaDoExercicio);
        }

        [Fact]
        public void ExercicioEstruturaWhile02_DeveMostrarMensagemMuitoObrigado()
        {
            //Arrange
            var entradaCompleta = $"{CodigoDoExercicio02}1\n4\n";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);
            var saidaDoExercicio = RemoverMenuDaSaida(retornoNaTela);

            //Assert
            Assert.Contains("MUITO OBRIGADO", saidaDoExercicio);
        }

        #endregion;
    }
}
