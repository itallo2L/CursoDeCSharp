namespace CursoDeCSharp.Exercicios.ProvaDeLogica
{
    // Escreva um programa que repita a leitura de uma senha até que ela seja válida.
    // Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Invalida".
    // Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.
    // Considere que a senha correta é o valor 2002.
    public class Exercicio3_1 : IExercicio
    {
        public string Nome => "Exercicio3_1";
        public int Ordem => 5;

        public object Executar()
        {
            Console.WriteLine($"=== {Nome} ===\nEste programa valida uma senha repetidamente até que seja correta" +
                "\nDigite uma senha (repetidamente até acertar):" );
            int senhaInserida = int.Parse(Console.ReadLine());
            return HelperProvaDeLogica.VerificarSeEhSenhaValida(senhaInserida);
        }
    }
}