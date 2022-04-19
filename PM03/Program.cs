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
        public string GetName()
        {
            return Name;
        }
        public string GetManufacter()
        {
            return Manufacturer;
        }
        public int GetPrice()
        {
            return Price;
        }
        public App(string Name_, string Manufacter_, int Price_)
        {
            SetName(Name_);
            SetManufacter(Manufacter_);
            SetPrice(Price_);
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
