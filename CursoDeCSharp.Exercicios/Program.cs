using CursoDeCSharp.Exercicios;
using System.Reflection;

public class Program
{
    public static void Main()
    {
        Executar();
    }

    public static void Executar()
    {
        var exercicios = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => typeof(IExercicio).IsAssignableFrom(t)
                     && !t.IsInterface
                     && !t.IsAbstract)
            .Select(t => (IExercicio)Activator.CreateInstance(t)!)
            .OrderBy(e => e.Nome)
            .ToList();

        Console.WriteLine("=== LISTA DE EXERCÍCIOS ===");

        for (int i = 0; i < exercicios.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {exercicios[i].Nome}");
        }

        Console.Write("\nDigite o código do exercício: ");
        var escolha = int.Parse(Console.ReadLine()!);

        if (!Console.IsOutputRedirected)
            Console.Clear();
        
        var resultado = exercicios[escolha - 1].Executar();

        Console.WriteLine(resultado);
    }
}