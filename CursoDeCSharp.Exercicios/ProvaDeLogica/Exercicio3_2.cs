namespace CursoDeCSharp.Exercicios.ProvaDeLogica
{
    // Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
    // Mostre quantos destes valores X estão dentro do intervalo [10, 20] e quantos estão fora do intervalo,
    // mostrando essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
    public class Exercicio3_2 : IExercicio
    {
        public string Nome => "Exercicio3_2";
        public int Ordem => 6;

        public object Executar()
        {
            Console.WriteLine($"=== {Nome} ===\nEste programa conta quantos valores estão dentro/fora do intervalo [10, 20]" +
                "\nDigite a quantidade de valores, depois cada valor em uma linha separada:");
            int totalDeValores = int.Parse(Console.ReadLine());
            return HelperProvaDeLogica.ObterQuantidadeDeValoresNoIntervaloEsperado(totalDeValores);
        }
    }
}
