using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        
        public Seat(string first, string second)
        {
            Model = first;
            Color = second;
        }
        public string Model { get; set; }
        public string Color { get; set; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }
        public override string ToString()
        {
            return $"{this.Color} Seat {this.Model}" + "\n" + $"{this.Start()}" + "\n" + $"{this.Stop()}";
        }
    }
}
