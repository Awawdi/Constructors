using System;

namespace Constructors
{
    public interface IMotor
    {
        int getFuel();
    }

    public class Car : IMotor
    {
        private int fuel = 100;

        public int getFuel()
        {
            return this.fuel;
        }

        public int addFuel(int amount)
        {
            this.fuel += amount;
            return this.fuel;
        }

        public Car()
        {}

        public Car(string carName)
        {
            Console.WriteLine("Car constructor called");
            Name = carName;
        }

        public Car(string carName, string carNumber)
        {
            Console.WriteLine("Car constructor with Arguments called");
            Name = carName;
            Number = carNumber;
        }

        public string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string _carNum;
        public string Number
        {
            get { return _carNum; }
            set { _carNum = value; }
        }

        public virtual void Drive()
        {
            Console.WriteLine("GM Car Drive");
        }
    }
    public class Nissan : Car
    {
        Nissan() 
        { 
            
        }
        public Nissan(string carName) 
        {
            Console.WriteLine("Nissan constructor called");
            Name = carName;
        }

        public Nissan(string carName, string carNumber) : base (carName,carNumber)
        {
        }
    }
    public class Hynadi : Car
    {
        Hynadi() { }
        public Hynadi(string carName)
        {
            Console.WriteLine("Hynadi constructor called");
            Name = carName;
        }
    }
    public class Mazda : Car
    {
        Mazda() { }
        public Mazda(string carName)
        {
            Console.WriteLine("Mazda constructor called");
            Name = carName;
            addFuel(50);
        }

        public override void Drive()
        {
            Console.WriteLine(Name + " Car Drive");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car GM = new Car("GM");
            Console.WriteLine(GM.Name);
            GM.Drive(); //Base class Drive
            Console.WriteLine("Car fuel level = "+ GM.getFuel());

            Mazda Lantis = new Mazda("Lantis");
            Console.WriteLine(Lantis.Name);
            Lantis.Drive(); //Drive with polymorphism
            Console.WriteLine("Car fuel level = "+ Lantis.getFuel());

            Hynadi Tuscon = new Hynadi("Tuscon");
            Console.WriteLine(Tuscon.Name);
            Tuscon.Drive(); //Drive without polymorphism
            Console.WriteLine("Car fuel level = "+ Tuscon.getFuel());

            Nissan Almera = new Nissan("Almera","999");
            Console.WriteLine(Almera.Name + " - " + Almera.Number);
            
        }
    }
}
