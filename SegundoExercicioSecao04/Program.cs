using System.Globalization;

namespace SegundoExercicioSecao04
{
    // Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
    // médio dos funcionários.
    public static class Program
    {
        public static void Main()
        {
            Funcionario funcionarioUm = new Funcionario();
            Funcionario funcionarioDois = new Funcionario();

            Console.Write("Dados do primeiro funcionário:\nNome: ");
            funcionarioUm.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionarioUm.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Dados do segundo funcionário:\r\nNome: ");
            funcionarioDois.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionarioDois.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Salário médio = {(funcionarioUm.Salario + funcionarioDois.Salario) / 2.0}");
        }
    }
}