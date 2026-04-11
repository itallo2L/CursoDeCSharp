using System.Globalization;

namespace CursoDeCSharp.Exercicios.ExerciciosEstruturaSequencial
{
    // Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
    // hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.
    public class ExercicioSequencial03 : IExercicio
    {
        public string Nome => "ExercicioSequencial03";

        public object Executar()
        {
            Console.WriteLine($"=== {Nome} ===\nEste programa calcula o salário de um funcionário" +
                "\nDigite o número do funcionário, horas trabalhadas e valor por hora (um por linha):");
            int numeroDoFuncionario = int.Parse(Console.ReadLine());
            double horasTrabalhadas = double.Parse(Console.ReadLine());
            double valorDaHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            return $"NUMBER = {numeroDoFuncionario}\nSALARY = U$ {(horasTrabalhadas * valorDaHora).ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
