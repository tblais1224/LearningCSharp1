using System;
namespace LearningCSharp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            var worker = new FactoryWorker();
            var result = worker.AddNumbers(3, 9);
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }
    }
    public class FactoryWorker
    {
        public FactoryWorker()
        {

        }
        public int AddNumbers (int num1, int num2)
        {
            var result = num1 + num2;
            //anything in here can be modified as needed
            result = result + 100;
            result = result - 100;
            return result; 
        }
    }
}