namespace CursoDeCSharp.Teste.TestesDasPrograms
{
    public class TesteExercicioEncapsulamento : HelperDosTestes
    {
        [Theory]
        [InlineData("8000\nJunior Filho Neto\ns\n1000.00\n500.00\n745.00\n", "Conta: 8000, Titular: Junior Filho Neto, Saldo: $ 750.00")]
        [InlineData("9999\nCamila Soares Noronha\nn\n5000.00\n100.00\n", "Conta: 9999, Titular: Camila Soares Noronha, Saldo: $ 4895.00")]
        public void ExercicioEncapsulamento_QuandoHaENaoHaSaldoInicial_DeveRetornarSaldoCorreto(string entradaDeDados, string somaEsperada)
        {
            //Arrange
            const string CodigoDoExercicio = "12\n";
            var entradaCompleta = $"{CodigoDoExercicio}{entradaDeDados}";

            //Act
            var retornoNaTela = ExecutarPrograma(entradaCompleta, Program.Main);

            //Assert
            Assert.Contains(somaEsperada, retornoNaTela);
        }
    }
}