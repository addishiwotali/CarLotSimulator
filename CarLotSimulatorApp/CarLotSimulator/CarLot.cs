using System;
using System.Collections.Generic;

namespace CarLotSimulator;


public class CarLot
{
    public List<car> ParkingLot { get; set; } = new List<car>();

    public void CheckCars()
    {
        foreach (var vehicle in ParkingLot)
        { 
            Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
        }
        
        
    }



}