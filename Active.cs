using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIT
{
    abstract class Active
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public Active(string name, string type)
        {
            Name = name;
            Type = type;
        }


    }
}
