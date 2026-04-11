namespace CursoDeCSharp.Exercicios.ProvaDeLogica
{
    // Escreva um programa que repita a leitura de uma senha até que ela seja válida.
    // Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Invalida".
    // Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.
    // Considere que a senha correta é o valor 2002.
    public class Exercicio3_1 : IExercicio
    {
        public string Nome => "Exercicio3_1";

        public object Executar()
        {
            Console.WriteLine("Este programa valida uma senha repetidamente até que seja correta" +
                "\nDigite uma senha (repetidamente até acertar):");
            int senhaInserida = int.Parse(Console.ReadLine());
            return VerificarSeEhSenhaValida(senhaInserida);
        }

        private static string VerificarSeEhSenhaValida(int senhaInserida)
        {
            const int SenhaCorreta = 2002;
            const string MensagemSenhaInvalida = "Senha Inválida";
            const string MensagemAcessoPermitido = "Acesso Permitido";

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
