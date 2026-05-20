using CursoDeCSharp.Exercicios.Helpers;
using System.Globalization;

namespace CursoDeCSharp.Exercicios.ExerciciosSecao05
{
    internal class ExercicioEncapsulamento : IExercicio
    {
        // Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do
        // titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta.Este valor de depósito
        // inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua
        // conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.
        // Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já
        // o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento, por
        // exemplo).
        // Por fim, o saldo da conta não pode ser alterado livremente.É preciso haver um mecanismo para proteger
        // isso.O saldo só aumenta por meio de depósitos, e só diminui por meio de saques.Para cada saque
        // realizado, o banco cobra uma taxa de $ 5.00. Nota: a conta pode ficar com saldo negativo se o saldo não for
        // suficiente para realizar o saque e/ou pagar a taxa.
        // Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não
        // informado o valor de depósito inicial.Em seguida, realizar um depósito e depois um saque, sempre
        // mostrando os dados da conta após cada operação.
        public string Nome => "ExercicioEncapsulamento";
        public int Ordem => 12;

        public object Executar()
        {
            Console.WriteLine($"=== {Nome} ===\nEste programa realiza operações em uma conta bancária.");
            Console.Write("Entre o número da conta: ");
            var numeroDaConta = int.Parse(Console.ReadLine()!);

            Console.Write("Entre o titular da conta: ");
            var nomeDoTitular = Console.ReadLine();

            Console.Write("Haverá depósito incial (s/n)? ");
            string haDepositoInicial = Console.ReadLine()!;
            double depositoInicial = 0.0;

            if (haDepositoInicial!.ToLower() == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                depositoInicial = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            }

            var contaBancaria = new ContaBancaria(numeroDaConta, nomeDoTitular!, depositoInicial);

            Console.WriteLine("\nDados da conta:");
            Console.WriteLine($"Conta: {contaBancaria.NumeroDaConta}, Titular: {contaBancaria.NomeDoTitular}, Saldo: $ {(contaBancaria.Saldo).ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("\nEntre o valor de depósito: ");
            contaBancaria.Depositar(double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine($"Conta: {contaBancaria.NumeroDaConta}, Titular: {contaBancaria.NomeDoTitular}, Saldo: $ {(contaBancaria.Saldo).ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("\nEntre um valor para saque: ");
            contaBancaria.Sacar(double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");

            var retornoFinalDoPrograma = $"Conta: {contaBancaria.NumeroDaConta}, Titular: {contaBancaria.NomeDoTitular}, Saldo: $ {(contaBancaria.Saldo).ToString("F2", CultureInfo.InvariantCulture)}";
            Console.Write(retornoFinalDoPrograma);

            return retornoFinalDoPrograma;
        }
    }
}