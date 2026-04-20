namespace CursoDeCSharp.Teste.TestesProvaDeLogica
{
    /// <summary>
    /// Testes unitários para helpers dos exercícios de estrutura While.
    /// Embora os exercícios não tenham helpers específicos, esta classe testa
    /// a lógica que poderia ser encapsulada em métodos auxiliares.
    /// </summary>
    public class TesteHelperEstruturaWhile
    {
        #region Determinador de Quadrante;

        /// <summary>
        /// Método auxiliar que simula a lógica de determinação de quadrante.
        /// </summary>
        private static string DeterminarQuadrante(int x, int y)
        {
            if (y > 0 && x > 0)
                return "primeiro";
            else if (y > 0 && x < 0)
                return "segundo";
            else if (y < 0 && x < 0)
                return "terceiro";
            else if (y < 0 && x > 0)
                return "quarto";
            
            return "";
        }

        /// <summary>
        /// Verifica se as coordenadas representam um ponto válido (não nulo).
        /// </summary>
        private static bool EhPontoValido(int x, int y)
        {
            return x != 0 && y != 0;
        }

        [Theory]
        [InlineData(1, 1, "primeiro")]
        [InlineData(2, 5, "primeiro")]
        [InlineData(10, 10, "primeiro")]
        public void DeterminarQuadrante_QuandoPontoEstaNoQuadranteUm_DeveRetornarPrimeiro(
            int x, int y, string quadranteEsperado)
        {
            //Act
            var resultado = DeterminarQuadrante(x, y);

            //Assert
            Assert.Equal(quadranteEsperado, resultado);
        }

        [Theory]
        [InlineData(-1, 1, "segundo")]
        [InlineData(-2, 5, "segundo")]
        [InlineData(-10, 10, "segundo")]
        public void DeterminarQuadrante_QuandoPontoEstaNoQuadranteDois_DeveRetornarSegundo(
            int x, int y, string quadranteEsperado)
        {
            //Act
            var resultado = DeterminarQuadrante(x, y);

            //Assert
            Assert.Equal(quadranteEsperado, resultado);
        }

        [Theory]
        [InlineData(-1, -1, "terceiro")]
        [InlineData(-2, -5, "terceiro")]
        [InlineData(-10, -10, "terceiro")]
        public void DeterminarQuadrante_QuandoPontoEstaNoQuadranteTres_DeveRetornarTerceiro(
            int x, int y, string quadranteEsperado)
        {
            //Act
            var resultado = DeterminarQuadrante(x, y);

            //Assert
            Assert.Equal(quadranteEsperado, resultado);
        }

        [Theory]
        [InlineData(1, -1, "quarto")]
        [InlineData(2, -5, "quarto")]
        [InlineData(10, -10, "quarto")]
        public void DeterminarQuadrante_QuandoPontoEstaNoQuadranteQuatro_DeveRetornarQuarto(
            int x, int y, string quadranteEsperado)
        {
            //Act
            var resultado = DeterminarQuadrante(x, y);

            //Assert
            Assert.Equal(quadranteEsperado, resultado);
        }

        [Theory]
        [InlineData(0, 1, "")]           // X nulo
        [InlineData(1, 0, "")]           // Y nulo
        [InlineData(0, 0, "")]           // Ambos nulos
        [InlineData(0, -5, "")]          // X nulo com Y negativo
        [InlineData(-5, 0, "")]          // X negativo com Y nulo
        public void DeterminarQuadrante_QuandoCoordenadaNula_DeveRetornarVazio(
            int x, int y, string resultadoEsperado)
        {
            //Act
            var resultado = DeterminarQuadrante(x, y);

            //Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        #endregion;

        #region Validador de Ponto;

        [Theory]
        [InlineData(1, 1, true)]
        [InlineData(-1, 1, true)]
        [InlineData(-1, -1, true)]
        [InlineData(1, -1, true)]
        [InlineData(5, 10, true)]
        [InlineData(-100, -200, true)]
        public void EhPontoValido_QuandoAmbascoordenadasonaoSaoNulas_DeveRetornarVerdadeiro(
            int x, int y, bool resultadoEsperado)
        {
            //Act
            var resultado = EhPontoValido(x, y);

            //Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(0, 1, false)]
        [InlineData(1, 0, false)]
        [InlineData(0, 0, false)]
        [InlineData(0, -5, false)]
        [InlineData(-5, 0, false)]
        public void EhPontoValido_QuandoUmaOuAmbasCoordenadasSaoNulas_DeveRetornarFalso(
            int x, int y, bool resultadoEsperado)
        {
            //Act
            var resultado = EhPontoValido(x, y);

            //Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        #endregion;

        #region Contador de Combustível;

        /// <summary>
        /// Método auxiliar que simula a contagem de combustível.
        /// </summary>
        private class ContadorCombustivel
        {
            public int Alcool { get; set; }
            public int Gasolina { get; set; }
            public int Diesel { get; set; }

            public void Contar(int tipo)
            {
                if (tipo == 1)
                    Alcool++;
                else if (tipo == 2)
                    Gasolina++;
                else if (tipo == 3)
                    Diesel++;
            }
        }

        [Theory]
        [InlineData(1, 1, 0, 0)]
        [InlineData(2, 0, 1, 0)]
        [InlineData(3, 0, 0, 1)]
        public void Contar_QuandoUmTipoDeCombustivelEhInformado_DeveIncrementarContador(
            int tipo, int alcoolEsperado, int gasolinaEsperada, int dieselEsperado)
        {
            //Arrange
            var contador = new ContadorCombustivel();

            //Act
            contador.Contar(tipo);

            //Assert
            Assert.Equal(alcoolEsperado, contador.Alcool);
            Assert.Equal(gasolinaEsperada, contador.Gasolina);
            Assert.Equal(dieselEsperado, contador.Diesel);
        }

        [Fact]
        public void Contar_QuandoMultiplosTiposSaoInformados_DeveContarTodos()
        {
            //Arrange
            var contador = new ContadorCombustivel();

            //Act
            contador.Contar(1);
            contador.Contar(1);
            contador.Contar(2);
            contador.Contar(3);
            contador.Contar(3);
            contador.Contar(3);

            //Assert
            Assert.Equal(2, contador.Alcool);
            Assert.Equal(1, contador.Gasolina);
            Assert.Equal(3, contador.Diesel);
        }

        [Theory]
        [InlineData(1, 5, 5, 0, 0)]
        [InlineData(2, 3, 0, 3, 0)]
        [InlineData(3, 7, 0, 0, 7)]
        public void Contar_QuandoMultiplosDomesmoTipoSaoInformados_DeveContarCorretamente(
            int tipo, int repeticoes, int alcoolEsperado, int gasolinaEsperada, int dieselEsperado)
        {
            //Arrange
            var contador = new ContadorCombustivel();

            //Act
            for (int i = 0; i < repeticoes; i++)
            {
                contador.Contar(tipo);
            }

            //Assert
            Assert.Equal(alcoolEsperado, contador.Alcool);
            Assert.Equal(gasolinaEsperada, contador.Gasolina);
            Assert.Equal(dieselEsperado, contador.Diesel);
        }

        [Fact]
        public void Contar_TiposInvalidos_NaoDevemIncrementarContadores()
        {
            //Arrange
            var contador = new ContadorCombustivel();

            //Act
            contador.Contar(4);  // Código de saída
            contador.Contar(0);  // Inválido
            contador.Contar(5);  // Inválido
            contador.Contar(99); // Inválido

            //Assert
            Assert.Equal(0, contador.Alcool);
            Assert.Equal(0, contador.Gasolina);
            Assert.Equal(0, contador.Diesel);
        }

        #endregion;
    }
}
