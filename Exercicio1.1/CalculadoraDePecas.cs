using System.Globalization;

namespace Exercicio1_1
{
    public static class CalculadoraDePecas
    {
        public static string CalcularValorAPagar(int numeroPecasUm, int numeroPecasDois, double valorUnitarioPecaUm, double valorUnitarioPecaDois)
        {
            double valorTotalPecasUm = numeroPecasUm * valorUnitarioPecaUm;
            double valorTotalPecasDois = numeroPecasDois * valorUnitarioPecaDois;
            return (valorTotalPecasUm + valorTotalPecasDois).ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}