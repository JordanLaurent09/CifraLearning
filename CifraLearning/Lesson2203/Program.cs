namespace Lesson2203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;
            float result2;
            string line1 = Console.ReadLine();
            // string line2 = Console.ReadLine();  

            Console.WriteLine(isInteger("20"));
            if (isInteger(line1) && result > 0)
            {
                Console.WriteLine("Положительное число");
            }
            Console.WriteLine(result);
            Console.WriteLine(isFloat("20,0"));
            Console.WriteLine(result2);

            bool isInteger(string inputValue)
            {
                return (int.TryParse(inputValue, out result));
            }

            bool isFloat(string inputValue)
            {
                return (float.TryParse(inputValue, out result2));
            }
        }
    }


}