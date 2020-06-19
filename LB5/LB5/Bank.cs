using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB5
{
    public class Bank
    {

        Random rnd = new Random();


        //К рублю
        double USD_RUB = 60.3;
        double EUR_RUB = 68.3;

        //К доллару
        double RUB_USD = 0.014;
        double EUR_USD = 1.13;

        //К евро
        double USD_EUR = 0.89;
        double RUB_EUR = 0.01;

        //Рандомная валюта
        double other_other = 0.1;

        //К рандомной валюте проверка
        internal bool check = true;

        public double getTotalMoney(string InCurrency, string OutCurrency, int value)
        {
            double sum = 0;

            if (InCurrency.Contains("RUB"))
            {
                if (OutCurrency == "EUR")
                    sum = value * EUR_RUB;
                else if (OutCurrency == "USD")
                    sum = value * USD_RUB;
                else
                    sum = value * other_other;
            }

            else if (InCurrency.Contains("USD"))
            {
                if (OutCurrency == "EUR")
                    sum = value * EUR_USD;
                else if (OutCurrency == "RUB")
                    sum = value * RUB_USD;
                else
                    sum = value * other_other;
            }

            else if (InCurrency.Contains("EUR"))
            {
                if (OutCurrency == "RUB")
                    sum = value * RUB_EUR;
                else if (OutCurrency == "USD")
                    sum = value * USD_EUR;
                else
                    sum = value * other_other;
            }

            else
            {
                Console.WriteLine("Выберите другую валюту для возвращения");
                sum = 0;
                check = false;
                return sum;
            }

            return sum;
        }

        public double Convert(string InCurrency, string OutCurrency, int value)
        {
            double sum = 0;

            if (InCurrency.Contains("RUB"))
            {
                if (OutCurrency == "EUR")
                    sum = value * (EUR_RUB * (rnd.Next(1,5)));
                else if (OutCurrency == "USD")
                    sum = value * (USD_RUB * (rnd.Next(1,5)));
                else
                    sum = value * (other_other * (rnd.Next(1,5)));
            }

            else if (InCurrency.Contains("USD"))
            {
                if (OutCurrency == "EUR")
                    sum = value * (EUR_USD * (rnd.Next(1,5)));
                else if (OutCurrency == "RUB")
                    sum = value * (RUB_USD * (rnd.Next(1,5)));
                else
                    sum = value * (other_other * (rnd.Next(1,5)));
            }

            else if (InCurrency.Contains("EUR"))
            {
                if (OutCurrency == "RUB")
                    sum = value * (RUB_EUR * (rnd.Next(1,5)));
                else if (OutCurrency == "USD")
                    sum = value * (USD_EUR * (rnd.Next(1,5)));
                else
                    sum = value * (other_other * (rnd.Next(1,5)));
            }

            else
            {
                sum = value * other_other;
            }

            return sum;
        }

    }
}
