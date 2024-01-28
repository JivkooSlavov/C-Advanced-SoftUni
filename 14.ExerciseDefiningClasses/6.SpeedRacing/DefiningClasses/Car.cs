using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionFor1km;
        private double travelledDistance;

        public Car(string model,double fuelAmount, double fuelConsumptionFor1km)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionFor1km= fuelConsumptionFor1km;
            TravelledDistance = 0;
        }
        public string Model
        {
            get; set;
        }
        public double FuelAmount
        {
            get;set;
        }
        public double FuelConsumptionFor1km
        {
            get; set;
        }
        public double TravelledDistance
        {
            get;set;
        }

        public void Drive(double amountOfKm)
        {
            double neededLiters = amountOfKm * FuelConsumptionFor1km;
            if (FuelAmount>=neededLiters)
            {
                FuelAmount -= neededLiters;
                TravelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
