using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robot : Inhabitants
    {
        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }
    }
}
