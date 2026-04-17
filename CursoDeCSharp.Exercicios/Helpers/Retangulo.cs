using System.Globalization;

namespace CursoDeCSharp.Exercicios.Helpers
{
    public class Retangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public string Area()
        {
            return $"AREA = {(Largura * Altura).ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public string Perimetro()
        {
            return $"PERIMETRO = {(2 * (Largura + Altura)).ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public string Diagonal()
        {
            return $"DIAGONAL = {Math.Sqrt(Largura * Largura + Altura * Altura).ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}