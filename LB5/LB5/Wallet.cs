using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB5
{
    public class Wallet
    {
        List<Currency> wallet = new List<Currency>();
        Bank bank = new Bank();
        MoneyPrinter money = new MoneyPrinter();

        public void createAcct(string valuta, int value) 
        {
            wallet.Add(new Currency(valuta, value));
            money.addHistory("Создан счёт: " + valuta + " с балансом: ", 0);
        }

        public void addMoney(string valut, int value)
        {
            for (int i = 0; i < wallet.Count(); i++)
            {
                int count = 0;

                if (wallet[i].valuta.Contains(valut))
                {
                    wallet[i].addMoney(value);
                    Console.WriteLine("Пополенен счёт: " + valut + " на сумму: " + value.ToString());
                    money.addHistory("Счёт " + valut + " пополнен: ", value);
                }
                else if (count > 0)
                {
                    Console.WriteLine(valut + ": 0");
                }
                else
                {
                    count++;
                }
            }
        }

        public void removeMoney(string valut, int value)
        {
            int count = 0;
            for (int i = 0; i < wallet.Count(); i++)
            {
                if (wallet[i].valuta.Contains(valut))
                {
                    wallet[i].removeMoney(value);
                    Console.WriteLine("Списано с счёта: " + valut + " на сумму: " + value.ToString());
                    money.addHistory("С счёта " + valut + " списано: ", value);
                }
                else if (count > 0)
                {
                    Console.WriteLine(valut + ":" + value.ToString());
                }
                else
                {
                    count++;
                }
            }
        }

        public int getMoney(string valuta)
        {

            int count = 0;
            for (int i = 0; i < wallet.Count(); i++)
            {
                if (wallet[i].valuta.Contains(valuta))
                {
                    wallet[i].getMoney();
                    Console.WriteLine("Баланс " + valuta + " счёта: " + wallet[i].getMoney());
                    return wallet[i].getMoney();
                }
            }

            return 0;

        }

        public string toString()
        {
            int count = 0;
            string writter = "Cодержание всех счетов: { ";
            Console.Write("Cодержание всех счетов: { ");
            for (int i = 0; i < wallet.Count(); i++)
            {
                if (i < wallet.Count() - 1)
                {
                    Console.Write(wallet[i].getMoney() + " " + wallet[i].valuta + ", ");
                    writter += wallet[i].getMoney() + " " + wallet[i].valuta + ", ";
                }
                else
                {
                    Console.Write(wallet[i].getMoney() + " " + wallet[i].valuta);
                    writter += wallet[i].getMoney() + " " + wallet[i].valuta;
                }
            }
            Console.Write(" }");
            writter += " }";
            Console.WriteLine("");
            return writter;
        }

        public void getTotalMoney(String valuta)
        {
            double sum = 0;
            for (int i = 0; i < wallet.Count(); i++)
            {
                if (wallet[i].valuta != valuta)
                    sum += bank.getTotalMoney(valuta, wallet[i].valuta, wallet[i].getMoney());
                else if (wallet[i].valuta == valuta)
                    sum += wallet[i].getMoney();
            }
            Console.WriteLine("Общий баланс всех счетов в валюте: " + valuta + " Составляет: " + sum);
        }

        public void Convert(int value, string valuta, string valuta2)
        {
            double sum = 0;
            sum += bank.Convert(valuta, valuta2, value);
            Console.WriteLine("Перевод в валюту: " + valuta + " Составляет: " + sum);
        }

        public void print()
        {
            money.print();
        }

        public void print(string operation, int amount)
        {
            money.print(operation, amount);
        }


    }
}
