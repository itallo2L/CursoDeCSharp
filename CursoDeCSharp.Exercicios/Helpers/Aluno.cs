using System.Globalization;

namespace CursoDeCSharp.Exercicios.Helpers
{
    public class Aluno
    {
        public string Nome { get; set; }
        public double NotaPrimeiroTrimestre { get; set; }
        public double NotaSegundoTrimestre { get; set; }
        public double NotaTerceiroTrimestre { get; set; }

        public string CalcularNotaFinal()
        {
            double notaFinal = (NotaPrimeiroTrimestre * 0.3) + (NotaSegundoTrimestre * 0.35) + (NotaTerceiroTrimestre * 0.35);

            string resultado = $"NOTA FINAL = {notaFinal.ToString("F2", CultureInfo.InvariantCulture)}\n";

            if (notaFinal >= 60)
                resultado += "APROVADO";
            else
            {
                resultado += "REPROVADO\n";
                resultado += $"FALTA = {(60 - notaFinal).ToString("F2", CultureInfo.InvariantCulture)}";
            }

            return resultado;
        }
    }
}