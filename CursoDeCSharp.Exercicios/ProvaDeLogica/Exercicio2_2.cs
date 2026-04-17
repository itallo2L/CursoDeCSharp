using CursoDeCSharp.Exercicios.ProvaDeLogica.Helpers;

namespace CursoDeCSharp.Exercicios.ProvaDeLogica
{
    // Ler os valores dos três coeficientes "a", "b" e "c" de uma equação do segundo grau (ax² + bx + c = 0)
    // Em seguida, mostrar os valores das raízes da equação, conforme exemplos, usando a fórmula de Bhaskara.
    // Se a equação não possuir raízes (o valor de "a" não pode ser zero, e o valor de "delta" não pode ser
    // negativo), mostrar uma mensagem "Impossivel calcular".
    public class Exercicio2_2 : IExercicio
    {
        public string Nome => "Exercicio2_2";
        public int Ordem => 4;

        public object Executar()
        {
            Console.WriteLine($"=== {Nome} ===\nEste programa calcula as raízes de uma equação de segundo grau" +
                "\nDigite três números na mesma linha (a, b e c):");
            string[] valoresABC = Console.ReadLine().Split(' ');
            return HelperProvaDeLogica.CalcularEquacaoDeSegundoGrau(valoresABC);
        }
    }
}