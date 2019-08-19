using System;
namespace LearningCSharp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            var car1 = new Car();
            car1.color = "Red";
            car1.manufacturer = "Toyota";
            var saloonCar1 = new SaloonCar(2);
            var saloonCar2 = new SaloonCar(3, "Nissan");
            var saloonCar3 = new SaloonCar(4, "Purple", "Ford");
            Console.WriteLine(car1.color + " " + car1.manufacturer);
            Console.WriteLine(saloonCar1.seats);
            Console.WriteLine(saloonCar2.manufacturer + " " + saloonCar2.seats);
            Console.WriteLine(saloonCar3.color + " " + saloonCar3.manufacturer + " " + saloonCar3.seats);
            Console.ReadLine();
        }
    }
    public class Car
    {
        public Car()
        {
        }
        public string color { get; set; }
        public string manufacturer { get; set; }
    }
    public class SaloonCar : Car
    {
        public SaloonCar(int _seats)
        {
            this.seats = _seats;
        }
        public SaloonCar(int _seats, string _manufacturer)
        {
            this.seats = _seats;
            this.manufacturer = _manufacturer;
        }
        public SaloonCar(int _seats, string _color, string _manufacturer)
        {
            this.seats = _seats;
            this.color = _color;
            this.manufacturer = _manufacturer;
        }
        public int seats { get; set; }
    }
}