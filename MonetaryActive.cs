using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIT
{
    class MonetaryActive : Active
    {

        public string Bank { get; set; }
        public MonetaryActive(string name, string type, string bank)
            : base(name, type)
        {
            Bank = bank;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
