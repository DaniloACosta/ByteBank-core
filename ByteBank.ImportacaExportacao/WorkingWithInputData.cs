using System;
using System.IO;

namespace ByteBank.ImportacaExportacao
{
    partial class Program
    {
        static void UseStreamInput(){
            var addressFile = @"C:\Users\danil\source\repos\ByteBank-core\ByteBank.ImportacaExportacao\Persistence\Console.txt";

            using (var fileConsole = Console.OpenStandardInput())
            using(var fileStrean = new FileStream(addressFile, FileMode.Create))
            {
                var buffer = new byte[1024];
                var exit = true;
                while(exit){
                    var byteRead = fileConsole.Read(buffer, 0, 1024);
                    fileStrean.Write(buffer);
                    fileConsole.Flush();
                    Console.WriteLine($"Amount of byte: {byteRead}");
                    if(byteRead == 2)
                        exit = false;
                }
            }
        }
    }
}