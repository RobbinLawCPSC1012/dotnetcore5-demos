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
            int mySum = n1 + n2;
            return mySum;
            //return n1 + n2;
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
                Console.WriteLine($"{prompt} between {low:n9} and {high:n1}:");
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
            Console.WriteLine($"Window Width: {windowWidth:n1} feet");
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
        private double getNumber(string prompt, double low, double high)
        {
            double num = 0;
            bool invalidInput = true;
            while (invalidInput)
            {
                Console.WriteLine($"{prompt} between {low:n1} and {high:n1}: ");
                num = double.Parse(Console.ReadLine());
                if (num >= low && num <= high)
                    invalidInput = false;
                else
                    Console.WriteLine("Error: Invalid Input.");
            }
            return num;
        }
        private double circleArea(double radius)
        {
            return (Math.PI * radius * radius);
        }
        private double circleCircumference(double radius)
        {
            return (2 * Math.PI * radius);
        }
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            double radius = getNumber("Enter Circle Radius", 2.0, 6.0);
            double areaCalc = circleArea(radius);
            Console.WriteLine($"The Circle Area is: {areaCalc:n2}");
            Console.WriteLine($"The Circle Area is: {circleArea(radius):n2}");
            Console.WriteLine($"The Circle Circumference is: {circleCircumference(radius):n2}");
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
    #region
    public class App4
    {
        private double compute_slope ( int x1, int y1, int x2, int y2 )
        {
           double slope;
           slope = (y2 - y1)/(x2 - x1);
           return slope;
        }

        /* Calculates the Y intercept of the line. */
        private double compute_intercept ( int x1, int y1, double slope )
        {
           double intercept;
           intercept = y1 - slope * x1;
           return intercept;
        }
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            int x1, x2, y1, y2;
            double slope, intercept;
            Console.WriteLine("please enter the X coordinate of the first point: ");
            x1= int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the X coordinate of the second point: ");
            x2= int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the Y coordinate of the first point: ");
            y1= int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the Y coordinate of the second point: ");
            y2= int.Parse(Console.ReadLine());
            slope = compute_slope (x1, y1, x2, y2);
            intercept = compute_intercept(x1, y1, slope);
            Console.WriteLine($"The slope is {slope}, and the intercept is {intercept}");
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
    #region
    public class App5
    {
        static void DisplayMenu()
        {
            //Console.Clear();
            Console.WriteLine("Math Quiz");
            Console.WriteLine("**********\n");
            Console.WriteLine("a) \tAddition Question");
            Console.WriteLine("s) \tSubtraction Question");
            Console.WriteLine("m) \tMultiplication Question");
            Console.WriteLine("d) \tDivision Question");
            Console.WriteLine("q) \tQuit");
        }
        static double Add(double a, double b)
        {
            return a + b;
        }
        static double Subtract(double a, double b)
        {
            return a - b;
        }
        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static double Divide(double a, double b)
        {
            return a / b;
        }
        static char GetChoice()
        {
            Console.Write("Please enter a choice: ");
            char c = Char.ToLower(Char.Parse(Console.ReadLine()));
            switch (c)
            {
                case 'a':
                case 's':
                case 'm':
                case 'd':
                case 'q':
                    return c;

                default:
                    Console.WriteLine("Invalid Option.");
                    //Recursion
                    return GetChoice();
            }
        }
        static double DoThatMath(char c)
        {
            double a, b;
            Console.Write("Enter Number 1: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            b = double.Parse(Console.ReadLine());
            if (c == 'a') return Add(a, b);
            if (c == 's') return Subtract(a, b);
            if (c == 'm') return Multiply(a, b);
            else return Divide(a, b);
        }
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            bool running = true;
            while (running)
            {
                DisplayMenu();
                char c = GetChoice();
                if (c == 'q')
                    running = false;
                else
                {
                    Console.WriteLine("Result is: " + DoThatMath(c));
                    Console.WriteLine("Press Enter to Continue");
                    Console.ReadLine();
                }
            }
            Console.WriteLine("Goodbye!");
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
    #region
    public class App6
    {
        private int GetNumber(string prompt, int low, int high)
        {
            bool invalidInput = true;
            int num = 0;
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
        private char GetCharacter(string msg)
        {
            bool validInput = false;
            char c = 'c';
            while (!validInput)
            {
                Console.Write(msg);
                c = char.Parse(Console.ReadLine());
                validInput = true;
            }
            return c;
        }
        private void DrawBox(int rows, char drawChar)
        {
            for (int i = 1; i <= rows; i++)
            {
                DrawRow(rows, drawChar);
                Console.Write($"\n");
            }
        }
        private void DrawRow(int rows, char drawChar)
        {
            for(int i =1; i <= rows; i++)
            {
                Console.Write($"{drawChar}");
            }
        }
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            int num = GetNumber("Enter the number of rows", 1, 10);
            char c = GetCharacter("Enter a character to print: ");
            DrawBox(num, c);
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
    #region
    public class App7
    {
        private int GetNumber(string prompt, int low, int high)
        {
            bool invalidInput = true;
            int num = 0;
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
        private char GetCharacter(string msg)
        {
            bool validInput = false;
            char c = 'c';
            while (!validInput)
            {
                Console.Write(msg);
                c = char.Parse(Console.ReadLine());
                validInput = true;
            }
            return c;
        }
        private void DrawTriangle(int rows)
        {
            char c = '*';
            DrawTriangle(rows, c);
        }
        private void DrawTriangle(int rows, char drawChar)
        {
            for (int i = 1; i <= rows; i++)
                DrawRow(i, drawChar);
        }
        private void DrawRow(int len, char c)
        {
            for (int i = 0; i < len; i++)
                Console.Write(c);
            Console.Write("\n");
        }
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            int num = GetNumber("Enter the number of rows", 1, 10);
            char c = GetCharacter("Enter a character to print: ");
            Console.WriteLine("\nDefault");
            DrawTriangle(num);
            Console.WriteLine("\nCustom");
            DrawTriangle(num, c);
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
    #region
    public class App8
    {
        private int GetInt1(String msg)
        {
            bool inValidInput = true;
            int num = 0;
            while (inValidInput)
            {
                Console.Write(msg);
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                    inValidInput = false;
                else
                    Console.WriteLine("Invalid. Must be bigger than zero.");
            }
            return num;
        }
        
        private int GetInt2(String msg)
        {
            bool inValidInput = true;
            int num = 0;
            while (inValidInput)
            {
                try
                {
                    Console.Write(msg);
                    num = int.Parse(Console.ReadLine());
                    if (num < 0)
                        throw new Exception("Invalid: Must be bigger than zero.");
                    inValidInput = false; 
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"catch: {ex.Message}");
                }
            }
            return num;
        }
        
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            int myInt1 = GetInt1($"GetInt1: Enter a + integer value: ");
            Console.WriteLine($"Congrats, you entered {myInt1}");
            int myInt2 = GetInt2($"GetInt2: Enter a + integer value: ");
            Console.WriteLine($"Congrats, you entered {myInt2}");
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
    #region
    public class App9
    {
        private string MyMethod(string name)
        {
            try
            {
                if(name == "robbin")
                    throw new ArgumentNullException($"Bad Name: {name}");
                if(name == "robbinl")
                    throw new FormatException($"Bad Name: {name}");
                if(name == "robbinlaw")
                    throw new FieldAccessException($"Bad Name: {name}");
                return $"MyMethod try: Good Name: {name}";
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"ArgumentNullException: {ex.Message}");
                return "ArgumentNullException";
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"FormatException: {ex.Message}");
                throw;
                //return "FormatException";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                //throw;
                //return "CatchAllException";
            }
            finally
            {
                Console.WriteLine("The finally runs exception or not");
                //can only have one finally per try
                //cannot have a return in finally
                //return "finally";
            }
            Console.WriteLine("This code will run if the catch does not have a return");
            Console.WriteLine("This code will also run if the try is successful and does not have a return");
            return "funny thing";  
        }
        public void App(string demoName)
        {
            try
            {
                Console.WriteLine($"{demoName} started");
                Console.Write($"Enter your name: ");
                string myName = Console.ReadLine();
                string returnedString = MyMethod(myName);
                Console.WriteLine($"App try: returned string: {returnedString}");
                Console.WriteLine($"{demoName} ended");
                Console.WriteLine("");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in {demoName}: {ex.Message}");
            }
        }
    }
    #endregion
    #region
    public class App10
    {
        private double getNumber(string prompt, double low, double high)
        {
            double num = 0.0;
            bool invalidInput = true;
            while (invalidInput)
            {
                try
                {
                    Console.WriteLine($"{prompt} between {low:n1} and {high:n1}: ");
                    num = double.Parse(Console.ReadLine());
                    if (num < low || num > high)
                    {
                        throw new Exception("Invalid Input");
                    }
                    invalidInput = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
            return num;
        }
        private double circleArea(double radius)
        {
            double result = Math.PI * radius * radius;
            return result;
            // return (Math.PI * radius * radius);
        }
        private double circleCircumference(double radius)
        {
            return (2 * Math.PI * radius);
        }
        public void App(string demoName)
        {
            try
            {
                Console.WriteLine($"{demoName} started");
                double radius = getNumber("Enter Circle Radius", 2.0, 6.0);
                double areaCalc = circleArea(radius);
                Console.WriteLine($"The Circle Area is: {areaCalc:n2}");
                Console.WriteLine($"The Circle Area is: {circleArea(radius):n2}");
                Console.WriteLine($"The Circle Circumference is: {circleCircumference(radius):n2}");
                Console.WriteLine($"{demoName} ended");
                Console.WriteLine("");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in {demoName}: {ex.Message}");
            }
        }
    }
    #endregion
    #region
    public class App11
    {
        public void App(string demoName)
        {
            try
            {
                Console.WriteLine($"{demoName} started");
                
                Console.WriteLine($"{demoName} ended");
                Console.WriteLine("");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in {demoName}: {ex.Message}");
            }
        }
    }
    #endregion
    #region
    public class App12
    {
        public void App(string demoName)
        {
            try
            {
                Console.WriteLine($"{demoName} started");
                
                Console.WriteLine($"{demoName} ended");
                Console.WriteLine("");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in {demoName}: {ex.Message}");
            }
        }
    }
    #endregion
}