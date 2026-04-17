using CursoDeCSharp.Exercicios.Helpers;

namespace CursoDeCSharp.Exercicios.ExerciciosSecao04
{
    // Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.
    public class Secao0401 : IExercicio
    {
        public string Nome => "Secao0401";
        public int Ordem => 7;

        public object Executar()
        {
            Console.WriteLine($"=== {Nome} ===\nEste programa lê dados de duas pessoas e mostra quem é a mais velha" +
                "\nDigite o nome e idade de duas pessoas (um dado por linha):");
            Pessoa pessoaUm = new Pessoa();
            Pessoa pessoaDois = new Pessoa();

            Console.Write("Dados da primeira pessoa:\nNome: ");
            pessoaUm.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoaUm.Idade = int.Parse(Console.ReadLine());

            Console.Write("Dados da segunda pessoa:\nNome: ");
            pessoaDois.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoaDois.Idade = int.Parse(Console.ReadLine());

            return HelperExerciciosSecao04.ObterNomeDaPessoaMaisVelha(pessoaUm, pessoaDois);
        }
    }
}