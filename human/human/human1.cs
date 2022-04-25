using System;
using System.Collections.Generic;
using System.Text;

namespace human
{
    class human1
    {
        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                if (String.Compare(value, "0") >= 0)
                    _FirstName = value;
                else
                    _FirstName = "FirstName";
            }
        }
        private string _FirstName;
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                if (String.Compare(value, "0")! < 0)
                    _LastName = value;
                else _LastName = "LastName";
            }
        }
        private String _LastName;


        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value > 1900 && value < 2018)
                    _year = value;
                else
                    _year = 1900;
            }

        }
        private int _year;

        public int Month
        {
            private get
            {
                return _Month;
            }
            set
            {
                if (value > 1 && value < 12)
                    _Month = value;
                else _Month = 1;
            }

        }
        private int _Month;
        public int Day
        {
            private get
            {
                return _Day;
            }
            set
            {
                if (value > 1 && value < 31)
                    _Day = value;
                else _Day = 1;
            }

        }
        private int _Day;


        public human1()
        {
            FirstName = "FirstName";
            LastName = "LastName";
            Year = 1900;
            Month = 1;
            Day = 1;

        }
        public human1(string firstName, string lastName, int yaer, int month, int day)
        {
            FirstName = firstName;
            LastName = lastName;

            Year = yaer;
            Month = month;
            Day = day;

        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
        public int GetAge()
        {
            DateTime dateTime = DateTime.Now;
            DateTime birthday = new DateTime(
                                Year, Month, Day);
            System.TimeSpan interval = dateTime.Subtract(birthday);
            return (int)(interval.TotalDays / 365.25);

        }
    }
}
