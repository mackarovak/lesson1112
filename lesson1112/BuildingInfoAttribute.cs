using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1112
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class BuildingInfoAttribute : System.Attribute
    {
        public string Name { get; private set; }
        public string Organization { get; private set; }
        public BuildingInfoAttribute() { }
        public BuildingInfoAttribute(string Name, string Organization)
        {
            this.Name = Name;
            this.Organization = Organization;
        }
    }
}
