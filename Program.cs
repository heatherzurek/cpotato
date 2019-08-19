using System;

namespace myApp
{
    class Program
    {
        static void WorkingWithIntegers()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("The current time is " + DateTime.Now);
            int a = 28;
            int b = 42;
            int c = a + b;
            Console.WriteLine(c);
            c = a - b;
            Console.WriteLine(c);
            c = a * b;
            Console.WriteLine(c);
            c = a / b;
            Console.WriteLine(c);
            c = a + b / b;
            Console.WriteLine(c);
        }

        static void OrderPrecedence()
        {
                        int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);
            d = (a  + b) * c;
            Console.WriteLine(d);
            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);
            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e  + f) / g;
            Console.WriteLine(h);
        }

        static void TestLimits()
        {
            int a = 6;
            int b = 4;
            int c = 3;
            int d = (a  + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");
        }

        static void WorkWithDoubles()
        {
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a  + b) / c;
            Console.WriteLine(d);

            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e  + f) / g;
            Console.WriteLine(h);

            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            double i = ( e - g ) / c;
            Console.WriteLine(i);
        }

        static void WorkingWithDecimals()
        {
                        decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine( c / d);
        }

        static void ExploreIf()
        {
            int a = 5;
            int b = 3;
            // if (a + b > 10)
            // {
            //     Console.WriteLine("The answer is greater than 10.");
            // }
            // else
            // {
            //     Console.WriteLine("The answer is NOT greater than 10.");
            // } 

            int c = 4;
            if ((a + b + c > 10) || (a == b))
            // == tests for equality
            // = assigns value
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else 
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }
        }

        static void LoopsPractice() 
        {
                        // int counter = 0;
            // while (counter < 10)
            // {
            //     Console.WriteLine($"Hello World! The counter is {counter}");
            //     counter ++;
            // }

            //++ is the increment operator - adds 1 to the value of counter and stores that value in counter variable
            // while checks a condition and executes the statement or statement block following the while. It repeatedly checks the condition and executing those statements until the condition is false. 

            // int counter = 0;
            // do 
            // {
            //     Console.WriteLine($"Hello World! The counter is {counter}");
            //     counter++;
            // } while (counter < 10);

            //int index = 0; is the for initializer
            //index is the loop variable and sets initial value to 0
            // index < 10 is the for condition, it declares that this for loop continues to execute as long as the value of the counter is less than 10
            //for iterator, index++ specifies how to modify the loop variable after executing the block following the for statement
            
            for(int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello world the index is {index}");
            }
        }

        static void ChallengeQuestion()
        {
            int sum = 0;
            for (int number = 1; number < 21; number++)
            {
                if (number % 3 == 0)
                {
                    sum = sum + number;
                }
            }
            Console.WriteLine($"The sum is {sum}");
        }

        static void Main(string[] args) 
        {
            // WorkingWithIntegers();
            // OrderPrecedence();
            // TestLimits();
            // WorkWithDoubles();
            // WorkingWithDecimals();
            // ExploreIf();
            // LoopsPractice();
            ChallengeQuestion();

        }
    }
}
