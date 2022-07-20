using System;
//-----------------------------------------------------------------
// InterfaceExercise
//
// Name: David Zientara
// Date: 7-20-2022
// Comments: An exercise in interfaces
// Added methods per the instructions
//-----------------------------------------------------------------
// IVehicle 
// An interface which defines properties common to vehicles
public interface IVehicle
{
    public string Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Wheels { get; set; }
    
   

}
// ICompany
// An interface which defines properties common to companies
public interface ICompany
{
    public string Name { get; set; }
    public string Industry { get; set; }
    public string Logo { get; set; }
}
// Car class inherits from IVehicle + ICompany
public class Car : IVehicle, ICompany
{
    public string Name { get; set; }
    public string Industry { get; set; }
    public string Logo { get; set; }
    public string Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Wheels { get; set; }
    private bool HasTrunk { get; set; }
    // Define accessors + mutators for HasTrunk:
    public void SetHasTrunk(bool val)
    {
        HasTrunk = val;
    }
    public bool GetHasTrunk()
    {
        return HasTrunk;
    }
    
}
class Truck:IVehicle, ICompany 
{
    public string Name { get; set; }
    public string Industry { get; set; }
    public string Logo { get; set; }
    public string Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Wheels { get; set; }
    private int MinBedSize { get; set; } 
    private int MaxBedSize { get; set; }
    // Define accessors + mutators for
    // MinBedSize + MaxBedSize:
    public void SetMinBedSize(int val)
    {
        MinBedSize = val;
    }
    public void SetMaxBedSize(int val)
    {
        MaxBedSize = val;
    }

    public int GetMinBedSize()
    {
        return MinBedSize;
    }
    public int GetMaxBedSize()
    {
        return MaxBedSize;
    }

}
class SUV:IVehicle, ICompany 
{
    public string Name { get; set; }
    public string Industry { get; set; }
    public string Logo { get; set; }
    public string Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Wheels { get; set; }
    // Define accessors + mutators for
    // MinCargoHoldSize + MaxCargoHoldSize:
    private double MinCargoHoldSize { get; set; }
    private double MaxCargoHoldSize { get; set; }

    public void SetMinCargoHoldSize(double val)
    {
        MinCargoHoldSize = val;
    }
    public void SetMaxCargoHoldSize(double val)
    {
        MaxCargoHoldSize = val;
    }
    public double GetMinCargoHoldSize()
    {
        return MinCargoHoldSize;
    }
    public double GetMaxCargoHoldSize()
    {
        return MaxCargoHoldSize;
    }
}

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            Car Golf = new Car();
            Truck F150 = new Truck();
            SUV RangeRover = new SUV();

            Golf.Name = "Volkswagen Motors";
            Golf.Industry = "Manufacturing";
            Golf.Logo = "VW";
            Golf.Make = "Volkswagen";
            Golf.Model = "Golf";
            Golf.Year = "1992";
            Golf.Wheels = 4;
            F150.Name = "Ford Corporation";
            F150.Industry = "Manufacturing";
            F150.Logo = "Ford";
            F150.Make = "Ford";
            F150.Model = "F-150";
            F150.Year = "2010";
            F150.Wheels = 4;
            F150.SetMinBedSize(66);
            F150.SetMaxBedSize(96);
            RangeRover.Name = "Land Rover Company";
            RangeRover.Industry = "Manufacturing";
            RangeRover.Logo = "Land Rover";
            RangeRover.Make = "Land Rover";
            RangeRover.Model = "Range Rover";
            RangeRover.Year = "2022";   
            RangeRover.SetMinCargoHoldSize(40.7);
            RangeRover.SetMaxCargoHoldSize(83.5);

            // I "creatively" displayed the output by using tabs:

            Console.WriteLine("Properties of the Car object:");
            Console.WriteLine($"Make:\t\t{ Golf.Make}");
            Console.WriteLine($"Model:\t\t{Golf.Model}");
            Console.WriteLine($"Year:\t\t{Golf.Year}");
            Console.WriteLine($"Wheels:\t\t{Golf.Wheels}");
            Console.WriteLine("Properties of the Truck object:");
            Console.WriteLine($"Make:\t\t\t\t{F150.Make}");
            Console.WriteLine($"Model:\t\t\t\t{F150.Model}");
            Console.WriteLine($"Year:\t\t\t\t{F150.Year}");
            Console.WriteLine($"Wheels:\t\t\t\t{F150.Wheels}");
            Console.WriteLine($"Minimum bed size, in inches\t{F150.GetMinBedSize()}");
            Console.WriteLine($"Maximum bed size, in inches\t{F150.GetMaxBedSize()}");
            Console.WriteLine("Properties of the SUV object:");
            Console.WriteLine($"Make:\t\t\t\t\t{RangeRover.Make}");
            Console.WriteLine($"Model:\t\t\t\t\t{RangeRover.Model}");
            Console.WriteLine($"Year:\t\t\t\t\t{RangeRover.Year}");
            Console.WriteLine($"Wheels:\t\t\t\t\t{RangeRover.Wheels}");
            Console.WriteLine($"Minimum cargo hold size, in cubic feet\t{RangeRover.GetMinCargoHoldSize()}");
            Console.WriteLine($"Maximum cargo hold size, in cubic feet\t{RangeRover.GetMaxCargoHoldSize()}");








        }
    }
}
