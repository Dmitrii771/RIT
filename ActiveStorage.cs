using RIT.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIT
{
    class ActiveStorage : IActiveStorage
    {
        private List<Active> actives; 

        public ActiveStorage()
        {
            actives = new List<Active>();
        }

        public void ShowAll()
        {
            for(var i = 0; i < actives.Count; i++)
            {
                Console.WriteLine((i + 1).ToString() + ". " + actives[i].ToString());
            }
        }
        public void AddActive()
        {
            CreateMonetaryActive();
        }
        public void DeleteActive()
        {
            ShowAll();
            Console.Write("Введите номер удаляемой записи: ");
            int number = Int32.Parse(Console.ReadLine());
            actives.RemoveAt(number - 1);
        }
        public void EditActive()
        {
            ShowAll();
            throw new NotImplementedException();
        }

        private void CreateMonetaryActive()
        {
            Console.Write("Название: ");
            string name = Console.ReadLine();
            var active = new MonetaryActive(name, "", "");
            actives.Add(active);
        }

        private void CreateNonMonetaryActive()
        {
            var active = new NonMonetaryActive("", "");
            actives.Add(active);
        }

    }
}
