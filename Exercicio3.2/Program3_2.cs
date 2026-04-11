namespace Exercicio3_2
{
    // Leia um valor inteiro N.Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
    // Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
    // essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo)
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Este programa conta quantos valores estão dentro/fora do intervalo [10, 20]" +
                "\nDigite a quantidade de valores, depois cada valor em uma linha separada:");
            int totalDeValores = int.Parse(Console.ReadLine());
            Console.WriteLine(ObterQuantidadeDeValoresNoIntervaloEsperado(totalDeValores));
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
            };

            return $"{quantidadeDentroDoIntervalo} in\n{quantidadeForaDoIntervalo} out";
        }
    }
}