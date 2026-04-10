using CursoDeCSharp.Exercicios.ExercicioEstruturaFor;

namespace CursoDeCSharp.Exercicios;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Escolha o exercício:");
        Console.WriteLine("1 - For 01");
        Console.WriteLine("2 - For 02");
        Console.WriteLine("0 - Sair");

        var opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                ExercicioFor01.Executar();
                break;

            // case "2":
            //     ExercicioFor02.Executar();
            //     break;

            case "0":
                return;

            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }
}