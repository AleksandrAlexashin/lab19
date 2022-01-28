using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Model> models = new List<Model>()
            {
                new Model(){Kod = 1, Title="Asus", CPU="Intel Pentium",Frequency=2.4, RAM =4, 
                            HDD=1024, VGA=2048, Price=250,Quantity=10}, 
                new Model(){Kod = 2, Title="Acer", CPU="Intel Core i3",Frequency=3.2, RAM =8, 
                            HDD=2048, VGA=4096, Price=500,Quantity=15}, 
                new Model(){Kod = 3, Title="Dell", CPU="Intel Core i3",Frequency=3.6, RAM =6, 
                            HDD=512, VGA=2048, Price=450,Quantity=30}, 
                new Model(){Kod = 4, Title="Asus", CPU="AMD Ryzen",Frequency=2, RAM =4, 
                            HDD=512, VGA=2048, Price=200,Quantity=40}, 
                new Model(){Kod = 5, Title="Acer", CPU="Intel Core i7",Frequency=4, RAM =16, 
                            HDD=1024, VGA=8192, Price=600,Quantity=5},
                new Model(){Kod = 6, Title="Asus", CPU="AMD Ryzen",Frequency=3, RAM =4, 
                            HDD=512, VGA=1024, Price=235,Quantity=25}, 
                new Model(){Kod = 7, Title="Dell", CPU="Intel Pentium",Frequency=1.4, RAM =4, 
                            HDD=512, VGA=1024, Price=150,Quantity=50}, 
                new Model(){Kod = 8, Title="Apple", CPU="Intel Core i5",Frequency=3.5, RAM =32, 
                            HDD=2048, VGA=16384, Price=1500,Quantity=4}, 

            };

            Console.WriteLine("Введите название процессора");
            string cpu = Console.ReadLine();
            List<Model> models1 = models.Where(x => x.CPU == cpu).ToList();
            Print(models1);

            Console.WriteLine("Введите объем ОЗУ в Гбайтах");
            int ram = Convert.ToInt32(Console.ReadLine());
            List<Model> models2 = models.Where(x => x.RAM >= ram).ToList();
            Print(models2);

            Console.WriteLine("Список по возрастанию цены");

            List<Model> models3 = models.OrderBy(x => x.Price).ToList();
            Print(models3);
                     

            Model models5 = models.OrderByDescending(x => x.Price).FirstOrDefault();
            Model models6 = models.OrderBy(x => x.Price).FirstOrDefault();
            
            Console.WriteLine("Самый дорогой компьютер");
            Console.WriteLine($"{models5.Kod} {models5.Title} {models5.CPU} {models5.Frequency} {models5.RAM} " +
                $"{models5.HDD} {models5.VGA} {models5.Price} {models5.Quantity}");
            Console.WriteLine("Самый бюджетный компьютер");
             Console.WriteLine($"{models6.Kod} {models6.Title} {models6.CPU} {models6.Frequency} {models6.RAM}" +
                 $" {models6.HDD} {models6.VGA} {models6.Price} {models6.Quantity}");
            Console.Write("Компьютеры в наличии более 30 штук: ");
            if (models.Any(x => x.Quantity > 30) == true)
                Console.WriteLine("есть в наличии");
            else
                Console.WriteLine("нет в наличии");
                                   
            Console.ReadKey();

        }

        static void Print(List<Model> models)
        {
            foreach (Model e in models)
            {
                Console.WriteLine($"{e.Kod} {e.Title} {e.CPU} {e.Frequency} {e.RAM} {e.HDD} {e.VGA} {e.Price} {e.Quantity}");
               
            }
            Console.WriteLine();
        }
      

    }
}
