using CursoDeCSharp.Exercicios.Helpers;

namespace CursoDeCSharp.Exercicios.ExercicioEstruturaFor
{
    // Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
    // começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor.
    public class ExercicioEstruturaFor07 : IExercicio
    {
        public string Nome => "ExercicioEstruturaFor07";
        public int Ordem => 26;

        public object Executar()
        {
            Console.WriteLine($"=== {Nome} ===\nEste programa mostra N linhas com o número, seu quadrado e seu cubo" +
                "\nDigite um número inteiro positivo:");
            int entrada = int.Parse(Console.ReadLine());
            
            return HelperExerciciosEstruturaFor.ObterTabelaQuadradosCubos(entrada);
        }
    }
}