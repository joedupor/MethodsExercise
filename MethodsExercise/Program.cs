using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();


            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();


            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();


            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();


            Console.WriteLine($"{name} has a favorite color of {color} and a favorite animal of {animal} and has a favorite band named {band}!");



            int addTwoNumbers = Add(2, 3);
            Console.WriteLine(addTwoNumbers);

            int subtractTwoNumbers = Subtract(3, 2);
            Console.WriteLine(subtractTwoNumbers);

            int multiplyTwoNumbers = Multiply(2, 3);
            Console.WriteLine(multiplyTwoNumbers);

            int divideTwoNumbers = Divide(4, 2);
            Console.WriteLine(divideTwoNumbers);

            int modTwoNumbers = Modulus(5, 4);
            Console.WriteLine(modTwoNumbers);
            // alternatively you can code ... Modulus(5,4); as the 1st line then next line as Console.WriteLine(Modulus(5, 4));

            int sumOfVariousNumbers1 = VariableSizeSum(2, 4);
            Console.WriteLine(sumOfVariousNumbers1);

            int sumOfVariousNumbers2 = VariableSizeSum(2, 4, 6);
            Console.WriteLine(sumOfVariousNumbers2);

            int sumOfVariousNumbers3 = VariableSizeSum(1, 1, 1, 1, 1);
            Console.WriteLine(sumOfVariousNumbers3);


        }

        public static int Add(int num1, int num2)
        {
            int answer1 = num1 + num2;
            return answer1;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }

        public static int VariableSizeSum(params int[] values)
        {
            return values[0];
        }

      
        
    }
} 
