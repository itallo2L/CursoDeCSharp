using System.Globalization;

namespace ExercicioUmSec04
{
    public class Retangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public string Area()
        {
            double area = Altura * Largura;
            return $"AREA = {ObterValorFormatado(area)}";
        }

        public string Diagonal()
        {
            double diagonal = Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
            return $"DIAGONAL = {ObterValorFormatado(diagonal)}";
        }

        public string Perimetro()
        {
            double perimetro = 2 * (Altura + Largura);
            return $"PERIMETRO = {ObterValorFormatado(perimetro)}";
        }

        private string ObterValorFormatado(double valor)
        {
            return valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}