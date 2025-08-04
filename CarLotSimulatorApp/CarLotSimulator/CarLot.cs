using System;
using System.Collections.Generic;

namespace CarLotSimulator;


public class CarLot
{
    public CarLot()
    {
        
    }

    public static int numberOfCars = 1;
    public List<car> ParkingLot { get; set; } = new List<car>();

    public void CheckCars()
    {   
        Console.WriteLine($" Number of Cars created {CarLot.numberOfCars}");
        
        foreach (var vehicle in ParkingLot)
        { 
            Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
        }
        
        
    }



}