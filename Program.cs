// using System;

// class Vehicle{
    
//     private int numOfDoors;
//     private double price;

//     // Constructors
//     public Vehicle()
//     {
//         Console.WriteLine("Creating a vehicle  default const ");
//         numOfDoors = 4;
//         price = 10000;
//     }

//     public Vehicle(int nd, double pr)
//     {
//         Console.WriteLine("Creating a vehicle  parameterized const");
//         numOfDoors = nd;
//         price = pr;
//     }

//     public Vehicle(Vehicle vec)
//     {
//         Console.WriteLine("Creating a vehicle copy constructor");
//         numOfDoors = vec.numOfDoors;
//         price = vec.price;
//     }

//     public int GetNumOfDoors()
//     {
//         return numOfDoors;
//     }
//     public void SetNumOfDoors(int nd)
//     {
//         numOfDoors = nd;
//     }

//     public double GetPrice()
//     {
//         return price;
//     }
//     public void SetPrice(double pr)
//     {
//         price = pr;
//     }

//     public override string ToString()
//     {
//         return $"This Vehicle has {numOfDoors} doors and its price is {price:C}.";
//     }
// }

// class Bus : Vehicle
// {
//     private int passengerCapacity;

//     public Bus() {
//         Console.WriteLine("Creating a bus default const");
//         passengerCapacity = 50;
//     }
//     // Parameterized constructor
//     public Bus(int pc) 
//     {
//         Console.WriteLine("Creating a bus parameterized const");
//         passengerCapacity = pc;
//     }

//     //more const (pc,nd,pr) /// copycons

//     public Bus(int nd,double pr , int pc ) : base(nd,pr){
//         Console.WriteLine("Creating a bus parameterized const using para cons father");
//         passengerCapacity = pc;
//     }

//     //copy const 

//     public Bus(Bus b) :base(b){
//         Console.WriteLine("Creating a bus using Copy const and using father copy const");
//         passengerCapacity = b.passengerCapacity;
//     }

//     //getters and setters

//     public int GetPassengerCapacity()
//     {
//         return passengerCapacity;
//     }
//     public void SetPassengerCapacity(int pc)
//     {
//         passengerCapacity = pc;
//     }

//     public override string ToString()
//     {
//         return $"This Bus has {passengerCapacity} passengers and numeber of doors of the vehicle is {GetNumOfDoors()} and its price is {GetPrice():C}.";
//     }

//     public new void SetPrice(double pr)
//     {
//         if (pr < GetPrice())
//         {
//             Console.WriteLine($"The price of this bus will be reduced from {GetPrice():C} to {pr:C}.");
//         }
//         else if (pr > GetPrice())
//         {
//             Console.WriteLine($"The price of this bus will be increased from {GetPrice():C} to {pr:C}.");
//         }
//         else
//         {
//             Console.WriteLine("No change will be applied to the price of the bus.");
//         }
//         base.SetPrice(pr);
//     }



// }

// class Program
// {
//     static void Main()
//     {
//         // Console.WriteLine("Will create two Vehicle objects");

//         //  Vehicle v1 = new Vehicle();

//         // Vehicle v2 = new Vehicle(v1);
//         // v1.SetPrice(22000);
//         // v2.SetPrice(16700);

//         // Console.WriteLine("\nWill create three Bus objects");
//         Bus b1 = new Bus(2,3000,30);
//         Console.WriteLine(b1);

//         Bus b2 = new Bus(b1);
//         Console.WriteLine(b2);

//     }
// }
