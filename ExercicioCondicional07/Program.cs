namespace ExercicioCondicional07MyApp
{
    public static class Program
    {
        // Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
        // de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
        // ponto, ou se está sobre um dos eixos cartesianos ou na origem(x = y = 0).
        // Se o ponto estiver na origem, escreva a mensagem “Origem”.
        // Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
        // situação.
        public static void Main()
        {
            string[] valores = Console.ReadLine().Split(' ');
            double x = Math.Round(double.Parse(valores[0]), 1);
            double y = Math.Round(double.Parse(valores[1]), 1);

            if (x == y && y == 0)
            {
                Console.WriteLine("Origem");
                return;
            }
            else if (y > 0 && x > 0)
                Console.WriteLine("Q1");
            else if (y > 0 && x < 0)
                Console.WriteLine("Q2");
            else if (y < 0 && x < 0)
                Console.WriteLine("Q3");
            else if (y < 0 && x > 0)
                Console.WriteLine("Q4");
            else if (y == 0)
                Console.WriteLine("Eixo X");
            else if (x == 0)
                Console.WriteLine("Eixo Y");
        }
    }
}