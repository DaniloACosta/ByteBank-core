using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using System;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(123, 123);
            Console.Write(conta.Numero);
            Console.ReadLine();
            
            GerenteDeConta gerente = new GerenteDeConta("123.456.789-60");

            gerente.Senha = "123";
            System.Console.WriteLine(gerente.Autenticar("123"));
        }
    }
}
