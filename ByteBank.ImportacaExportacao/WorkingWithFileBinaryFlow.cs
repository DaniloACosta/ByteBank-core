using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using ByteBank.ImportacaExportacao.Models;

namespace ByteBank.ImportacaExportacao
{
    partial class Program
    {
        static void WritingBinary()
        {
            var addressFile = @"C:\Users\danil\source\repos\ByteBank-core\ByteBank.ImportacaExportacao\Persistence\binary.txt";

            using (var fileBinary = new FileStream(addressFile, FileMode.Create))
            using (var writingBinary = new BinaryWriter(fileBinary))
            {
                writingBinary.Write(456);
                writingBinary.Write(546544);
                writingBinary.Write(4000.50);
                writingBinary.Write("Danilo Alves");
            }
        }

        static void ReadingBinary()
        {
            var addressFile = @"C:\Users\danil\source\repos\ByteBank-core\ByteBank.ImportacaExportacao\Persistence\binary.txt";
            using (var fileBinary = new FileStream(addressFile, FileMode.Open))
            using (var readingBinary = new BinaryReader(fileBinary))
            {
                var branch = readingBinary.ReadInt32();
                var number = readingBinary.ReadInt32();
                var balance = readingBinary.ReadDouble();
                var name = readingBinary.ReadString();

                System.Console.WriteLine($"{branch} / {number} | {balance} | {name}");
            }
        }
    }
}
