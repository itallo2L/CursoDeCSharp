using System.Globalization;

namespace ExercicioDoisSec04
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public string SalarioLiquido()
        {
            return ObterValorFormatado(SalarioBruto - Imposto);
        }

        public void AumentarSalario(double porcentagem)
        {
            double valorParaAumentar = (porcentagem / 100) * SalarioBruto;
            SalarioBruto += valorParaAumentar;
        }

        private string ObterValorFormatado(double valor)
        {
            return valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}