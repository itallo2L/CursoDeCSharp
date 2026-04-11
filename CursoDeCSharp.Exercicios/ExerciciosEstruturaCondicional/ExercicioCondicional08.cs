using System.Globalization;

namespace CursoDeCSharp.Exercicios.ExerciciosEstruturaCondicional
{
    // Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
    // mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
    // Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
    // salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda.
    public class ExercicioCondicional08 : IExercicio
    {
        public string Nome => "ExercicioCondicional08";

        public object Executar()
        {
            Console.WriteLine($"=== {Nome} ===\nEste programa calcula o imposto de renda baseado em faixas de salário" +
                "\nDigite o salário com duas casas decimais:");
            const double OitoPorCento = 0.08 * 1000.00;
            const double DezoitoPorCento = 0.18 * 1500.00;
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto = 0.0;

            if (salario <= 2000)
                return "Isento";
            else if (salario > 2000 && salario <= 3000)
            {
                salario -= 2000;
                imposto = 0.08 * salario;
            }
            else if (salario > 3000 && salario <= 4500)
            {
                salario -= 3000;
                imposto = (0.18 * salario) + OitoPorCento;
            }
            else if (salario > 4500)
            {
                salario -= 4500;
                imposto = (0.28 * salario) + OitoPorCento + DezoitoPorCento;
            }

            return $"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
