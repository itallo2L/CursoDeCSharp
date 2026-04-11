namespace ExercicioWhileTres
{
    // Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes.Escreva
    // um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
    // 4.Fim). Caso o usuário informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código(até
    // que seja válido). O programa será encerrado quando o código informado for o número 4.Deve ser escrito a
    // mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
    // exemplo.
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Este programa conta abastecimentos por tipo de combustível" +
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
            };

            Console.WriteLine($"\nMUITO OBRIGADO\n" +
                $"Alcool: {contadorAlcool}\n" +
                $"Gasolina: {contadorGasolina}\nDiesel: {contadorDiesel}");
        }
    }
}