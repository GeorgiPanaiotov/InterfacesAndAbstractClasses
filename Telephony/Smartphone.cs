using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : ISmartphone
    {
        public void Browsing()
        {
            string[] sites = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < sites.Length; i++)
            {
                if(sites[i].Contains('0') || sites[i].Contains('1') || sites[i].Contains('2') || sites[i].Contains('3')
                    || sites[i].Contains('4') || sites[i].Contains('5') || sites[i].Contains('6') || sites[i].Contains('7')
                    || sites[i].Contains('8') || sites[i].Contains('9'))
                {
                    Console.WriteLine("Invalid URL!");
                }
                else
                {
                    Console.WriteLine($"Browsing: {sites[i]}!");
                }
            }
        }

        public void Calling()
        {
            string[] numbers = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isNumber = false;
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    if (numbers[i][j] > 47 && numbers[i][j] < 58)
                    {
                        isNumber = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid number!");
                        isNumber = false;
                        break;
                    }
                }
                if (isNumber)
                {
                    if (numbers[i].Length == 10)
                    {
                        Console.WriteLine($"Calling... {numbers[i]}");
                    }
                    else if (numbers[i].Length < 10)
                    {
                        IStationaryphone stationaryphone = new Stationaryphone();
                        stationaryphone.Calling();
                        Console.WriteLine($"Dialing... {numbers[i]}");
                    }
                }
            }
        }
    }
}
