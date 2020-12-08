using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<string> people = new List<string>();


            string[] commands = Console.ReadLine().Split(' ').ToArray();
            while (commands[0] != "End")
            {
                if (commands[0] == "Citizen")
                {
                    Inhabitants inhabitant = new Citizen(commands[1], int.Parse(commands[2]), commands[3], commands[4]);
                    people.Add(inhabitant.Birthdate);
                }
                else if(commands[0] == "Robot")
                {
                    Inhabitants inhabitant = new Robot(commands[0], commands[1]);
                }
                else
                {
                    Inhabitants inhabitant = new Pets(commands[1], commands[2]);
                    people.Add(inhabitant.Birthdate);
                }
                commands = Console.ReadLine().Split(' ').ToArray();
            }

            string year = Console.ReadLine();
            Queue<string> years = new Queue<string>();
            for (int i = 0; i < people.Count; i++)
            {
                int lastNums = people[i].Length - year.Length;
                string last = String.Empty;
                for (int j = lastNums; j < people[i].Length; j++)
                {
                    last += people[i][j];
                }
                if(last == year)
                {
                    years.Enqueue(people[i]);
                }

            }
            while(years.Count != 0)
            {
                Console.WriteLine(years.Dequeue());
            }
        }
    }
}
