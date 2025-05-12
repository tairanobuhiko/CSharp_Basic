using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Linq;
class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(" ");
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);

        List<SuperCar> cars = new List<SuperCar>();
        for (int i = 0; i < N; i++)
        {
            string[] instance = Console.ReadLine().Split(" ");
            switch (instance[0])
            {
                case "supercar":
                    cars.Add(new SuperCar(int.Parse(instance[1]), int.Parse(instance[2])));
                    break;

                case "supersupercar":
                    cars.Add(new SuperSuperCar(int.Parse(instance[1]), int.Parse(instance[2])));
                    break;

                case "supersupersupercar":
                    cars.Add(new SuperSuperSuperCar(int.Parse(instance[1]), int.Parse(instance[2])));
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }
        }

        for (int i = 0; i < K; i++)
        {
            string[] query = Console.ReadLine().Split(" ");
            int index = int.Parse(query[0]) - 1;
            string func = query[1];
            switch (func)
            {
                case "run":
                    cars[index].Run();
                    break;

                case "fly":
                    if (cars[index] is SuperSuperCar flyableCar)
                    {
                        flyableCar.Fly();
                    }
                    break;

                case "teleport":
                    if (cars[index] is SuperSuperSuperCar teleportableCar)
                    {
                        teleportableCar.Teleport();
                    }
                    break;
            }
        }
        foreach (SuperCar car in cars)
        {
            Console.WriteLine(car.Distance);
        }
    }

    class SuperCar
    {
        protected int Fuel { get; set; }
        protected int FuelEconomy { get; set; }
        public int Distance { get; set; }

        public SuperCar(int fuel, int fuelEconomy)
        {
            this.Fuel = fuel;
            this.FuelEconomy = fuelEconomy;
        }
        public void Run()
        {
            if (this.Fuel > 0)
            {
                this.Fuel -= 1;
                this.Distance += this.FuelEconomy;
            }
        }
    }

    class SuperSuperCar : SuperCar
    {
        public SuperSuperCar(int fuel, int fuelEconomy) : base(fuel, fuelEconomy)
        {
        }

        public virtual void Fly()
        {
            if (this.Fuel >= 5)
            {
                this.Fuel -= 5;
                this.Distance += (int)Math.Pow(this.FuelEconomy, 2);
            }
            else
            {
                Run();
            }
        }

    }

    class SuperSuperSuperCar : SuperSuperCar
    {
        public SuperSuperSuperCar(int fuel, int fuelEconomy) : base(fuel, fuelEconomy)
        {
        }

        public override void Fly()
        {
            if (this.Fuel >= 5)
            {
                this.Fuel -= 5;
                this.Distance += 2 * (int)Math.Pow(this.FuelEconomy, 2);
            }
            else
            {
                Run();
            }
        }

        public void Teleport()
        {
            if (this.Fuel >= (int)Math.Pow(this.FuelEconomy, 2))
            {
                this.Fuel -= (int)Math.Pow(this.FuelEconomy, 2);
                this.Distance += (int)Math.Pow(this.FuelEconomy, 4);
            }
            else
            {
                Fly();
            }
        }
    }
}