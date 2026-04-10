using System.Globalization;

namespace Exercicio1_2
{
    public static class CalculadoraDeArea
    {
        public static string CalcularArea(double raio)
        {
            const double PI = 3.14159;
            return (PI * (raio * raio)).ToString("F4", CultureInfo.InvariantCulture);
        }
    }
}