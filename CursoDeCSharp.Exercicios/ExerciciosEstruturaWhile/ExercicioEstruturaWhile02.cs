namespace CursoDeCSharp.Exercicios.ExerciciosEstruturaWhile
{
    // Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
    // um algoritmo para ler o tipo de combustível abastecido (codificado: 1.Álcool 2.Gasolina 3.Diesel 4.Fim).
    // O programa será encerrado quando o código informado for 4.
    public class ExercicioEstruturaWhile02 : IExercicio
    {
        public string Nome => "ExercicioEstruturaWhile02";

        public object Executar()
        {
            Console.WriteLine($"=== {Nome} ===\nEste programa conta abastecimentos por tipo de combustível" +
                "\nDigite o tipo de combustível (1:Álcool, 2:Gasolina, 3:Diesel, 4:Fim):");
            int contadorAlcool = 0;
            int contadorGasolina = 0;
            int contadorDiesel = 0;
            int entrada = int.Parse(Console.ReadLine());

            while (entrada != 4)
            {
                if (entrada == 1)
                    contadorAlcool++;
                else if (entrada == 2)
                    contadorGasolina++;
                else if (entrada == 3)
                    contadorDiesel++;

                entrada = int.Parse(Console.ReadLine());
            }

            return $"\nMUITO OBRIGADO\nAlcool: {contadorAlcool}\nGasolina: {contadorGasolina}\nDiesel: {contadorDiesel}";
        }
    }
}
