using System.Globalization;

namespace ExercicioDoisSec04
{
    // Fazer um programa para ler os dados de um funcionário(nome, salário bruto e imposto). Em
    // seguida, mostrar os dados do funcionário(nome e salário líquido). Em seguida, aumentar o
    // salário do funcionário com base em uma porcentagem dada(somente o salário bruto é
    // afetado pela porcentagem) e mostrar novamente os dados do funcionário.Use a classe
    // projetada abaixo.
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Este programa gerencia dados de um funcionário e simula aumento salarial" +
                "\nDigite o nome, salário bruto e imposto de um funcionário (um por linha):");
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"\nFuncionário: {funcionario.Nome}, $ {funcionario.SalarioLiquido()}\n");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine($"\nDados atualizados: {funcionario.Nome}, $ {funcionario.SalarioLiquido()}");
        }
    }
}