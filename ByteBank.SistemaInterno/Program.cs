using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(123,123);
            conta.Saldo = 100;
            conta.Sacar(10);
            Console.WriteLine(conta.Saldo);
        }
    }
}
