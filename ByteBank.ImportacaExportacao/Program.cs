using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using ByteBank.ImportacaExportacao.Models;

namespace ByteBank.ImportacaExportacao
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var nome = Console.ReadLine();
            Console.WriteLine(nome);
            var stringFile = File.ReadAllLines(@"C:\Users\danil\source\repos\ByteBank-core\ByteBank.ImportacaExportacao\Persistence\contas.txt");
            foreach (var item in stringFile)
            {
                Console.WriteLine(item);    
            }

            File.WriteAllText(@"C:\Users\danil\source\repos\ByteBank-core\ByteBank.ImportacaExportacao\Persistence\contas.txt", "My name is Danilo");
        }

        private static void WorkingStreamWithFlush()
        {
            var addressFile = @"C:\Users\danil\source\repos\ByteBank-core\ByteBank.ImportacaExportacao\Persistence\teste.txt";
            using (var flowByFile = new FileStream(addressFile, FileMode.Create))
            using (var writeFile = new StreamWriter(flowByFile))
            {
                for (int i = 0; i < 10; i++)
                {
                    var messageWrite = $"Linha {i}";
                    writeFile.WriteLine(messageWrite);
                    Console.WriteLine(messageWrite);
                    writeFile.Flush();
                    Console.ReadLine();
                }
            }
        }

        private static void WorkingWithFlush()
        {
            var addressFile = @"C:\Users\danil\source\repos\ByteBank-core\ByteBank.ImportacaExportacao\Persistence\teste.txt";
            using (var flowByFile = new FileStream(addressFile, FileMode.Create))
            {
                for (int i = 0; i < 10; i++)
                {
                    var messageWrite = $"Linha {i} \n";
                    var encodingUTF8 = new UTF8Encoding();
                    var buffer = encodingUTF8.GetBytes(messageWrite);

                    flowByFile.Write(buffer, 0, buffer.Length);
                    //flowByFile.Flush();
                    Console.WriteLine(messageWrite);
                    Console.ReadLine();
                }
            }
        }

        private static void WorkingStreamWithStream()
        {
            var addressFile = @"C:\Users\danil\source\repos\ByteBank-core\ByteBank.ImportacaExportacao\Persistence\Account.csv";
            var MessageWrite = "53,0098;1000.20;Pedro";

            using (var flowByFile = new FileStream(addressFile, FileMode.Create))
            using (var writeFile = new StreamWriter(flowByFile))
            {
                writeFile.Write(MessageWrite);
            }
        }

        private static void WorkingStreamWithByte()
        {
            var addressFile = @"C:\Users\danil\source\repos\ByteBank-core\ByteBank.ImportacaExportacao\Persistence\Account.csv";
            var MessageWrite = "453,0088,1000.13,Danilo";
            using (var flowByFile = new FileStream(addressFile, FileMode.Create))
            {
                UTF8Encoding typeEncoder = new UTF8Encoding();
                byte[] buffer = typeEncoder.GetBytes(MessageWrite);
                flowByFile.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
