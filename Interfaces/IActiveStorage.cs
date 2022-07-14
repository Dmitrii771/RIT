using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIT.Interfaces
{
    interface IActiveStorage
    {
        void ShowAll();
        void AddActive();
        void DeleteActive();
        void EditActive();
    }
}
