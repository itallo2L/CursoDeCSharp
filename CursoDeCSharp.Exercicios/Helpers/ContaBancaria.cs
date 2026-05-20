namespace CursoDeCSharp.Exercicios.Helpers
{
    public class ContaBancaria
    {
        //Número da conta (Inalterável)
        public int NumeroDaConta { get; private set; }
        //Nome do titular (Pode ser alterado)
        public string NomeDoTitular { get; set; }
        //Saldo (Só aumenta por meio de depósitos e diminui por meio de saques -> com taxas de 5 reais)
        public double Saldo { get; private set; }
        
        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        
        public void Sacar(double valor)
        {
            Saldo -= valor + 5;
        }

        public ContaBancaria(int numeroDaConta, string nomeDoTitular, double depositoInicial = 0)
        {
            NumeroDaConta = numeroDaConta;
            NomeDoTitular = nomeDoTitular;
            Saldo = depositoInicial;
        }
    }
}