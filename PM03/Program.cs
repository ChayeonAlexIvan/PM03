﻿using System;
using System.IO;
using System.Text;

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
        public App(string Name_, string Manufacturer_, int Price_)
        {
            SetName(Name_);
            SetManufacter(Manufacturer_);
            SetPrice(Price_);
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
            N = Convert.ToInt32(Console.ReadLine());
            App[] Apps = new App[N];
            for (int i = 1; i<N+1;i++)
            {
                Console.WriteLine("Введите " + i + " продукт ");
                Console.WriteLine("Введите название программы: ");
                SaveName = Console.ReadLine();
                Console.WriteLine("Введите производителя программы: ");
                SaveManufacturer = Console.ReadLine();
                Console.WriteLine("Введите цену программы: ");
                SavePrice = Convert.ToInt32(Console.ReadLine());
                Apps[i] = new App(SaveName, SaveManufacturer, SavePrice);
                Console.WriteLine();
            }
        }
    }
}
