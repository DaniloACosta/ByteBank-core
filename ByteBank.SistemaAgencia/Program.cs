using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Comparators;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>(){
                new ContaCorrente(456, 159),
                new ContaCorrente(453, 259),
                null,
                new ContaCorrente(123, 753),
                null,
                new ContaCorrente(354, 523)
            };
            
            IOrderedEnumerable<ContaCorrente> listOrder = contas
                .Where(conta => conta != null)
                .OrderBy(conta => conta.Numero);

            foreach (var item in listOrder)
            {
                Console.WriteLine($"Numero. {item.Numero} Ag. {item.Agencia}");
            }
        }

        private static void MethodSort(List<ContaCorrente> contas)
        {
            contas.Sort(new ComparatorsContaCorrenteByAgencia());
        }

        private static void CriandoConta()
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
