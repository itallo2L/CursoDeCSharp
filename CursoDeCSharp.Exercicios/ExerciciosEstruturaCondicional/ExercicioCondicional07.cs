namespace CursoDeCSharp.Exercicios.ExerciciosEstruturaCondicional
{
    // Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
    // de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
    // ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
    // Se o ponto estiver na origem, escreva a mensagem "Origem".
    // Se o ponto estiver sobre um dos eixos escreva "Eixo X" ou "Eixo Y", conforme for a situação.
    public class ExercicioCondicional07 : IExercicio
    {
        public string Nome => "ExercicioCondicional07";
        public int Ordem => 18;

        public object Executar()
        {
            Console.WriteLine($"=== {Nome} ===\nEste programa determina o quadrante ou eixo de um ponto em um plano cartesiano" +
                "\nDigite dois valores com uma casa decimal separados por espaço (coordenadas x e y):");
            string[] valores = Console.ReadLine().Split(' ');
            double x = Math.Round(double.Parse(valores[0]), 1);
            double y = Math.Round(double.Parse(valores[1]), 1);

            if (x == y && y == 0)
                return "Origem";
            else if (y > 0 && x > 0)
                return "Q1";
            else if (y > 0 && x < 0)
                return "Q2";
            else if (y < 0 && x < 0)
                return "Q3";
            else if (y < 0 && x > 0)
                return "Q4";
            else if (y == 0)
                return "Eixo X";
            else if (x == 0)
                return "Eixo Y";
            
            return "";
        }
    }
}
