using System;

namespace Random_Number_if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();

            int number = randomNumber.Next(0, 50);

            Console.WriteLine(number);
            

            if (number < 20)
            {
                Console.WriteLine("Random Number is smaller than 20");
            }else if (number == 20)
            {
                Console.WriteLine("Random Number equals to 20");
            }
            else
            {
                Console.WriteLine("Random Number is bigger than 20");
            }
            
            
            Console.ReadKey();
        }
    }
}
