using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public abstract class Inhabitants
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string Model { get; set; }
        public string Birthdate { get; set; }
    }
}
