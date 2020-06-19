using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB5
{
    public class MoneyPrinter
    {
        List<History> history = new List<History>();

        public MoneyPrinter()
        {
        }

        public void addHistory(String operation, int Amount)
        {
            history.Add(new History(operation, Amount, DateTime.Now));
        }

        public void print()
        {
            Console.WriteLine("История:");
            for (int i = 0; i < history.Count(); i++)
            {
                Console.WriteLine("Операция: " + history[i].Operation + history[i].Amount.ToString() + " |Дата: " + history[i].Date);
            }
            Console.WriteLine("История закончина");
        }

        public void print(String operation, int amount)
        {
            int count = amount;
            Console.WriteLine("История:");

            if (amount > count)
            {
                count = history.Count();
            }

            for (int i = 0; i < history.Count(); i++)
            {
                if (operation == history[i].Operation)
                    Console.WriteLine("Операция: " + history[i].Operation + history[i].Amount.ToString() + " |Дата: " + history[i].Date);
            }
            Console.WriteLine("История закончина");
        }

    }
}
