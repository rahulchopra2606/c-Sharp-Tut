using System;
class Calculator
{
    public static void Main(String[] args)
    {
        // Taking two numbers as input from the user
        Console.WriteLine("Please enter the first number");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter the second number");
        double num2 = Convert.ToDouble(Console.ReadLine());




        int choice;
        bool validChoice = false;

        while (!validChoice)
        {
            //Taking user choice for calculation
            Console.WriteLine("Please enter a choice");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");

            choice = Convert.ToInt32(Console.ReadLine());

            double ans = 0;

            switch (choice)
            {
                case 1:
                    ans = num1 + num2;
                    Console.WriteLine("The answer of addition is = " + ans);
                    validChoice = true;
                    break;
                case 2:
                    ans = num1 - num2;
                    Console.WriteLine("The answer of subtraction is = " + ans);
                    validChoice = true;
                    break;
                case 3:
                    ans = num1 * num2;
                    Console.WriteLine("The answer of multiplication is = " + ans);
                    validChoice = true;
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        ans = num1 / num2;
                        Console.WriteLine("The answer of division is = " + ans);
                        validChoice = true;


                    }
                    else
                    {
                        Console.WriteLine("Error, Division by zero is not allowed!");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice, Please choose a valid choice");
                    break;

            }
        }
    }
}
