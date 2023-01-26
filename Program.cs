using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();

            Console.WriteLine($"Velocity: {myCar.GetVelocity()}");
            Console.WriteLine($"Velocity: {myCar.GetDirection()}");
            Console.WriteLine($"Velocity: {myCar.GetGasLevel()}");
            Console.WriteLine($"Velocity: {myCar.GetColor()}");
            Console.WriteLine($"Velocity: {myCar.GetCarType()}");
        }




    }
}

public class Car
{
    public Car()
    {
        Velocity = 0;
        Direction = "noDirection";
        GasLevel = "full";
        Color = "red";
        CarType = "sedan";

        Console.WriteLine($"New Car Object Created: {CarType}");
    }

    private int Velocity { get; set; }
    private string Direction { get; set; }
    private string GasLevel { get; set; }

    private string Color { get; set; }
    private string CarType { get; set; }

    public void SetVelocity(int mph)
    {
        Velocity = mph;
    }

    public void SetCarType(string carType)
    {
        CarType = carType;
    }
    
    public int GetVelocity()
    {
        return Velocity;
    }
    public string GetDirection()
    {
        return Direction;
    }
    public string GetGasLevel()
    {
        return GasLevel;
    }
    public string GetColor()
    {
        return Color;
    }
    public string GetCarType()
    {
        return CarType;
    }



}

