using System.Globalization;

namespace ExercicioFixacaoMembrosEstaticos
{
    public static class ConversorDeMoeda
    {
        public static string ConverterModeda(double cotacaoDoDolar, double quantidadeDeDolarParaComprar)
        {
            const double IOF = 0.06;
            double quantidadeEmReais = cotacaoDoDolar * quantidadeDeDolarParaComprar;
            quantidadeEmReais += IOF * quantidadeEmReais;
            return quantidadeEmReais.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
