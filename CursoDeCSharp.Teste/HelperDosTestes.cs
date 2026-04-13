namespace CursoDeCSharp.Teste
{
    public class HelperDosTestes
    {
        private static readonly object _consoleLock = new();

        public static string ExecutarPrograma(string entrada, Action programa)
        {
            lock (_consoleLock)
            {
                var entradaOriginal = Console.In;
                var saidaOriginal = Console.Out;

                try
                {
                    using var entradaDeDadosPeloTeclado = new StringReader(entrada);
                    using var saidaDeDadosNaTela = new StringWriter();

                    Console.SetIn(entradaDeDadosPeloTeclado);
                    Console.SetOut(saidaDeDadosNaTela);

                    programa();

                    return saidaDeDadosNaTela.ToString().Trim();
                }
                finally
                {
                    Console.SetIn(entradaOriginal);
                    Console.SetOut(saidaOriginal);
                }
            }
        }
    }
}