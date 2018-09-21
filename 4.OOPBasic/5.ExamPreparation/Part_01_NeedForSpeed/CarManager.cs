using System;
using System.Collections.Generic;
using System.Linq;

namespace Part_01_NeedForSpeed
{
    //Car manager class that holds the main funcionality of the app.
    public class CarManager
    {
        public CarManager()
        {
        }

        public Car Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspenion, int durability, List<Car> reg, List<Race> listRace)
        {
            switch (type)
            {
                case "Performance":
                    return new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspenion, durability, id, type);

                case "Show":
                    return new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspenion, durability, id, type);
            }

            return null;
        }

        public string Check(int id, List<Car> reg)
        {
            if (reg.Exists(c => c.Id == id))
            {
                var car = reg.Find(c => c.Id == id);
                return car.Brand + " " + car.Model + " " + car.YearOfProduction + "\n"
                     + car.HorsePower + " HP, " + "100 m/h in " + car.Acceleration + " s" + "\n" +
                       car.Suspension + " Suspension force, " + car.Durability + " Duravility" + "\n" +
                       reg.Find(c => c.Id == id).ToString();
            }
            else
            {
                throw new ArgumentException("Car does not exist!");
            }
        }

        public Race Open(int id, string type, int length, string route, int prizePool, int additive)
        {
            switch (type)
            {
                case "Casual":
                    return new CasualRace(length, route, prizePool, id);

                case "Drag":
                    return new DragRace(length, route, prizePool, id);

                case "Drift":
                    return new DriftRace(length, route, prizePool, id);

                case "Circuit":
                    return new CircuitRace(length, route, prizePool, id, additive);

                case "TimeLimit":
                    return new TimeLimitRace(length, route, prizePool, id, additive);
            }

            return null;
        }

        public void Participate(int carId, int raceId, Garage parking, List<Race> listRace, List<Car> reg, List<Car> parkingLot)
        {
            if (!listRace.Exists(r => r.Id == raceId))
            {
                throw new Exception("This race does not exist!");
            }
            else if (!reg.Exists(c => c.Id == carId))
            {
                throw new Exception("This car does not exist!");
            }
            else if (parkingLot.Exists(c => c.Id == carId))
            {
            }
            else
            {
                var point = listRace.Find(r => r.Id == raceId).CalulatePoints(reg.Find(c => c.Id == carId));
                listRace.Find(r => r.Id == raceId).Participants.Add(reg.Find(c => c.Id == carId), point);
            }
        }

        public string Start(int id, List<Race> listRace, List<Car> reg)
        {
            var result = string.Empty;

            if (!listRace.Exists(r => r.Id == id))
            {
                throw new Exception("This race does not exist!");
            }
            else if (listRace.Find(r => r.Id == id).Participants.Count == 0)
            {
                Console.WriteLine("Cannot start the race with zero participants.");
            }
            else
            {
                var count = 1;
                result = listRace.Find(r => r.Id == id).Route + " - " + listRace.Find(r => r.Id == id).Length;

                foreach (var car in listRace.Find(r => r.Id == id).Participants.OrderByDescending(v => v.Value))
                {
                    if (listRace.Find(r => r.Id == id).GetType().Name == "TimeLimitRace")
                    {
                        return result += "\n 1. " + car.Key.Brand + " " + car.Key.Model + "-" + listRace.Find(r => r.Id == id).CalulatePoints(car.Key);
                    }
                    else if (count == 1 && listRace.Find(r => r.Id == id).GetType().Name == "CircuitRace")
                    {
                        result += "\n 1. " + car.Key.Brand + " " + car.Key.Model + " " + car.Value + "PP - $" + (listRace.Find(r => r.Id == id).PrizePool * 0.4);
                        count++;
                    }
                    else if (count == 2 && listRace.Find(r => r.Id == id).GetType().Name == "CircuitRace")
                    {
                        result += "\n 2. " + car.Key.Brand + " " + car.Key.Model + " " + car.Value + "PP - $" + listRace.Find(r => r.Id == id).PrizePool * 0.3;
                        count++;
                    }
                    else if (count == 3 && listRace.Find(r => r.Id == id).GetType().Name == "CircuitRace")
                    {
                        result += "\n 3. " + car.Key.Brand + " " + car.Key.Model + " " + car.Value + "PP - $" + listRace.Find(r => r.Id == id).PrizePool * 0.2;
                        count++;
                    }
                    else if (count == 4 && listRace.Find(r => r.Id == id).GetType().Name == "CircuitRace")
                    {
                        result += "\n 4. " + car.Key.Brand + " " + car.Key.Model + " " + car.Value + "PP - $" + listRace.Find(r => r.Id == id).PrizePool * 0.1;
                        count++;
                    }
                    else if (count == 1 && count <= listRace.Find(r => r.Id == id).Length)
                    {
                        result += "\n 1. " + car.Key.Brand + " " + car.Key.Model + " " + car.Value + "PP - $" + listRace.Find(r => r.Id == id).PrizePool / 2;
                        count++;
                    }
                    else if (count == 2 && count <= listRace.Find(r => r.Id == id).Length)
                    {
                        result += "\n 2. " + car.Key.Brand + " " + car.Key.Model + " " + car.Value + "PP - $" + listRace.Find(r => r.Id == id).PrizePool * 0.3;
                        count++;
                    }
                    else if (count == 3 && count <= listRace.Find(r => r.Id == id).Length)
                    {
                        result += "\n 3. " + car.Key.Brand + " " + car.Key.Model + " " + car.Value + "PP - $" + listRace.Find(r => r.Id == id).PrizePool * 0.2;
                        count++;
                    }
                    else
                    {
                        return result;
                    }
                }

                listRace.Remove(listRace.Find(r => r.Id == id));
            }

            return result;
        }

        public void Park(int id, Garage parking, List<Race> listRace, List<Car> reg, List<Car> parkingLot)
        {
            if (!reg.Exists(c => c.Id == id))
            {
                throw new Exception("This car does not exist!");
            }
            else if (RaceChecker(listRace, id) == true)
            {
                parkingLot.Add(reg.Find(c => c.Id == id));
            }
            else if (RaceChecker(listRace, id) == true)
            {
                throw new Exception("This car is racing!");
            }
        }

        public void Unpark(int id, Garage parking, List<Car> reg, List<Car> parkingLot)
        {
            if (!reg.Exists(c => c.Id == id))
            {
                throw new Exception("This car does not exist!");
            }
            else
            {
                parkingLot.Remove(reg.Find(c => c.Id == id));
            }
        }

        public void Tune(int tuneIndex, string addOn, Garage parking, List<Car> parkingLot)
        {
            foreach (var car in parkingLot)
            {
                car.Tune(tuneIndex, addOn);
            }
        }

        public bool RaceChecker(List<Race> listRace, int id)
        {
            foreach (var race in listRace)
            {
                foreach (var car in race.Participants)
                {
                    if (car.Key.Id == id)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool ParkChecker(Garage parking, int id)
        {
            foreach (var car in parking.ParkedCars)
            {
                if (car.Id == id)
                {
                    return true;
                }
            }

            return false;
        }
    }
}