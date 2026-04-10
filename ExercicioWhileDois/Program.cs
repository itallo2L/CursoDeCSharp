namespace ExercicioWhileDois
{
    public static class Program
    {
        // Escreva um programa para ler as coordenadas (X, Y) de uma quantidade indeterminada de pontos no sistema
        // cartesiano.Para cada ponto escrever o quadrante a que ele pertence.O algoritmo será encerrado quando pelo
        // menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
        public static void Main()
        {
            string[] valores = ObterEntrada();
            int x = ObterValorNoArray(valores, 0);
            int y = ObterValorNoArray(valores, 1);

            while (x != 0 && y != 0)
            {
                if (y > 0 && x > 0)
                    Console.WriteLine("primeiro");
                else if (y > 0 && x < 0)
                    Console.WriteLine("segundo");
                else if (y < 0 && x < 0)
                    Console.WriteLine("terceiro");
                else if (y < 0 && x > 0)
                    Console.WriteLine("quarto");

                valores = ObterEntrada();
                x = ObterValorNoArray(valores, 0);
                y = ObterValorNoArray(valores, 1);
            };
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