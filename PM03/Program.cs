using System;
using System.IO;
using System.Linq;
using System.Text;

namespace PM03
{
    public class App
    {
        public string Name;
        public string Manufacturer;
        public int Price;
        
        public App()
        {
        }
        public void SortBub(App[] Apps)
        {
            //App Temp = new App();
            //for (int j = 0; j <Apps.Length; j++)
            //    for (int i = 0; i < Apps.Length - 1; i++)
            //    {

            //        if (Apps[i].Price < Apps[i + 1].Price)
            //        {
            //            Temp = Apps[i];
            //            Apps[i] = Apps[i + 1];
            //            Apps[i + 1] = Temp;
            //        }
            //    }
        }
        public void SaveFile(App[] Apps)
        {
            StreamWriter sw = new StreamWriter(new FileStream("..\\Test.txt", FileMode.Append, FileAccess.Write));
            sw.WriteLine("Было выполнено: " + DateTime.Now);
            for (int i = 0; i < Apps.Length; i++)
            {
                sw.WriteLine((i+1) + "программа.");
                sw.WriteLine("Название программы" + Apps[i].Name);
                sw.WriteLine("Производитель программы" + Apps[i].Manufacturer);
                sw.WriteLine("Цена программы" + Apps[i].Manufacturer + " руб.");
            }
            sw.Close();
        }
    }
    public class Applications : App
    {
        public Applications(string Name_, string Manufacturer_, int Price_)
        {
            SetName(Name_);
            SetManufacter(Manufacturer_);
            SetPrice(Price_);
        }
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public void SetManufacter(string Manufacturer)
        {
            this.Manufacturer = Manufacturer;
        }
        public void SetPrice(int Price)
        {
            this.Price = Price;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            string SaveName = "";
            string SaveManufacturer = "";
            int SavePrice = 0;
            Console.WriteLine("Введите размер массива Apps = ");
            while  (!int.TryParse(Console.ReadLine(), out N))
            {
                Console.WriteLine("Ошибка ввода, попробуйте снова");
                
            }
            while (N < 1)
            {
                Console.WriteLine("Ошибка ввода, попробуйте снова");
                N = Convert.ToInt32(Console.ReadLine());
            }
            App[] Apps = new App[N];
            for (int i = 0; i<N;i++)
            {
                Console.WriteLine("Введите " + (i+1) + " продукт ");
                Console.WriteLine("Введите название программы: ");
                SaveName = Console.ReadLine();
                Console.WriteLine("Введите производителя программы: ");
                SaveManufacturer = Console.ReadLine();
                Console.WriteLine("Введите цену программы: ");
                while (!int.TryParse(Console.ReadLine(), out SavePrice))
                {
                    Console.WriteLine("Ошибка ввода цены, попробуйте снова");
                }
                while (SavePrice < 1)
                {
                    Console.WriteLine("Ошибка ввода цены, попробуйте снова");
                    SavePrice = Convert.ToInt32(Console.ReadLine());
                }
                Apps[i] = new Applications(SaveName, SaveManufacturer, SavePrice);
                Console.WriteLine();
            }
            for (int i = 0; i < N; i++)
            {
                Apps[i].SortBub(Apps);
            }
            Console.WriteLine("После сортировки");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine((i + 1) + " продукт ");
                Console.WriteLine("Название программы: "+ Apps[i].Name);
                Console.WriteLine("Производитель программы: " + Apps[i].Manufacturer);
                Console.WriteLine("Цена программы: " + Apps[i].Price);
            }
        }
    }
}
