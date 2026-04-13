namespace CursoDeCSharp.Exercicios.ExerciciosEstruturaWhile
{
    // Escreva um programa para ler as coordenadas (X, Y) de uma quantidade indeterminada de pontos no sistema
    // cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
    // menos uma de duas coordenadas for NULA.
    public class ExercicioEstruturaWhile01 : IExercicio
    {
        public string Nome => "ExercicioEstruturaWhile01";
        public int Ordem => 27;

        public object Executar()
        {
            Console.WriteLine($"=== {Nome} ===\nEste programa lê coordenadas (X, Y) e mostra o quadrante de cada ponto" +
                "\nDigite coordenadas X e Y separados por espaço (termine quando uma delas for 0):");
            string[] valores = ObterEntrada();
            int x = ObterValorNoArray(valores, 0);
            int y = ObterValorNoArray(valores, 1);

            string resultado = "";
            
            while (x != 0 && y != 0)
            {
                if (y > 0 && x > 0)
                    resultado += "primeiro\n";
                else if (y > 0 && x < 0)
                    resultado += "segundo\n";
                else if (y < 0 && x < 0)
                    resultado += "terceiro\n";
                else if (y < 0 && x > 0)
                    resultado += "quarto\n";

                valores = ObterEntrada();
                x = ObterValorNoArray(valores, 0);
                y = ObterValorNoArray(valores, 1);
            }
            
            return resultado.TrimEnd();
        }

        private static int ObterValorNoArray(string[] array, int indice)
        {
            return int.Parse(array[indice]);
        }

        private static string[] ObterEntrada()
        {
            return Console.ReadLine().Split(' ');
        }
    }
}
