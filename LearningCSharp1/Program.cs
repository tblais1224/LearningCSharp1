using System;
namespace CSharpConsoleLearning
{
    class Program
    {
        public static void Main(string[] args)
        {
            var dozer = new Bulldozer("Yellow", "Mini");
            var dozer2 = new Bulldozer("Red", "Large");
            Console.WriteLine("Bulldozer 1 is: " + dozer.color);
            Console.WriteLine("Bulldozer 2 is: " + dozer2.color);
            Console.ReadLine();
        }
    }
    public class Bulldozer
    {
        // this is a constructor
        public Bulldozer(string _color, string _size)
        {
            this.color = _color;
            this.size = _size;
        }
        public string color { get; set; }
        public string size { get; set; }
    }
}