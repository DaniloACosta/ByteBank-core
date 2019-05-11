using System;
using System.IO;
using System.Text;

namespace ByteBank.ImportacaExportacao
{
    partial class Program
    {
        private static void WorkingFileStreamDirectly()
        {
            var addressFile = @"C:\Users\danil\source\repos\ByteBank-core\ByteBank.ImportacaExportacao\Persistence\contas.txt";
            var buffer = new byte[1024]; //1Kb
            var AmountByteRead = -1;

            using (var flowByFile = new FileStream(path: addressFile, mode: FileMode.Open))
            {
                while (AmountByteRead != 0)
                {
                    AmountByteRead = flowByFile.Read(buffer, 0, 1024);
                    //System.Console.Write($"\nQuantidade de Byte lidos {AmountByteRead}\n");                    
                    WriteScreen(buffer, AmountByteRead);

                };
            }
        }

        public static void WriteScreen(byte[] buffer, int count)
        {
            var encoding = new UTF8Encoding();
            var text = encoding.GetString(bytes: buffer, index: 0, count: count);
            Console.Write(text);
        }
        
    }
}