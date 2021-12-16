﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1112
{
    public class DeveloperInfoAttribute : System.Attribute
    {
        public string Name { get; set; }
        public string  dateTime { get; set; }
        public DeveloperInfoAttribute() { }
        public DeveloperInfoAttribute(string Name, string dateTime)
        {
            this.Name = Name;
            this.dateTime = dateTime;
        }
    }
}
