namespace CursoDeCSharp.Exercicios.Helpers
{
    public static class HelperExerciciosSecao04
    {
        public static string ObterNomeDaPessoaMaisVelha(Pessoa pessoaUm, Pessoa pessoaDois)
        {
            if (pessoaUm.Idade > pessoaDois.Idade)
                return $"Pessoa mais velha: {pessoaUm.Nome}";
            else if (pessoaDois.Idade > pessoaUm.Idade)
                return $"Pessoa mais velha: {pessoaDois.Nome}";

            return "Ambas têm a mesma idade";
        }
    }
}