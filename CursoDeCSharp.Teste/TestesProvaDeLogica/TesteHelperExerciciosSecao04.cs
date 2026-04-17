using CursoDeCSharp.Exercicios.Helpers;

namespace CursoDeCSharp.Teste.TestesProvaDeLogica
{
    public class TesteHelperExerciciosSecao04
    {
        #region ObterNomeDaPessoaMaisVelha;

        [Theory]
        [InlineData("João", 30, "Maria", 25, "Pessoa mais velha: João")]
        [InlineData("João", 25, "Maria", 30, "Pessoa mais velha: Maria")]
        [InlineData("Pedro", 40, "Ana", 35, "Pessoa mais velha: Pedro")]
        [InlineData("Carlos", 50, "Julia", 45, "Pessoa mais velha: Carlos")]
        public void ObterNomeDaPessoaMaisVelha_QuandoPessoasTemIdadesdiferentes_DeveRetornarPessoaMaisVelha(
            string nomePessoa1, int idadePessoa1, string nomePessoa2, int idadePessoa2, string resultadoEsperado)
        {
            //Arrange
            var pessoa1 = new Pessoa { Nome = nomePessoa1, Idade = idadePessoa1 };
            var pessoa2 = new Pessoa { Nome = nomePessoa2, Idade = idadePessoa2 };

            //Act
            var resultado = HelperExerciciosSecao04.ObterNomeDaPessoaMaisVelha(pessoa1, pessoa2);

            //Assert
            Assert.IsType<string>(resultado);
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData("João", 25, "Maria", 25, "Ambas têm a mesma idade")]
        [InlineData("Pedro", 30, "Ana", 30, "Ambas têm a mesma idade")]
        [InlineData("Carlos", 50, "Julia", 50, "Ambas têm a mesma idade")]
        public void ObterNomeDaPessoaMaisVelha_QuandoPessoasTemMesmaIdade_DeveRetornarMensagemDeIgualdade(
            string nomePessoa1, int idadePessoa1, string nomePessoa2, int idadePessoa2, string resultadoEsperado)
        {
            //Arrange
            var pessoa1 = new Pessoa { Nome = nomePessoa1, Idade = idadePessoa1 };
            var pessoa2 = new Pessoa { Nome = nomePessoa2, Idade = idadePessoa2 };

            //Act
            var resultado = HelperExerciciosSecao04.ObterNomeDaPessoaMaisVelha(pessoa1, pessoa2);

            //Assert
            Assert.IsType<string>(resultado);
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void ObterNomeDaPessoaMaisVelha_ComIdadesExtremosZero_DeveRetornarPessoaMaisVelha()
        {
            //Arrange
            var pessoa1 = new Pessoa { Nome = "Recém Nascido", Idade = 0 };
            var pessoa2 = new Pessoa { Nome = "Idoso", Idade = 100 };

            //Act
            var resultado = HelperExerciciosSecao04.ObterNomeDaPessoaMaisVelha(pessoa1, pessoa2);

            //Assert
            Assert.Equal("Pessoa mais velha: Idoso", resultado);
        }

        #endregion;

        #region FuncionarioCompleto_SalarioLiquido;

        [Theory]
        [InlineData(1000.00, 200.00, 800.00)]
        [InlineData(5000.00, 1000.00, 4000.00)]
        [InlineData(3500.00, 700.00, 2800.00)]
        [InlineData(2000.00, 300.00, 1700.00)]
        public void SalarioLiquido_QuandoSalarioBrutoEImpostoEstiveremPreenchidos_DeveRetornarValorCorreto(
            double salarioBruto, double imposto, double salarioLiquidoEsperado)
        {
            //Arrange
            var funcionario = new FuncionarioCompleto 
            { 
                Nome = "João", 
                SalarioBruto = salarioBruto, 
                Imposto = imposto 
            };

            //Act
            var salarioLiquido = funcionario.SalarioLiquido();

            //Assert
            Assert.IsType<double>(salarioLiquido);
            Assert.Equal(salarioLiquidoEsperado, salarioLiquido);
        }

        [Theory]
        [InlineData(1000.00, 0.00, 1000.00)]
        [InlineData(5000.00, 0.00, 5000.00)]
        [InlineData(0.00, 100.00, -100.00)]
        public void SalarioLiquido_QuandoImpostoForZero_DeveRetornarSalarioBruto(
            double salarioBruto, double imposto, double salarioLiquidoEsperado)
        {
            //Arrange
            var funcionario = new FuncionarioCompleto 
            { 
                Nome = "Maria", 
                SalarioBruto = salarioBruto, 
                Imposto = imposto 
            };

            //Act
            var salarioLiquido = funcionario.SalarioLiquido();

            //Assert
            Assert.Equal(salarioLiquidoEsperado, salarioLiquido);
        }

        #endregion;

        #region FuncionarioCompleto_AumentarSalario;

        [Theory]
        [InlineData(1000.00, 10.0, 1100.00)] // 10% aumento
        [InlineData(2000.00, 5.0, 2100.00)]  // 5% aumento
        [InlineData(5000.00, 20.0, 6000.00)] // 20% aumento
        [InlineData(1500.00, 15.0, 1725.00)] // 15% aumento
        public void AumentarSalario_QuandoPercentagemForValida_DeveAumentarSalarioBrutoCorretamente(
            double salarioBrutoInicial, double porcentagem, double salarioBrutoEsperado)
        {
            //Arrange
            var funcionario = new FuncionarioCompleto 
            { 
                Nome = "Pedro", 
                SalarioBruto = salarioBrutoInicial, 
                Imposto = 200.00 
            };

            //Act
            funcionario.AumentarSalario(porcentagem);

            //Assert
            Assert.Equal(salarioBrutoEsperado, funcionario.SalarioBruto, precision: 10);
        }

        [Theory]
        [InlineData(1000.00, 0.0, 1000.00)]   // 0% aumento
        [InlineData(2000.00, 0.0, 2000.00)]   // sem aumento
        public void AumentarSalario_QuandoPorcentagemForZero_NaoDeveMudarSalario(
            double salarioBrutoInicial, double porcentagem, double salarioBrutoEsperado)
        {
            //Arrange
            var funcionario = new FuncionarioCompleto 
            { 
                Nome = "Ana", 
                SalarioBruto = salarioBrutoInicial, 
                Imposto = 150.00 
            };

            //Act
            funcionario.AumentarSalario(porcentagem);

            //Assert
            Assert.Equal(salarioBrutoEsperado, funcionario.SalarioBruto);
        }

        #endregion;

        #region Retangulo_Area;

        [Theory]
        [InlineData(5.0, 4.0, "AREA = 20.00")]
        [InlineData(10.0, 10.0, "AREA = 100.00")]
        [InlineData(3.5, 2.5, "AREA = 8.75")]
        [InlineData(7.2, 3.8, "AREA = 27.36")]
        public void Area_QuandoLarguraEAlturaEstiveremPreenchidas_DeveRetornarAreaCorreta(
            double largura, double altura, string areaEsperada)
        {
            //Arrange
            var retangulo = new Retangulo { Largura = largura, Altura = altura };

            //Act
            var area = retangulo.Area();

            //Assert
            Assert.IsType<string>(area);
            Assert.Equal(areaEsperada, area);
        }

        [Theory]
        [InlineData(0.0, 5.0, "AREA = 0.00")]
        [InlineData(5.0, 0.0, "AREA = 0.00")]
        [InlineData(0.0, 0.0, "AREA = 0.00")]
        public void Area_QuandoUmaDimensaoForZero_DeveRetornarZero(
            double largura, double altura, string areaEsperada)
        {
            //Arrange
            var retangulo = new Retangulo { Largura = largura, Altura = altura };

            //Act
            var area = retangulo.Area();

            //Assert
            Assert.Equal(areaEsperada, area);
        }

        #endregion;

        #region Retangulo_Perimetro;

        [Theory]
        [InlineData(5.0, 4.0, "PERIMETRO = 18.00")]
        [InlineData(10.0, 10.0, "PERIMETRO = 40.00")]
        [InlineData(3.5, 2.5, "PERIMETRO = 12.00")]
        [InlineData(7.2, 3.8, "PERIMETRO = 22.00")]
        public void Perimetro_QuandoLarguraEAlturaEstiveremPreenchidas_DeveRetornarPerimetroCorreto(
            double largura, double altura, string perimetroEsperado)
        {
            //Arrange
            var retangulo = new Retangulo { Largura = largura, Altura = altura };

            //Act
            var perimetro = retangulo.Perimetro();

            //Assert
            Assert.IsType<string>(perimetro);
            Assert.Equal(perimetroEsperado, perimetro);
        }

        #endregion;

        #region Retangulo_Diagonal;

        [Theory]
        [InlineData(3.0, 4.0, "DIAGONAL = 5.00")]
        [InlineData(5.0, 12.0, "DIAGONAL = 13.00")]
        [InlineData(6.0, 8.0, "DIAGONAL = 10.00")]
        public void Diagonal_QuandoLarguraEAlturaEstiveremPreenchidas_DeveRetornarDiagonalCorreta(
            double largura, double altura, string diagonalEsperada)
        {
            //Arrange
            var retangulo = new Retangulo { Largura = largura, Altura = altura };

            //Act
            var diagonal = retangulo.Diagonal();

            //Assert
            Assert.IsType<string>(diagonal);
            Assert.Equal(diagonalEsperada, diagonal);
        }

        #endregion;

        #region Aluno_CalcularNotaFinal;

        [Theory]
        [InlineData("João", 60.0, 70.0, 80.0, "NOTA FINAL = 70.50\nAPROVADO")] // Aprovado
        [InlineData("Maria", 70.0, 70.0, 70.0, "NOTA FINAL = 70.00\nAPROVADO")] // Aprovado com notas iguais
        [InlineData("Pedro", 90.0, 85.0, 95.0, "NOTA FINAL = 90.00\nAPROVADO")] // Aprovado com notas altas
        [InlineData("Ana", 50.0, 60.0, 70.0, "NOTA FINAL = 60.50\nAPROVADO")] // Aprovado na margem
        public void CalcularNotaFinal_QuandoNotasForemSuficientes_DeveRetornarAprovado(
            string nome, double nota1, double nota2, double nota3, string resultadoEsperado)
        {
            //Arrange
            var aluno = new Aluno 
            { 
                Nome = nome, 
                NotaPrimeiroTrimestre = nota1,
                NotaSegundoTrimestre = nota2,
                NotaTerceiroTrimestre = nota3
            };

            //Act
            var resultado = aluno.CalcularNotaFinal();

            //Assert
            Assert.IsType<string>(resultado);
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData("Carla", 40.0, 50.0, 55.0, "NOTA FINAL = 48.75\nREPROVADO\nFALTA = 11.25")] // Reprovado
        [InlineData("Lucas", 30.0, 40.0, 50.0, "NOTA FINAL = 40.50\nREPROVADO\nFALTA = 19.50")] // Reprovado com falta maior
        [InlineData("Beatriz", 0.0, 0.0, 0.0, "NOTA FINAL = 0.00\nREPROVADO\nFALTA = 60.00")] // Reprovado com todas as notas zero
        [InlineData("Roberto", 59.0, 60.0, 60.0, "NOTA FINAL = 59.70\nREPROVADO\nFALTA = 0.30")] // Reprovado muito perto do limite
        public void CalcularNotaFinal_QuandoNotasForemInsuficientes_DeveRetornarReprovadoComFalta(
            string nome, double nota1, double nota2, double nota3, string resultadoEsperado)
        {
            //Arrange
            var aluno = new Aluno 
            { 
                Nome = nome, 
                NotaPrimeiroTrimestre = nota1,
                NotaSegundoTrimestre = nota2,
                NotaTerceiroTrimestre = nota3
            };

            //Act
            var resultado = aluno.CalcularNotaFinal();

            //Assert
            Assert.IsType<string>(resultado);
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void CalcularNotaFinal_ComNotaExatamenteSessenta_DeveRetornarAprovado()
        {
            //Arrange
            var aluno = new Aluno 
            { 
                Nome = "Gabriel", 
                NotaPrimeiroTrimestre = 60.0,
                NotaSegundoTrimestre = 60.0,
                NotaTerceiroTrimestre = 60.0
            };

            //Act
            var resultado = aluno.CalcularNotaFinal();

            //Assert
            Assert.Contains("APROVADO", resultado);
            Assert.DoesNotContain("FALTA", resultado);
        }

        #endregion;

        #region ConversorDeMoeda_ConverterMoeda;

        [Theory]
        [InlineData(4.50, 100.0, "477.00")]      // 100 dólares a R$ 4.50 com IOF de 6%
        [InlineData(5.00, 200.0, "1060.00")]     // 200 dólares a R$ 5.00 com IOF de 6%
        [InlineData(3.80, 50.0, "201.40")]       // 50 dólares a R$ 3.80 com IOF de 6%
        [InlineData(4.20, 1000.0, "4452.00")]    // 1000 dólares a R$ 4.20 com IOF de 6%
        public void ConverterMoeda_QuandoCotacaoEQuantidadeEstiveremPreenchidas_DeveRetornarValorComIOF(
            double cotacao, double quantidade, string valorEsperado)
        {
            //Act
            var valor = HelperExerciciosSecao04.ConversorDeMoeda.ConverterMoeda(cotacao, quantidade);

            //Assert
            Assert.IsType<string>(valor);
            Assert.Equal(valorEsperado, valor);
        }

        [Theory]
        [InlineData(4.50, 0.0, "0.00")]           // Nenhum dólar
        [InlineData(5.00, 0.0, "0.00")]           // Zero dólares
        public void ConverterMoeda_QuandoQuantidadeForZero_DeveRetornarZero(
            double cotacao, double quantidade, string valorEsperado)
        {
            //Act
            var valor = HelperExerciciosSecao04.ConversorDeMoeda.ConverterMoeda(cotacao, quantidade);

            //Assert
            Assert.Equal(valorEsperado, valor);
        }

        [Fact]
        public void ConversorDeMoeda_IOFDeveSerSeisPorcento()
        {
            //Assert
            Assert.Equal(0.06, HelperExerciciosSecao04.ConversorDeMoeda.IOF);
        }

        #endregion;
    }
}
