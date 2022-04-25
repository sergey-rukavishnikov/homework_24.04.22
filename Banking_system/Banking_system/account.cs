using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_system
{
    class account
    {
        private string _Owner;
        private DateTime _Open;
        private DateTime _Close;
        private double _Interest;
        private double _StartAmount;
        private double _EndAmount
        {
            get
            {
                DateTime dt = DateTime.Now;
                TimeSpan ts = dt - _Open;
                return (_StartAmount * Math.Pow(_Interest, ((double)ts.TotalDays) / 30));
            }
        }
        public string Owner
        {
            get
            {
                return _Owner;
            }
            private set
            {
                if (String.Compare(value, "0") > 0)
                {
                    _Owner = value;
                }
                else
                {
                    _Owner = "Owner";
                }
            }
        }
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
        public account()
        {
            Owner = "Owner";
            Amount = 0;
            Interest = 0;
            Open = new System.DateTime(
                                1999, 1, 13, 3, 57, 32, 11);
            Close = new System.DateTime(
                                1999, 1, 13, 3, 57, 32, 11);

        }
        public void TakeLoan(string owner, double amount, double interest)
        {
            Owner = owner;
            Amount = amount;
            Interest = interest;
            Open = DateTime.Now;
        }
        public void OpenDebit(string owner, double amount)
        {
            Owner = "Owner";
            Amount = amount;
            Open = DateTime.Now;
        }
        public double TakeMoney(double sum)
        {
            if((Open - Close).TotalSeconds > 0)
            {
                if (Interest == 0)
                {
                    if (sum > Amount)
                    {
                        Console.WriteLine("Не хватает денег на счёте");
                        return 0;
                    }
                    else
                    {
                        Amount -= sum;
                        return sum;
                    }
                }
                else
                {
                    Amount += sum;
                    return sum;
                }
            }
            else
            {
                Console.WriteLine("У вас нет счёта");
                return 0;
            }
            
        }
        public double PutMoney(double sum)
        {
            if((Open - Close).TotalSeconds > 0)
            {
                if (Interest > 0)
                {
                    if (sum > Amount)
                    {
                        Console.WriteLine("Слишком большая сумма");
                        return 0;
                    }
                    else
                    {
                        Amount -= sum;
                        return sum;
                    }
                }
                else
                {
                    Amount += sum;
                    return sum;
                }
            }
            else
            {
                Console.WriteLine("У вас нет счёта");
                return 0;
            }
        }
        public double close()
        {
            double TempAmount;
            if((Open - Close).TotalSeconds > 0)
            {
                double FinalAmount = Amount;
                if (Interest > 0 && Amount > 0)
                {
                    Console.WriteLine($"Чтобы погасить кредит внесите {Amount} рублей");
                    return 0;
                }
                else
                {
                    TempAmount = Amount;
                    Owner = "Owner";
                    Close = DateTime.Now;
                    Amount = 0;
                    Interest = 0;
                    return TempAmount;
                }
            }
            else
            {
                Console.WriteLine("У вас нет счёта");
                return 0;
            }
            
        }
    }
}
