﻿using System.Text;

namespace AutomotiveRepairShop
{
    public class RepairShop
    {
        public RepairShop(int capacity)
        {
            Capacity = capacity;
            Vehicles = new List<Vehicle>();
        }

        public int Capacity { get; set; }

        public List<Vehicle> Vehicles { get; set; }

        public void AddVehicle(Vehicle vehicle)
        {
            if (Capacity> Vehicles.Count)
            {
                Vehicles.Add(vehicle);
            }
        }

        public bool RemoveVehicle(string vin)=> Vehicles.Remove(Vehicles.FirstOrDefault(x=>x.VIN== vin));

        public int GetCount() => Vehicles.Count;

        //public Vehicle GetLowestMileage()
        //{
        //    Vehicle vehicle = Vehicles.OrderByDescending(x => x.Mileage).FirstOrDefault();
        //    return vehicle;
        //}
        public Vehicle GetLowestMileage() => this.Vehicles.OrderBy(v => v.Mileage).FirstOrDefault();


        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Vehicles in the preparatory:");
            foreach (var vehicle in Vehicles)
            {
                sb.AppendLine(vehicle.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
