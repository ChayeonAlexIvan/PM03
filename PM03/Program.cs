using System;

namespace PM03
{
    public class App
    {
        public string Name;
        public string Manufacturer;
        public int Price;
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
            Console.WriteLine("Hello World!");
        }
    }
}
