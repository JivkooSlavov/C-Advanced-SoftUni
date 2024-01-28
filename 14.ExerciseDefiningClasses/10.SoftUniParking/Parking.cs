using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;

        public List<Car> Cars { get { return cars; } set { cars = value; } }
        public int Capacity { get { return capacity; } set { capacity = value; } }

        public int Count { get { return cars.Count; } }
        public Parking(int capacity)
        {
            Cars = new List<Car>();
            Capacity = capacity;
        }

        public string AddCar(Car addedCar)
        {
            bool canAddCar = true;
            foreach (Car car in Cars)
            {
                if (car.RegistrationNumber == addedCar.RegistrationNumber)
                {
                    return "Car with that registration number, already exists!";
                    canAddCar = false;
                }
            }
            if (Cars.Count +1 > capacity)
            {
                canAddCar = false;
                return "Parking is full!";
            }
            if (canAddCar)
            {
                Cars.Add(addedCar);
                return $"Successfully added new car {addedCar.Make} {addedCar.RegistrationNumber}";
            }
            return "";
        }
        public string RemoveCar(string registrationNumber)
        {
            bool isAvailable = false;
            foreach (Car car in Cars)
            {
                if (car.RegistrationNumber == registrationNumber)
                {
                    isAvailable = true;
                }
            }
            if (!isAvailable)
            {
                return "Car with that registration number, doesn't exist!";
            }
            else
            {
                Car carToRemove = Cars.First(car => car.RegistrationNumber == registrationNumber);
                Cars.Remove(carToRemove);
                return $"Successfully removed {registrationNumber}";
            }
        }
        public Car GetCar(string registrationNumber)
        {
            return Cars.First(car=>car.RegistrationNumber==registrationNumber);

        }
        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (string registrationNumber in registrationNumbers)
            {
                RemoveCar(registrationNumber);
            }
        }
    }
}
