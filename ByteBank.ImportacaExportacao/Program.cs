using System;
using System.IO;
using System.Text;

namespace ByteBank.ImportacaExportacao
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var addressFile = @"C:\Users\danil\source\repos\ByteBank-core\ByteBank.ImportacaExportacao\Persistence\contas.txt";

            using (var flowByFile = new FileStream(path: addressFile, mode: FileMode.Open))
            using (var readerFile = new StreamReader(flowByFile))
            {
                while (!readerFile.EndOfStream)
                {
                    var value = readerFile.ReadLine();
                    System.Console.WriteLine(value);
                }
            }
        }
    }
}
