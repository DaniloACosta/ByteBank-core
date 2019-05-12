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
            var addressFile = @"C:\Users\danil\source\repos\ByteBank-core\ByteBank.ImportacaExportacao\Persistence\contas.txt";

            using (var flowByFile = new FileStream(path: addressFile, mode: FileMode.Open))
            using (var readerFile = new StreamReader(flowByFile))
            {
                while (!readerFile.EndOfStream)
                {
                    var value = readerFile.ReadLine();
                    // var accountsLine = ProcessBankAccounts(value);
                    var accountsLine = ProcessBankAccountsCSV(value); 
                    var msg = $"Name: {accountsLine.Title.Name}, Branch: {accountsLine.Branch}, Number: {accountsLine.Number}, Balance: {accountsLine.Balance}.";
                    System.Console.WriteLine(msg);
                }
            }
        }

        public static BankAccounts ProcessBankAccountsCSV(string line)
        {
            var splitAttribute = line.Split(',');
            int branch = int.Parse(splitAttribute[0]);
            int number = int.Parse(splitAttribute[1]);
            double balance = double.Parse(splitAttribute[2].Replace(".", ","));
            string name = splitAttribute[3];
            BankAccounts accounts = new BankAccounts(branch, number);
            accounts.Deposit(balance);
            ClientAccount client = new ClientAccount();
            client.Name = name;
            accounts.Title = client;
            return accounts;
        }

        public static BankAccounts ProcessBankAccounts(string line)
        {
            int branch = processBranch(line);
            int number = processNumber(line);
            double balance = procesBalance(line);
            string name = processName(line);
            BankAccounts accounts = new BankAccounts(branch, number);
            accounts.Deposit(balance);
            ClientAccount client = new ClientAccount();
            client.Name = name;
            accounts.Title = client;

            return accounts;
        }

        public static int processBranch(string line)
        {
            string pattern = "[0-9]{3}[ ]";
            Match result = Regex.Match(line, pattern);
            return int.Parse(result.Value);
        }
        public static int processNumber(string line)
        {
            string pattern = "[ ][0-9]{4}[ ]";
            Match result = Regex.Match(line, pattern);
            return int.Parse(result.Value);
        }
        public static double procesBalance(string line)
        {
            string pattern = @"[ ](\d*\.\d{2}){1}[ ]";
            Match result = Regex.Match(line, pattern);
            return double.Parse(result.Value.Replace(".", ","));
        }
        public static string processName(string line)
        {
            string pattern = @"[\s-]([A-Z][a-z]*)";
            Match result = Regex.Match(line, pattern);
            return result.Value;
        }
    }
}
