namespace ExercicioCondicional04
{
    // Leia a hora inicial e a hora final de um jogo.A seguir calcule a duração do jogo, sabendo que o mesmo pode
    // começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
    public static class Program
    {
        public static void Main()
        {
            string[] valoresEmString = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valoresEmString[0]);
            int horaFinal = int.Parse(valoresEmString[1]);
            int duracaoDoJogo = 0;

            if (horaInicial > horaFinal)
                duracaoDoJogo = (24 - horaInicial) + horaFinal;
            else if (horaInicial == horaFinal)
                duracaoDoJogo = 24;
            else if (horaInicial < horaFinal)
                duracaoDoJogo = horaFinal - horaInicial;

            Console.WriteLine($"O JOGO DUROU {duracaoDoJogo} HORA(S)");
        }
    }
}