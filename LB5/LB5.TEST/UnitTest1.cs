using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LB5.TEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void createAcctWithBalance500()
        {
            Wallet wallet = new Wallet();
            wallet.createAcct("RUB", 500);

            int expected = 500;

            int result = wallet.getMoney("RUB");

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void addMoney500()
        {
            Wallet wallet = new Wallet();
            wallet.createAcct("RUB", 0);

            int expected = 500;

            wallet.addMoney("RUB", 500);

            int result = wallet.getMoney("RUB");

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void removeMoney500minus100()
        {
            Wallet wallet = new Wallet();
            wallet.createAcct("RUB", 500);

            int expected = 400;

            wallet.removeMoney("RUB", 100);

            int result = wallet.getMoney("RUB");

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void getMoneyRUB100()
        {
            Wallet wallet = new Wallet();

            wallet.createAcct("RUB", 100);

            int expected = 100;

            int result = wallet.getMoney("RUB");

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void toStringRUB100andUSD100()
        {
            Wallet wallet = new Wallet();

            wallet.createAcct("RUB", 100);
            wallet.createAcct("USD", 100);

            string expected = "Cодержание всех счётов: { 100 RUB, 100 USD }";

            string result = wallet.toString();

            Assert.AreEqual(expected, result);
        }


    }
}
