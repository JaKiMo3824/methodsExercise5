using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsExercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods tryMe = new Methods();

            Console.WriteLine("Please enter any number and I will give it back divided by 2");
            string user1 = Console.ReadLine();


            if (Int32.TryParse(user1, out int num1))
            {
                Methods.Method1(num1, out int result);
                Console.WriteLine(result);

            }
            else if (Double.TryParse(user1, out double num2))
            {
                Methods.Method1(num2, out double result2);
                Console.WriteLine(result2);


            }
            else
            {
                Console.WriteLine("You didn't enter a number");
            }

            Console.ReadLine();
            

           
            

            
        }
    }
}
