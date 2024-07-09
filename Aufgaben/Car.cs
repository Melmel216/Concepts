﻿using System.Runtime.CompilerServices;

namespace Aufgaben
{
    internal class Car
    {
        //Properties
        internal string Brand { get; set; }
        internal string Model { get; set; }
        internal int Year { get; set; }
        internal int Mileage { get; set; }

        //Konstruktor

        public Car(string brand, string model, int year, int mileage)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
        }

        //Methoden

        internal string GetDescription()
        {
            return $"{Brand} {Model}, Jahr {Year} mit {Mileage} km gefahren.";
        }

        internal int Drive(int drivenkm)
        {
            int newMileage = drivenkm + Mileage;
            return newMileage;
        }

        internal int Age()
        {
            int carAge = DateTime.Now.Year - Year;
            return carAge;
        }

    }
}