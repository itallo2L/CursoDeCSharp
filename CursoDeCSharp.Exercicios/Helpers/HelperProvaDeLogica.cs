using System.Globalization;

namespace CursoDeCSharp.Exercicios.Helpers
{
    public static class HelperProvaDeLogica
    {
        public static string CalcularValorAPagar(int numeroPecasUm, int numeroPecasDois, double valorUnitarioPecaUm, double valorUnitarioPecaDois)
        {
            double valorTotalPecasUm = numeroPecasUm * valorUnitarioPecaUm;
            double valorTotalPecasDois = numeroPecasDois * valorUnitarioPecaDois;
            return (valorTotalPecasUm + valorTotalPecasDois).ToString("F2", CultureInfo.InvariantCulture);
        }

        public static string CalcularArea(double raio)
        {
            const double PI = 3.14159;
            return (PI * (raio * raio)).ToString("F4", CultureInfo.InvariantCulture);
        }

        public static string ObterQuantidadeDeValoresNoIntervaloEsperado(int totalDeValores)
        {
            int quantidadeDentroDoIntervalo = 0;
            int quantidadeForaDoIntervalo = 0;

            for (int i = 0; i < totalDeValores; i++)
            {
                int valorX = int.Parse(Console.ReadLine());
                if (valorX >= 10 && valorX <= 20)
                    quantidadeDentroDoIntervalo++;
                else
                    quantidadeForaDoIntervalo++;
            }

            return $"{quantidadeDentroDoIntervalo} in\n{quantidadeForaDoIntervalo} out";
        }

        public static string VerificarSeEhSenhaValida(int senhaInserida)
        {
            const int SenhaCorreta = 2002;
            const string MensagemSenhaInvalida = "Senha Inválida";
            const string MensagemAcessoPermitido = "Acesso Permitido";

            while (senhaInserida != SenhaCorreta)
            {
                Console.WriteLine(MensagemSenhaInvalida);
                senhaInserida = int.Parse(Console.ReadLine());

                if (senhaInserida == SenhaCorreta)
                    return MensagemAcessoPermitido;
            }

            return MensagemAcessoPermitido;
        }

        public static string CalcularEquacaoDeSegundoGrau(string[] valoresABC)
        {
            const string MensagemImpossivelCalcular = "Impossível calcular";
            double a = double.Parse(valoresABC[0]);

            if (a == 0)
                return MensagemImpossivelCalcular;

            double b = double.Parse(valoresABC[1]);
            double c = double.Parse(valoresABC[2]);

            double delta = (b * b) - (4 * a * c);

            if (delta < 0)
                return MensagemImpossivelCalcular;

            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            return $"X1 = {x1.ToString("F5", CultureInfo.InvariantCulture)}\nX2 = {x2.ToString("F5", CultureInfo.InvariantCulture)}";
        }
    }
}