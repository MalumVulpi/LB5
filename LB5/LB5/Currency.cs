using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB5
{
    public class Currency
    {
        internal string valuta;
        int value;

        public Currency(string valuta, int value) 
        {
            this.valuta = valuta;
            this.value = value;
        }

        public void addMoney(int value) 
        {
            this.value += value;
        }

        public void removeMoney(int value)
        {
            if (this.value > value)
                this.value -= value;
            else
                Console.WriteLine("Недостаточно средств на счёте: " + valuta);
        }

        public int getMoney() 
        {
            return this.value;
        }
    }
}
