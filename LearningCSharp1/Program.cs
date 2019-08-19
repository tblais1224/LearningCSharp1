using System;
namespace LearningCSharp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            var worker = new FactoryWorker();
            worker.Count(4);
            worker.Count(2);
            worker.Count(2.5f);
            Console.ReadLine();
        }
    }
    public class FactoryWorker
    {
        public FactoryWorker()
        {

        }
        public void Count(int number)
        {
            if (Total == null)
                Total = 0;
            // convert to float using tosingle
            Total = Total + Convert.ToSingle(number);
            Console.WriteLine(Total.ToString());
        }
        //only use the same name when doing the same function but with different variable type
        public void Count(float number)
        {
            Total = Total + number;
            Console.WriteLine(Total.ToString());
        }
        //make float so everything handles floats
        public float Total { get; set; }
    }
}