using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB5
{
    class History
    {
        internal String Operation;
        internal DateTime Date;
        internal int Amount;

        public History(String Operation, int Amount, DateTime Date)
        {
            this.Operation = Operation;
            this.Date = Date;
            this.Amount = Amount;
        }
    }
}
