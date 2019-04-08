using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaInterno {
    class Program {
        static void Main (string[] args)
        {
            ListaDeContaCorrente listaContaCorrente = new ListaDeContaCorrente();

            ContaCorrente danilo = new ContaCorrente(1, 1006);
            
            listaContaCorrente.AddAll(
                danilo, 
                new ContaCorrente(2, 1006),
                new ContaCorrente(2, 1006),
                new ContaCorrente(3, 1006),
                new ContaCorrente(4, 1006),
                new ContaCorrente(5, 1006),
                new ContaCorrente(6, 1006)
            );

            for (int i = 0; i < listaContaCorrente.getSizeArray; i++)
            {
                ContaCorrente conta = listaContaCorrente[i];
                System.Console.WriteLine($"Conta na posição {i} Conta: {conta.Numero} / Agencia: {conta.Agencia}.");
            }

            Console.WriteLine($"Tamanho do Array: {listaContaCorrente.getIndexSize()}");
        }

        private static void ApagarContasCorrente(ListaDeContaCorrente listaContaCorrente, ContaCorrente danilo)
        {
            listaContaCorrente.PrintContaCorrente();
            System.Console.WriteLine("Apagar");
            listaContaCorrente.Remove(danilo);
            listaContaCorrente.PrintContaCorrente();
        }

        private static void ApgandoConta(){

        }

        private static void CriadoArrays()
        {
            int[] idades = new int[]{
                1,
                2,
                3,
                4,
                5
            };

            int somaIdade = 0;

            for (int indice = 0; indice <= idades.Length; indice++)
            {
                Console.WriteLine($"Indice na possisão {indice}: idade {idades[indice]} ");
                somaIdade += idades[indice];
            }
            Console.WriteLine($"A medida de idade é: {somaIdade / idades.Length}");
        }

        private static int[] ArrayDeInt()
        {
            int[] idades = new int[5];
            idades[0] = 1;
            idades[1] = 2;
            idades[2] = 3;
            idades[3] = 4;
            idades[4] = 5;
            return idades;
        }

        private static void ManipulacaoDeString(){
                        string textFirst = "Hey, my number is 967023470.";
            string textSecond = "Hellow, the number of smartphone 67023470 is her.";
            string textFinally = "96702-3470, It's number of my smartphone.";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";

            Match matchFirst = Regex.Match(textFirst, padrao);
            Match matchSecond = Regex.Match(textSecond, padrao);
            Match matchFinally = Regex.Match(textFinally, padrao);

            Console.WriteLine(String.Format("Firt number {0}, second number {1}, finally number {2}.", matchFirst.Value.ToString(), matchSecond.Value.ToString(), matchFinally.Value.ToString()));
        }

        private static void LerArquivo()
        {
            // 1: Escreve um linha para o novo arquivo
            using (StreamWriter writer = new StreamWriter("C:\\Danilo\\macoratti.txt", true))
            {
                writer.WriteLine("Danilo2");
            }
            // 2: Anexa uma linha ao arquivo
            using (StreamWriter writer = new StreamWriter(@"C:\\Danilo\macoratti.txt", true))
            {
                writer.WriteLine("Beleza4");
            }
        }

        private static void TestePontoVirgula () {
            string mePage = null;;
            int cookPage;

            int.TryParse (mePage, out cookPage);
            if (cookPage == 0)
                cookPage = 1;

            Console.Write (cookPage);
            if (0 == 1)
                GerenciamentoBoleto ();

            if (0 == 1)
                GerenciamentoConta ();
        }

        private static void GerenciamentoBoleto () {
            Thread.CurrentThread.CurrentCulture = new CultureInfo ("en-US", false);
            DateTime dataFim = new DateTime (2019, 02, 23);
            DateTime dataNow = DateTime.Now;
            TimeSpan diferencaData = dataNow - dataFim;
            String mensagem = "A fatura vence em " + TimeSpanHumanizeExtensions.Humanize (diferencaData, 1, new CultureInfo ("pt-BR", false));
            Console.WriteLine (mensagem);
        }

        private static void GerenciamentoConta () {
            ContaCorrente conta = new ContaCorrente (123, 123);
            conta.Saldo = 100;
            conta.Sacar (10);
            Console.WriteLine (conta.Saldo);
        }
    }
}