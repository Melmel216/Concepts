﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltungssystem
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

        internal int Drive(int drivenKm)
        {
            int newMileage = drivenKm + Mileage;
            return newMileage;
        }

        //internal void Drive(int drivenMiles)
        //{
        //  Mileage += drivenMiles;     (oder: Mileage = Mileage + drivenMiles)
        //}
        // Aufruf dann car1.Drive(50);  -> weil 50 km gefahren

        internal int Age()
        {
            int carAge = DateTime.Now.Year - Year;   //besser:  
            return carAge;                  //return DateTime.Now.Year - Year
        }

    }
}
