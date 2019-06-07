using System;

namespace Inheritance
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }


        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
        public virtual void Turn(string direction){
            Console.WriteLine($"Turning {direction}...");
        }
        public virtual void Stop(){
            Console.WriteLine("Stopping...");
        }
    }
    public class Zero : Vehicle
    {  // Electric motorcycle
        public double BatteryKWh { get; set; }

        public void ChargeBattery() { Console.WriteLine("Charging..."); }

        public override void Drive(){
            Console.WriteLine($"The {MainColor} Zero drives past you. VVeeeyuuummmmmm!!");
        }
        public override void Turn(string direction){
            Console.WriteLine($"The Zero sharply turns {direction}.");
        }

    }
    public class Cessna : Vehicle
    {  // Propellor light aircraft
        public double FuelCapacity { get; set; }

        public void RefuelTank() {Console.WriteLine("Refueling...");}
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna drives past you. Shyoooommm!!");
        }
        public override void Turn(string direction){
            Console.WriteLine($"The Cessna take a careful {direction} turn.");
        }
        public override void Stop(){
            Console.WriteLine($"The {MainColor} descends to make a full and safe stop.");
        }
    }
    public class Tesla : Vehicle
    {  // Electric car
        public double BatteryKWh { get; set; }

        public void ChargeBattery() { Console.WriteLine("Charging..."); }
        public override void Drive(){
            Console.WriteLine($"The {MainColor} Tesla drives past you. You don't hear it...");
        }
        public override void Stop(){
            Console.WriteLine($"The {MainColor} Tesla comes to a sharp stop. You don't hear it...");
        }
    }
    public class Ram : Vehicle
    {  // Gas powered truck
        public double FuelCapacity { get; set; }

        public void RefuelTank() {Console.WriteLine("Refueling...");}

        public override void Drive(){
            Console.WriteLine($"The {MainColor} Ram drives past you. VGGGRVRGRROOOOOOOMMMMM!!!!!");
        }
        public override void Turn(string direction){
            Console.WriteLine($"The {MainColor} Ram pulls a {direction} turn.");
        }
        public override void Stop(){
            Console.WriteLine($"The Ram stops completely.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle fxs = new Zero(){
                BatteryKWh = 400,
                MainColor = "green",
                MaximumOccupancy = "5 Passengers"
            };
            Vehicle modelS = new Tesla(){
                BatteryKWh = 650,
                MainColor = "blue",
                MaximumOccupancy = "5 Passengers"
            };
            Vehicle mx410 = new Cessna(){
                FuelCapacity = 325,
                MainColor = "white",
                MaximumOccupancy = "2 Passengers"
            };
            Vehicle f250 = new Ram(){
                FuelCapacity = 275,
                MainColor = "black",
                MaximumOccupancy = "6 Passengers"
            };

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            f250.Drive();

            fxs.Stop();
            modelS.Stop();
            mx410.Stop();
            f250.Stop();
            
            fxs.Turn("left");
            modelS.Turn("right");
            mx410.Turn("left");
            f250.Turn("right");


        }
    }
}
