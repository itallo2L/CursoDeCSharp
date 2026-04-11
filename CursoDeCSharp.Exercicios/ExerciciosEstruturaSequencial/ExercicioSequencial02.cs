namespace CursoDeCSharp.Exercicios.ExerciciosEstruturaSequencial
{
    // Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
    // de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
    public class ExercicioSequencial02 : IExercicio
    {
        public string Nome => "ExercicioSequencial02";

        public object Executar()
        {
            Console.WriteLine("Este programa calcula a diferença entre o produto de A*B e o produto de C*D" +
                "\nDigite quatro valores inteiros - A, B, C, D (um por linha):");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            
            return $"DIFERENCA = {A * B - C * D}";
        }
    }
}
