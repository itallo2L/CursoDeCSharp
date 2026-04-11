using System.Globalization;

namespace CursoDeCSharp.Exercicios.ExerciciosSecao04
{
    // Fazer um programa para ler os dados de um funcionário e simular aumento salarial
    public class Secao0404 : IExercicio
    {
        public string Nome => "Secao0404";

        public object Executar()
        {
            Console.WriteLine("Este programa gerencia dados de um funcionário e simula aumento salarial" +
                "\nDigite o nome, salário bruto e imposto de um funcionário (um por linha):");
            FuncionarioCompleto funcionario = new FuncionarioCompleto();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string resultado = $"\nFuncionário: {funcionario.Nome}, $ {funcionario.SalarioLiquido()}\n";

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);

            resultado += $"\nDados atualizados: {funcionario.Nome}, $ {funcionario.SalarioLiquido()}";
            
            return resultado;
        }
    }

    public class FuncionarioCompleto
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto * (1.0 + porcentagem / 100.0);
        }
    }
}
