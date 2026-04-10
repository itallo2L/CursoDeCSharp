namespace Exercicio3_1
{
    // Escreva um programa que repita a leitura de uma senha até que ela seja válida.Para cada leitura de senha
    // incorreta informada, escrever a mensagem "Senha Invalida".Quando a senha for informada corretamente deve ser
    // impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Entrada:");
            int senhaInserida = int.Parse(Console.ReadLine());
            Console.WriteLine(VerificarSeEhSenhaValida(senhaInserida));
        }

        private static string VerificarSeEhSenhaValida(int senhaInserida)
        {
            const int SenhaCorreta = 2002;
            const string MensagemSenhaInvalida = "Senha Inválida";
            const string MensagemAcessoPermitido= "Acesso Permitido";

            while (senhaInserida != SenhaCorreta)
            {
                Console.WriteLine(MensagemSenhaInvalida);
                senhaInserida = int.Parse(Console.ReadLine());

                if (senhaInserida == SenhaCorreta)
                    return MensagemAcessoPermitido;
            }

            return MensagemAcessoPermitido;
        }
    }
}