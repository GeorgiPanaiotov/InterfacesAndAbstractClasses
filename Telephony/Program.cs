using System;

namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            ISmartphone smartphone = new Smartphone();
            smartphone.Calling();
            smartphone.Browsing();
        }
    }
}
