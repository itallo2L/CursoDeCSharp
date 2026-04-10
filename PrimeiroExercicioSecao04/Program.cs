namespace PrimeiroExercicioSecao04
{
    // Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.
    public static class Program
    {
        public static void Main()
        {
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

            Console.WriteLine(ObterNomeDaPessoaMaisVelha(pessoaUm, pessoaDois));
        }

        private static string ObterNomeDaPessoaMaisVelha(Pessoa pessoaUm, Pessoa pessoaDois)
        {
            if (pessoaUm.Idade > pessoaDois.Idade)
                return $"Pessoa mais velha: {pessoaUm.Nome}";
            else if (pessoaDois.Idade > pessoaUm.Idade) 
                return $"Pessoa mais velha: {pessoaDois.Nome}";

            return "Ambas tem a mesma idade";
        }
    }
}