namespace CursoDeCSharp.Exercicios.ProvaDeLogica
{
    // Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
    // Mostre quantos destes valores X estão dentro do intervalo [10, 20] e quantos estão fora do intervalo,
    // mostrando essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
    public class Exercicio3_2 : IExercicio
    {
        public string Nome => "Exercicio3_2";

        public object Executar()
        {
            Console.WriteLine("Entrada:");
            int totalDeValores = int.Parse(Console.ReadLine());
            return ObterQuantidadeDeValoresNoIntervaloEsperado(totalDeValores);
        }

        private static string ObterQuantidadeDeValoresNoIntervaloEsperado(int totalDeValores)
        {
            int quantidadeDentroDoIntervalo = 0;
            int quantidadeForaDoIntervalo = 0;

            for (int i = 0; i < totalDeValores; i++)
            {
                int valorX = int.Parse(Console.ReadLine());
                if (valorX >= 10 && valorX <= 20)
                    quantidadeDentroDoIntervalo++;
                else
                    quantidadeForaDoIntervalo++;
            }

            return $"{quantidadeDentroDoIntervalo} in\n{quantidadeForaDoIntervalo} out";
        }
    }
}
