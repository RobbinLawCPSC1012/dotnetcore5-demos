using System;

namespace MethodsExceptions
{
    #region
    public class App1
    {
        // simplest method with no parameters and no return
        public void printHello()
        {  
            Console.WriteLine($"Hello");
        }
        // intermediate method with input parameters but no return
        public void printIt(String myString, int myInt)
        { 
            Console.WriteLine($"Hey my string is: {myString}, and my int is {myInt}");
        }
        // most complicated method with input parameters and a return value
        public int add(int n1, int n2)
        { 
            return n1 + n2;
        }
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            int x;
            String s;
            printHello();
            printIt("fun", 2);
            x = add(2,3);
            s = x.ToString();
            printIt(s, x);
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
    #region
    public class App2
    {
        private double getValue(
            string prompt, // prompt for the user 
            double low,    // lowest allowed value
            double high    // highest allowed value
            )
        {
            double result;
            do
            {
                Console.WriteLine($"{prompt} between {low:n1} and {high:n1}:");
                string resultString = Console.ReadLine();
                result = double.Parse(resultString);
            } while ((result < low) || (result > high));
            return result;
        }

        private int getNum(string prompt, int low, int high)
        {
            int num = low - 1;
            while ((num < low) || (num > high))
            {
                Console.WriteLine($"{prompt} between {low} and {high}:");
                string resultString = Console.ReadLine();
                num = int.Parse(resultString);
            }
            return num;
        }

        private int getNum1(string prompt, int low, int high)
        {
            int num = low - 1;
            bool invalidInput = true;
            while (invalidInput)
            {
                Console.WriteLine($"{prompt} between {low} and {high}: ");
                num = int.Parse(Console.ReadLine());
                if (num >= low && num <= high)
                    invalidInput = false;
                else
                    Console.WriteLine("Error: Invalid Input.");
            }
            return num;
        }

        private int getNum2(string prompt, int low, int high)
        {
            int num = low - 1;
            bool inValidInput = true;
            while (inValidInput)
            {
                Console.WriteLine($"{prompt} between {low} and {high}:");
                string resultString = Console.ReadLine();
                num = int.Parse(resultString);
                if ((num < low) || (num > high))
                    Console.WriteLine($"Error: Invalid Input.");
                else 
                    inValidInput = false;
            }
            return num;
        }
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            double windowWidth = getValue("Enter width of window in feet", 2.0, 6.0);
            Console.WriteLine($"Window Width: {windowWidth} feet");
            double age = getValue("Enter your age in years", 0, 70);
            Console.WriteLine($"Your Age is: {age} years");
            int num = getNum("Enter a integer number", 0, 1000);
            Console.WriteLine($"The entered number is: {num}");
            int num1 = getNum1("Enter a integer number", 0, 1000);
            Console.WriteLine($"The entered number is: {num1}");
            int num2 = getNum2("Enter a integer number", 0, 1000);
            Console.WriteLine($"The entered number is: {num2}");
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
    #region
    public class App3
    {
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
    #region
    public class App4
    {
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
    #region
    public class App5
    {
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
    #region
    public class App6
    {
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
    #region
    public class App7
    {
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
    #region
    public class App8
    {
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
    #region
    public class App9
    {
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
    #region
    public class App10
    {
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
    #region
    public class App11
    {
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
    #region
    public class App12
    {
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
}