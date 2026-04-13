namespace CursoDeCSharp.Exercicios.ExerciciosEstruturaSequencial
{
    // Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
    // mensagem explicativa
    public class ExercicioSequencial01 : IExercicio
    {
        public string Nome => "ExercicioSequencial01";
        public int Ordem => 29;

        public object Executar()
        {
            Console.WriteLine($"=== {Nome} ===\nEste programa lê dois valores inteiros e mostra a soma desses números" +
                "\nDigite dois valores inteiros (um por linha):");
            int primeiroValor = int.Parse(Console.ReadLine());
            int segundoValor = int.Parse(Console.ReadLine());
            
            return $"SOMA = {primeiroValor + segundoValor}";
        }
    }
}
