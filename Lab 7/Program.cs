﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Info ship = new Ship(false, 76);
            //Vehicle boat = new Boat(b: 5);
            //boat.CaptainAge = 55;
            //Vehicle steamer = new Steamer(2001, 156);
            //steamer.CaptainAge = 30;
            //Info corvette = new Corvette("Ususal");
            //VehicleDoes sailboat = new Sailboat("red", "silk", 20);

            //Printer printer = new Printer();
            //ArrayList list = new ArrayList();
            //list.Add(steamer);
            //list.Add(boat);
            //list.Add(ship);
            //list.Add(sailboat);
            //list.Add(corvette);

            //Port port = new Port();
            //port.vehicles = list;
            //port.Show();
            //Info ship2 = new Ship(true, 100);
            //port.AddVehicle(ship2);
            //port.RemoveVehicle(boat);
            //port.Show();

            //VehicleDoes sailboat2 = new Sailboat("white", "cotton", 21);
            //port.AddVehicle(sailboat2);

            //PortControl control = new PortControl();
            //Console.WriteLine("WATER\t" + control.AverageWater(port));

            //Vehicle steamer2 = new Steamer(1987, 234);
            //steamer2.CaptainAge = 23;
            //Vehicle steamer3 = new Steamer(1930, 91);
            //steamer3.CaptainAge = 78;
            //port.AddVehicle(steamer2);
            //port.AddVehicle(steamer3);
            //Console.WriteLine("Average seats quantity\t" + control.AverageSeatsCount(port));
            //control.CaptainsBelow35(port);

            try
            {
                try
                {
                    Vehicle steamer = new Steamer(2567, 156);
                }
                catch (YearOfSteamerCreationException ex)
                {
                    Console.WriteLine("YearOfSteamerCreationException");
                    Console.WriteLine($"Исключение: {ex.Message}");
                    Console.WriteLine($"Метод: {ex.TargetSite}");
                    Console.WriteLine($"Трассировка стека: {ex.StackTrace}\n\n");
                }
                try
                {
                    Vehicle boat = new Boat(b : 34);
                }
                catch (BoatCapacityException ex)
                {
                    Console.WriteLine("BoatCapacityException");
                    Console.WriteLine($"Исключение: {ex.Message}");
                    Console.WriteLine($"Метод: {ex.TargetSite}");
                    Console.WriteLine($"Трассировка стека: {ex.StackTrace}\n\n");
                }
                try
                {
                    VehicleDoes sailboat2 = new Sailboat("black", "cotton", 21);
                }
                catch (SailsColorException ex)
                {
                    Console.WriteLine("SailsColorException");
                    Console.WriteLine($"Исключение: {ex.Message}");
                    Console.WriteLine($"Метод: {ex.TargetSite}");
                    Console.WriteLine($"Трассировка стека: {ex.StackTrace}\n\n");
                }
                try
                {                    
                    ArrayList list = new ArrayList();
                    Port port = new Port();
                    port.vehicles = list;
                    PortControl control = new PortControl();
                    Console.WriteLine("Average seats quantity\t" + control.AverageSeatsCount(port));
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("DivideByZeroException");
                    Console.WriteLine($"Исключение: {ex.Message}");
                    Console.WriteLine($"Метод: {ex.TargetSite}");
                    Console.WriteLine($"Трассировка стека: {ex.StackTrace}\n\n");
                }
                try
                {
                    VehicleDoes sailboat = new Sailboat("red", "silk", 100);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("IndexOutOfRangeException");
                    Console.WriteLine($"Исключение: {ex.Message}");
                    Console.WriteLine($"Метод: {ex.TargetSite}");
                    Console.WriteLine($"Трассировка стека: {ex.StackTrace}\n\n");
                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception");
            }
            finally
            {
                Console.WriteLine("The program is done. It's a \"finally\" block.");
            }


        }
    }
}
