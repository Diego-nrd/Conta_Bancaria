using System.Globalization;
namespace Conta_Bancaria
{
    class Conta
    {
        public int Nconta { get; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        private double _taxa = 5.00;

        public Conta(int nconta, string nome)
        {
            Nconta = nconta;
            Nome = nome;
        }

        public Conta(int nconta, string nome, double valorInicial) : this(nconta, nome)
        {
            Depositar(valorInicial);
        }
        public void Depositar(double saldo)
        {
            Saldo += saldo;
        }

        public void Sacar(double saldo)
        {
            Saldo -= saldo + _taxa;
        }

        public override string ToString()
        {
            return Nconta +
                ", Titular: " +
                Nome +
                ", Saldo: $" +
                Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
