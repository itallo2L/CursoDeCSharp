namespace CursoDeCSharp.Exercicios.ExerciciosEstruturaCondicional
{
    // Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
    // Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
    // ordem crescente ou decrescente.
    public class ExercicioCondicional03 : IExercicio
    {
        public string Nome => "ExercicioCondicional03";

        public object Executar()
        {
            Console.WriteLine("Este programa verifica se dois números são múltiplos entre si" +
                "\nDigite dois valores inteiros separados por espaço:");
            string[] valoresEmString = Console.ReadLine().Split(' ');
            int a = int.Parse(valoresEmString[0]);
            int b = int.Parse(valoresEmString[1]);

            if ((a % b) == 0 || (b % a) == 0)
                return "Sao Multiplos";
            else
                return "Nao sao Multiplos";
        }
    }
}
