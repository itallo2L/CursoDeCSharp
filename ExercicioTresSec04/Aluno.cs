using System.Globalization;

namespace ExercicioTresSec04
{
    public class Aluno
    {
        public string Nome { get; set; }
        public double NotaPrimeiroTrimeste { get; set; }
        public double NotaSegundoTrimeste { get; set; }
        public double NotaTerceiroTrimeste { get; set; }
    
        public string CalcularNotaFinal()
        {
            const double Media = 60.00;
            double notasNosTresTrimestres = NotaPrimeiroTrimeste + NotaSegundoTrimeste + NotaTerceiroTrimeste;
            if (notasNosTresTrimestres < Media)
                return $"NOTA FINAL = {ObterValorFormatado(notasNosTresTrimestres)}\nREPROVADO\nFALTARAM {ObterValorFormatado(Media - notasNosTresTrimestres)} PONTOS";

            return $"NOTA FINAL = {ObterValorFormatado(notasNosTresTrimestres)}\nAPROVADO";
        }

        private string ObterValorFormatado(double valor)
        {
            return valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}