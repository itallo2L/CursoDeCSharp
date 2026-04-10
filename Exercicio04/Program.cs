using System.Globalization;

namespace Exercicio04
{
    //  Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
    //  hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas
    //  decimais.
    public static class Program
    {
        public static void Main()
        {
            int numeroDoFuncionario = int.Parse(Console.ReadLine());
            double horasTrabalhadas = double.Parse(Console.ReadLine());
            double valorDaHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"NUMBER = {numeroDoFuncionario}\nSALARY = U$ {(horasTrabalhadas * valorDaHora).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}