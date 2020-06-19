using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB5
{
    class Program
    {
        static void Main(string[] args)
        {
            Wallet wallet = new Wallet();

            Console.Write(new string('-', 10));
            Console.Write("Проверка RUB");
            Console.Write(new string('-', 10));
            Console.WriteLine("");

            wallet.createAcct("RUB", 1000);
            wallet.getMoney("RUB");
            wallet.addMoney("RUB", 100);
            wallet.getMoney("RUB");
            wallet.removeMoney("RUB", 200);
            wallet.getMoney("RUB");

            Console.WriteLine("");
            Console.Write(new string('-', 10));
            Console.Write("Проверка RUB завершена");
            Console.Write(new string('-', 10));
            Console.WriteLine("");
            Console.Write(new string('-', 10));
            Console.Write("Проверка остальных функций");
            Console.Write(new string('-', 10));
            Console.WriteLine("");

            wallet.createAcct("USD", 100);
            wallet.createAcct("EUR", 100);
            wallet.addMoney("USD", 100);
            wallet.getMoney("USD");
            wallet.print();
            wallet.print("Счёт USD пополнен: ", 20);
            wallet.toString();
            wallet.Convert(200, "EUR", "RUB");

            Console.WriteLine("");
            wallet.getTotalMoney("RUB");

            Console.WriteLine("");
            Console.Write(new string('-', 10));
            Console.Write("Завершение");
            Console.Write(new string('-', 10));
            Console.WriteLine("");

            Console.ReadLine();
        }
    }
}
