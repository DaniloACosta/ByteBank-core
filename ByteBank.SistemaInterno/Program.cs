using System;
using System.Globalization;
using System.Threading;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", false);
            DateTime dataFim = new DateTime(2019, 02, 23);
            DateTime dataNow = DateTime.Now;
            TimeSpan diferencaData = dataNow - dataFim;
            String mensagem = "A fatura vence em " + TimeSpanHumanizeExtensions.Humanize(diferencaData, 1, new CultureInfo("es-MX", false));
            Console.WriteLine(mensagem);

            if(0 == 1)
                GerenciamentoConta();
        }

        private static void GerenciamentoConta()
        {
            ContaCorrente conta = new ContaCorrente(123, 123);
            conta.Saldo = 100;
            conta.Sacar(10);
            Console.WriteLine(conta.Saldo);
        }
    }
}
