namespace CursoDeCSharp.Exercicios
{
    public interface IExercicio
    {
        string Nome { get; }
        int Ordem { get; }
        object Executar();
    }
}