using System;
using System.Linq;

namespace AppDemo
{
   
    
        class Program
        {
            public static void Main(string[] args)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    
                    Console.WriteLine("Объекты успешно сохранены");
                    // получаем объекты из бд и выводим на консоль
                    
                }
                Console.Read();
            }
        }
    
}
