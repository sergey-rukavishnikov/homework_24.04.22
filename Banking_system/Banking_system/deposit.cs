using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_system
{
    class deposit
    {
        private DateTime _Open;
        private DateTime _Close;
        private double _EndAmount
        {
            get
            {
                DateTime dt = DateTime.Now;
                TimeSpan ts = dt - _Open;
                return (_StartAmount * Math.Pow(_Interest, ((double)ts.TotalDays) / 30));
            }
        }
        private double _StartAmount;
        private double _Interest;
        public DateTime Open { get; private set; }
        public DateTime Close { get; private set; }

        public double Amount
        {
            get
            {
                return _EndAmount;
            }
            private set
            {
                if (value > 0)
                    _StartAmount = value;
                else
                    _StartAmount = 0;
            }
        }
        
        public double Interest
        {
            get
            {
                return _Interest;
            }
            private set
            {
                if (value > 0)
                    _Interest = value;
                else
                    _Interest = 0;
            }
        }
        public deposit()
        {
            Amount = 0;
            Interest = 0;
            Open = new System.DateTime(
                                1999, 1, 13, 3, 57, 32, 11);
            Close = new System.DateTime(
                                1999, 1, 13, 3, 57, 32, 11); ;

        }
        
        public void open(double amount, double interest)
        {
            Amount = amount;
            Interest = interest;
            Open = DateTime.Now;
        }
        public double close()
        {
            if((Open - Close).TotalSeconds > 0)
            {
                double FinalAmount = Amount;
                Amount = 0;
                Interest = 0;
                Close = DateTime.Now;
                return FinalAmount;
            }
            else
            {
                Console.WriteLine("У вас нет вклада");
                return 0;
            }
        }
    }
}
