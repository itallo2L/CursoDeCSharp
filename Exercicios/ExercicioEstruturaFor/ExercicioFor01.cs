namespace CursoDeCSharp.Exercicios.ExercicioEstruturaFor
{
    public class ExercicioFor01
    {
        // Leia um valor inteiro X(1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
        // X, se for o caso.
        public static void Executar()
        {
            int entrada = int.Parse(Console.ReadLine());

            for (int i = 1; i <= entrada; i += 2)
                Console.WriteLine(i);
        }
    }
}
