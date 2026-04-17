using CursoDeCSharp.Exercicios.Helpers;
using System.Globalization;

namespace CursoDeCSharp.Exercicios.ExerciciosSecao04
{
    // Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.
    public class Secao0402 : IExercicio
    {
        public string Nome => "Secao0402";
        public int Ordem => 8;

        public object Executar()
        {
            Console.WriteLine($"=== {Nome} ===\nEste programa lê dados de dois funcionários e calcula o salário médio" +
                "\nDigite o nome e salário de dois funcionários (um dado por linha):");
            Funcionario funcionarioUm = new Funcionario();
            Funcionario funcionarioDois = new Funcionario();

            Console.Write("Dados do primeiro funcionário:\nNome: ");
            funcionarioUm.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionarioUm.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Dados do segundo funcionário:\nNome: ");
            funcionarioDois.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionarioDois.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalarial = (funcionarioUm.Salario + funcionarioDois.Salario) / 2.0;
            return $"Salário médio = {mediaSalarial.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}