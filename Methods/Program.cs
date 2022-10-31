using System;

namespace Methods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1
            string name = GetName();
            GreetFriend(name);

            //2
            double result1 = GetNumber();
            double result2 = GetNumber();
            int action1 = GetAction();
            double result3 = DoAction(result1, result2, action1);
            
            System.Console.WriteLine($"The result of your mathematical operation is {result3}.");

        }

        public static string GetName()
        {
            Console.WriteLine("What is your name?");
            return Console.ReadLine();
            throw new NotImplementedException();
        }

        public static void GreetFriend(string name)
        {
            //Greeting should be: Hello, nameVar. You are my friend
            //Ex: Hello, Jim. You are my friend
            Console.WriteLine("Hello, " + name + ". You are my friend");
            return;
            throw new NotImplementedException();
        }

        public static double GetNumber()
        {
            Console.WriteLine("Input a double.");

            try 
            {
                return Double.Parse(Console.ReadLine());
            }
            catch
            {
                throw new FormatException();
            }

            //Should throw FormatException if the user did not input a number
            throw new NotImplementedException();
        }

        public static int GetAction()
        {
            Console.WriteLine("Please choose an action:\n1) Add\n2) Subtract\n3) Multiply\n4) Divide");

            int operatorNum;

            while (true)
            {
                string actionChosen = Console.ReadLine();
                
                try 
                {
                    operatorNum = Int32.Parse(actionChosen);

                    if (!Int32.TryParse(actionChosen, out operatorNum))
                    {
                        Console.WriteLine("Please enter a numerical value between 1 and 4:");
                        continue;
                    }

                    if (operatorNum < 1 || operatorNum > 4)
                    {
                        Console.WriteLine("Please enter a numerical value between 1 and 4:");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                } catch (FormatException) 
                {
                    throw new FormatException();
                }
            }
                return operatorNum;

                //throw new NotImplementedException();
        }


        public static double DoAction(double x, double y, int z)
        {
            // switch (z)
            // {
            //     case 1:
            //         return x + y;
            //         break;
            //     case 2:
            //         return x - y;
            //         break;
            //     case 3:
            //         return x * y;
            //         break;
            //     case 4:
            //         return x / y;
            //         break;
            // }

            if (z == 1)
            {
                return x + y;
            }
            else if (z == 2)
            {
                return x - y;
            }
            else if (z == 3)
            {
                return x * y;
            }
            else if (z == 4)
            {
                return x / y;
            }
            else
            {
                throw new FormatException();
            }

            //throw new NotImplementedException();
        }
    }
}
