using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_system
{
    class transaction
    {
        private string _Addressee;
        private string _Destination;
        private double _Sum;
        public string Addressee
        {
            get
            {
                return _Addressee;
            }
            private set
            {
                if (String.Compare(value, "0") > 0)
                {
                    _Addressee = value;
                }
                else
                {
                    _Addressee = "Addressee";
                }
            }
        }
        public string Destination
        {
            get
            {
                return _Destination;
            }
            private set
            {
                if (String.Compare(value, "0") > 0)
                {
                    _Destination = value;
                }
                else
                {
                    _Destination = "Destination";
                }
            }
        }
        public double Sum
        {
            get
            {
                return _Sum;
            }
            private set
            {
                if(value > 0)
                {
                    _Sum = value;
                }
                else
                {
                    _Sum = 0;
                }
            }
        }
        public transaction()
        {
            Addressee = "Addressee";
            Destination = "Destination";
            Sum = 0;
        }
        public void SendMoney(double sum, account addresse, account destination)
        {
            Addressee = addresse.Owner;
            Destination = destination.Owner;
            Sum = sum;
            if (addresse.TakeMoney(sum) > 0)
            {
                if(destination.PutMoney(sum) > 0)
                {
                    Console.WriteLine($"Отправлено {sum} рублей");
                }
                else
                {
                    Console.WriteLine($"{Destination} не может получить деньги");
                }

            }
            else
            {
                Console.WriteLine($"{Addressee} не может отправить деньги");
            }
        }
    }

}
