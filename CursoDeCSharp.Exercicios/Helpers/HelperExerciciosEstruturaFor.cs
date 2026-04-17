using System.Globalization;

namespace CursoDeCSharp.Exercicios.Helpers
{
    public class HelperExerciciosEstruturaFor
    {
        public static string ObterImpares(int entrada)
        {
            string resultado = "";
            for (int i = 1; i <= entrada; i += 2)
                resultado += $"{i}\n";

            return resultado.TrimEnd();
        }

        public static string CalcularMediasPonderadas(int entrada)
        {
            string resultado = "";

            for (int i = 0; i < entrada; i++)
            {
                string[] entradas = Console.ReadLine().Split(' ');
                double x = double.Parse(entradas[0], CultureInfo.InvariantCulture);
                double y = double.Parse(entradas[1], CultureInfo.InvariantCulture);
                double z = double.Parse(entradas[2], CultureInfo.InvariantCulture);

                double media = ((x * 2.0) + (y * 3.0) + (z * 5.0)) / 10.0;

                resultado += $"{media.ToString("F1", CultureInfo.InvariantCulture)}\n";
            }

            return resultado.TrimEnd();
        }

        public static string CalcularDivisoes(int entrada)
        {
            string resultado = "";

            for (int i = 0; i < entrada; i++)
            {
                string[] entradas = Console.ReadLine().Split(' ');
                double a = double.Parse(entradas[0], CultureInfo.InvariantCulture);
                double b = double.Parse(entradas[1], CultureInfo.InvariantCulture);

                if (b == 0.0)
                    resultado += "divisao impossivel\n";
                else
                    resultado += $"{(a / b).ToString("F1", CultureInfo.InvariantCulture)}\n";
            }

            return resultado.TrimEnd();
        }

        public static long CalcularFatorial(int entrada)
        {
            long fatorial = 1;

            for (int i = 1; i <= entrada; i++)
                fatorial = fatorial * i;

            return fatorial;
        }

        public static string ObterDivisores(int entrada)
        {
            string resultado = "";

            for (int i = 1; i <= entrada; i++)
                if (entrada % i == 0)
                    resultado += $"{i}\n";

            return resultado.TrimEnd();
        }

        public static string ObterTabelaQuadradosCubos(int entrada)
        {
            string resultado = "";

            for (int i = 1; i <= entrada; i++)
                resultado += $"{i} {i * i} {i * i * i}\n";

            return resultado.TrimEnd();
        }
    }
}