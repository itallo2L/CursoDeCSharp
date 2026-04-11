namespace CursoDeCSharp.Exercicios
{
    public interface IExercicio
    {
        string Nome { get; }
        object Executar();
    }
}