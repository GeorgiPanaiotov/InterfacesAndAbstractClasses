using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Pets : Inhabitants
    {
        public Pets(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }
    }
}
