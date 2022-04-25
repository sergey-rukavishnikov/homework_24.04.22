using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            human1 w = new human1();
            w.Day = 25;
            w.Month = 4;
            w.Year = 1999;
            Console.Write(w.GetAge());
        }
    }
}
