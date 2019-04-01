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
<<<<<<< HEAD
            string url = "moedaOrigem=real&moedaDestino=dolar";
=======
            int[] idades = new int[]{
                1,
                2,
                3,
                4,
                5
            };

            int somaIdade = 0;

            for (int indice = 0; indice < idades.Length; indice++)
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
>>>>>>> a3faf46... Array primeira aula

            ExtratorValorDeArgumentosURL extrairURl = new ExtratorValorDeArgumentosURL(url);

            Console.WriteLine(extrairURl.getValor("moedaOrigem"));

            //Console.WriteLine(url.Substring(url.IndexOf("?")+1));

            
        }

        private static void TrabalhandoComHora()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", false);
            DateTime dataFim = new DateTime(2019, 02, 23);
            DateTime dataNow = DateTime.Now;
            TimeSpan diferencaData = dataNow - dataFim;
            String mensagem = "A fatura vence em " + TimeSpanHumanizeExtensions.Humanize(diferencaData, 1, new CultureInfo("es-MX", false));
            Console.WriteLine(mensagem);

            if (0 == 1)
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
