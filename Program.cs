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
            var carList = new List<Car>();

            int counter = 0;
            while (counter < 10)
            {
                carList.Add(CreateCar());

                counter++;
            }
        }

        public static Car CreateCar()
        {
            var myCar = new Car();

            Console.WriteLine($"Velocity: {myCar.GetVelocity()}");
            Console.WriteLine($"Direction: {myCar.GetDirection()}");
            Console.WriteLine($"GasLevel: {myCar.GetGasLevel()}");
            Console.WriteLine($"Color: {myCar.GetColor()}");
            Console.WriteLine($"CarType: {myCar.GetCarType()}");
            Console.WriteLine();

            return myCar;
        }
    }
}

public class MyStaticClass
{
    public static int GetRandomNumber(int min, int max)
    {
        var random = new Random();
        return random.Next(min, max);
    }

}
    


// Class
public class Car
{
    // Constructor
    public Car(int _velocity = 0, string _direction = "noDirection", string _gasLevel = "full", string _color = "Black", string _carType = "Sedan")
    {
        Velocity = _velocity;
        Direction = _direction;
        GasLevel = _gasLevel;
        Color = _color;
        CarType = _carType;

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

