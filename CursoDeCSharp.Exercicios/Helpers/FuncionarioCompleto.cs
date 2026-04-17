namespace CursoDeCSharp.Exercicios.Helpers
{

    public class FuncionarioCompleto
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto * (1.0 + porcentagem / 100.0);
        }
    }
}