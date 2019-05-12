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
            var addressFile = @"C:\Users\danil\source\repos\ByteBank-core\ByteBank.ImportacaExportacao\Persistence\Account.csv";
            var MessageWrite = "53,0098,1000.20,Pedro";

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
