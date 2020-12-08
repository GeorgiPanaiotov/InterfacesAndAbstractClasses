using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen : Inhabitants
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }
    }
}
