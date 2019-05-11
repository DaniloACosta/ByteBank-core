using System;

namespace ByteBank.ImportacaExportacao.Models
{
    public class BankAccounts
    {
        public int Number { get; }
        public int Branch { get; }
        public double Balance { get; private set; }
        public ClientAccount Title { get; set; }

        public BankAccounts(int branch, int number)
        {
            Branch = branch;
            Number = number;
        }

        public void Deposit(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Valor de deposito deve ser maior que zero.", nameof(value));
            }

            Balance += Balance;
        }

        public void CashOut(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Valor de saque deve ser maior que zero.", nameof(value));
            }

            if(value > Balance)
            {
                throw new InvalidOperationException("Saldo insuficiente.");
            }

            Balance += Balance;
        }
    }
}