using System;

namespace RIT
{
    class Program
    {
        static void Main(string[] args)
        {
            var storage = new ActiveStorage();
            int a = 0;
            while (a != 5)
            {
                Console.WriteLine("1. Посмотреть записи");
                Console.WriteLine("2. Добавить запись");
                Console.WriteLine("3. Редактировать запись");
                Console.WriteLine("4. Удалить запись");
                Console.WriteLine("5. Закрыть");

                a = Int32.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        storage.ShowAll();
                        break;
                    case 2:
                        storage.AddActive();
                        break;
                    case 3:
                        storage.EditActive();
                        break;
                    case 4:
                        storage.DeleteActive();
                        break;
                    case 5:
                        break;
                }
            }
            
        }
    }
}
