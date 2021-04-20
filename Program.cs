using System;

namespace commonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // + , * , / , % , -
            int numerator = 10;
            int denomenator = 2;

            int result = numerator / denomenator;
            int result1 = numerator + denomenator;
            int result2 = numerator - denomenator;
            int result3 = numerator % denomenator;
            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);


            string myName = "Andrew";
            string password = "1234";

            string nameInput = Console.ReadLine();
            string passwordInput = Console.ReadLine();

            if(myName ==  nameInput && password == passwordInput )
            {
                Console.WriteLine("successful login .");
            }
            else{
                Console.WriteLine("false");
            }

            //++ -- += (All increment operators)

            int x = 20;
            int y = 10;
            y+=1;
            //ternary operator
            string results  = x > y ? $"{x} is greater than {y}": $"{x} is less than {y}";
            string results1  = x > y ? $"{x} is greater than {y}": $"{x} is less than {y}";
            string results2  = x > y ? $"{x} is greater than {y}": $"{x} is less than {y}";
            
            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result2);

            Console.WriteLine("Making A Second commit");

        }
    }
}
