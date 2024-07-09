//Aufgabe Car

//Instanzen erstellen:

using Fahrzeugverwaltungssystem;

Car car1 = new Car("Ford", "Mustang", 2018, 23000);
Car car2 = new Car("Toyota", "Corolla", 2015, 45000);
Car car3 = new Car("BMW", "X5", 2019, 32000);

//Aufruf der Methoden + Ausgabe in der Konsole:

int drivenKm = 2000;
//Car1
Console.WriteLine(car1.GetDescription());
Console.WriteLine("Nach " + drivenKm + " weiteren gefahrenen Kilometern\nbeträgt der neue Kilometerstand: " + car1.Drive(drivenKm) + "km");
Console.WriteLine("Das Auto ist " + car1.Age() + " Jahre alt.\n");

//Car2
Console.WriteLine(car2.GetDescription());
Console.WriteLine("Nach " + drivenKm + " weiteren gefahrenen Kilometern\nbeträgt der neue Kilometerstand: " + car2.Drive(drivenKm) + "km");
Console.WriteLine("Das Auto ist " + car2.Age() + " Jahre alt.\n");

//Car3
Console.WriteLine(car3.GetDescription());
Console.WriteLine("Nach " + drivenKm + " weiteren gefahrenen Kilometern\nbeträgt der neue Kilometerstand: " + car3.Drive(drivenKm) + "km");
Console.WriteLine("Das Auto ist " + car3.Age() + " Jahre alt.\n");