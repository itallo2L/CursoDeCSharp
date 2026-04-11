namespace CursoDeCSharp.Teste
{
    public class HelperDosTestes
    {
        public static string ExecutarPrograma(string entrada, Action programa)
        {
            using var entradaDeDadosPeloTeclado = new StringReader(entrada);
            using var saidaDeDadosNaTela = new StringWriter();

            Console.SetIn(entradaDeDadosPeloTeclado);
            Console.SetOut(saidaDeDadosNaTela);

            programa();

            return saidaDeDadosNaTela.ToString().Trim();
        }
    }
}