//https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/string-interpolation

using System;

namespace Sequence
{
    #region
    public class App1
    {
        public void App(string demoName)
        {
            //A string without the $ is the old way of using strings.
            Console.WriteLine("Hello Everybody");
            //A string with the $ in front means use string interpolation
            //It is the new way. We will use this all the time.
            Console.WriteLine($"Hello Everybody");
            Console.WriteLine($"");
        }
    }
    #endregion
    #region
    public class App2
    {
        public void App(string demoName)
        {
            //Console.WriteLine inserts new line characters CR (carriage return) and LF (line feed)
            Console.WriteLine($"Programming is Fun!");
            Console.WriteLine($"I just can't get enough of it.");
            //Console.Write function does not insert new line characters.
            Console.Write($"Programming is ");
            Console.Write($"FUN.");
            /*
             * We use ESCAPE-CHARACTERS to represent special or otherwise
             * un-typeable symbols inside our strings. Escape characters are
             * preceded by a BACKSLASH '\' .
             */
            Console.WriteLine($"\nMy real name is \"Robbin Law\".");
            Console.Write($"These are our top sellers:\n");
            Console.Write($"\tApples\n\tBananas\n\tTomatoes\n");
            Console.WriteLine($"");
        }
    }
    #endregion
    #region
    public class App3
    {
        public void App(string demoName)
        {
            //explicitly typed variables
            string myString = "Robbin";
            int myInt = 15;
            double myDouble = 6.66;
            bool myBool = true;
            //With string interpolation we can inject variables by placing
            //them in between {}.
            Console.WriteLine($"{myString}, {myInt}, {myDouble}, {myBool}");
            //implicitly typed variables
            var foo = "Apple";
            var bar = 15;
            Console.WriteLine($"{foo}, {bar}");
            Console.WriteLine($"");
        }
    }
    #endregion
    #region
    public class App4
    {
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            Console.WriteLine($"");
            string name = "Lamp";
            int howMany = 34;
            double price = 4.52;
            double height = 1234.1283;
            bool hasLightBulb = true;
            //String building with multiple Console.WriteLine statements.
            //When a string begins with $ then whenever there is an {} 
            //inside is variable or literalstring contents,justify format:presentation format.
            //left justified, decimal whole number, 2 digits
            Console.WriteLine($"{"howMany:",8} [{howMany,-10:d3}] lamps");
            //right justified, decimal whole number, 3 digits 
            Console.WriteLine($"{"howMany:",8} [{howMany,10:d4}] lamps");
            //right justified, numeric 3 decimals  
            Console.WriteLine($"{"howMany:",8} [{howMany,10:n3}] lamps");
            //left justified, numeric 2 decimals  
            Console.WriteLine($"{"height:",8} [{height,-10:n2}] cm");
            //right justified, numeric 3 decimals  
            Console.WriteLine($"{"height:",8} [{height,10:n3}] cm");
            //left justified, currency 2 decimals  
            Console.WriteLine($"{"price:",8} [{price,-10:c2}]");
            //right justified, currency 3 decimals  
            Console.WriteLine($"{"price:",8} [{price,10:c3}]");
            //right justified, numeric 1 decimals  
            Console.WriteLine($"{"price:",8} [{price,10:n1}]");  
            //String building by forming one long string using concatenation.
            string desc =
                $"\n{"Name:",15} {name,-8}" +
                $"\n{"Price:",15} {price,-8:c}" +
                $"\n{"How Many:",15} {howMany,-8:d}" +
                $"\n{"Height:",15} {height,-8:n} cm" +
                $"\n{"Has Light Bulb:",15} {hasLightBulb,-8}\n";
            Console.WriteLine(desc);
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine($"");
        }
    }
    #endregion
    #region
    public class App5
    {
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            int hamburgerNumber = 2;
            decimal hamburgerPrice = 8.56M;
            decimal hamburgerCost = hamburgerNumber * hamburgerPrice;
            int beerNumber = 3;
            decimal beerPrice = 5.20M;
            decimal beerCost = beerNumber * beerPrice;
            decimal netTotal = hamburgerCost + beerCost;
            decimal GST = netTotal * 0.05M;
            decimal total = netTotal + GST;
            string desc =
                $"\n{"Packing Slip",30}" +
                $"\n{"************************************************",25}" +
                $"\n{"Hamburgers:",15} {hamburgerNumber,-8:d}{"@",-1} {hamburgerPrice,-8:c}{"=",-1} {hamburgerCost,-8:c}" +
                $"\n{"Beers:",15} {beerNumber,-8:d}{"@",-1 } {beerPrice,-8:c}{"=",-1} {beerCost,-8:c}" +
                $"\n{"Net Total:",15}{"=",20} {netTotal,-8:c}" +
                $"\n{"GST:",15}{"=",20} {GST,-8:c}" +
                $"\n{"Total:",15}{"=",20} {total,-8:c}" +
                $"\n";
            Console.WriteLine(desc);
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
            int myInt1 = 8;
            int myInt2 = 5;
            double myDouble1 = 8.0;
            double myDouble2 = 5.0;
            double myDouble3 = 6.0;
            int myIntAnswer;
            double myDoubleAnswer;

            myIntAnswer = myInt1 / myInt2; //only gives the whole part of division
            Console.WriteLine($"The answer is: {myIntAnswer}");
            myIntAnswer = myInt2 / myInt1; //only gives the whole part of division
            Console.WriteLine($"The answer is: {myIntAnswer}");
            myIntAnswer = myInt1 % myInt2; //gives the remainder of division
            Console.WriteLine($"The remainder is: {myIntAnswer}");

            myIntAnswer = myInt1 / (int)myDouble2; //only gives the whole part of division as the double is cast to an int
            Console.WriteLine($"The answer is: {myIntAnswer}");
            myIntAnswer = (int)myDouble2 / myInt1; //only gives the whole part of division as the double is cast to an int
            Console.WriteLine($"The answer is: {myIntAnswer}");
            myIntAnswer = (int)myDouble1 % myInt2; //gives the remainder of division as the double is cast to an int
            Console.WriteLine($"The remainder is: {myIntAnswer}");

            myDoubleAnswer = myDouble1 / myDouble2; //only gives the whole part of division as the double is cast to an int
            Console.WriteLine($"The answer is: {myDoubleAnswer}");
            myDoubleAnswer = myDouble2 / myDouble1; //only gives the whole part of division as the double is cast to an int
            Console.WriteLine($"The answer is: {myDoubleAnswer}");

            myDoubleAnswer = myDouble1 + myDouble2 * myDouble3 / myDouble1;  
            //multiplication and Division precede Add and Substract
            //when at the same level left to right so here Mult first, then Divide, then Add
            Console.WriteLine($"The answer is:  {myDoubleAnswer:n3}");

            myDoubleAnswer = (myDouble1 + myDouble2) * myDouble3 / myDouble1;
            //multiplication and Division precede Add and Substract
            //when at the same level left to right so here Mult first, then Divide, then Add
            Console.WriteLine($"The answer is:  {myDoubleAnswer:n3}");
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
            string name;
            int age;
            double annualPay;
            
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your annual salary:");
            annualPay = double.Parse(Console.ReadLine());

            Console.WriteLine($"My name is {name}, my age is {age} " +
                              $"and I hope to earn {annualPay:c} per year.");
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
            double myRadius;
            double myPi = Math.PI;
            double myCircumference;
            Console.Write("Enter the Radius as a double: ");
            myRadius = double.Parse(Console.ReadLine());
            myCircumference = 2.0 * myPi * myRadius;
            Console.WriteLine($"The Radius was {myRadius:n} and its Circumference is {myCircumference:n}");
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
            double x1, x2, t1, t2, avgVel;
            Console.WriteLine("Enter points x1 and x2: ");
            x1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter times t1 and t2: ");
            t1 = double.Parse(Console.ReadLine());
            t2 = double.Parse(Console.ReadLine());
            avgVel = (x2 - x1) / (t2 - t1);
            Console.WriteLine($"The average velocity is: {avgVel}");
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
            Console.WriteLine("Enter Investment Amount:");
            double investAmt = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter annual interest rate in percentage:");
            double interestRate = double.Parse(Console.ReadLine());
            double monthlyInterest = interestRate / 100 / 12;
            Console.WriteLine("Enter Number of years:");
            int numYears = int.Parse(Console.ReadLine());
            double futureVal = investAmt * Math.Pow(1 + monthlyInterest, numYears * 12);
            Console.WriteLine($"Future Value is {futureVal:C}");
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
            // Declare variables that are Constants
            const double provTaxRate = 0.06;
            const double fedTaxRate = 0.05;
            // Inputs
            double itemPrice;
            int numItems;
            // Results
            double beforeTax;
            double totalProvTax;
            double totalFedTax;
            double totalTax;
            double totalSale;
            Console.WriteLine("Enter the item price as a double: ");
            itemPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Number of Items as an integer: ");
            numItems = int.Parse(Console.ReadLine());
            beforeTax = itemPrice * numItems;
            Console.WriteLine($"Purchase Total (before Tax): {beforeTax:C}");
            // Calculate Tax
            totalProvTax = beforeTax * provTaxRate;
            Console.WriteLine($"Total Provincial Tax: {totalProvTax:C}");
            totalFedTax = beforeTax * fedTaxRate;
            Console.WriteLine($"Total Federal Tax: {totalFedTax:C}");
            totalTax = totalProvTax + totalFedTax;
            Console.WriteLine($"Total Tax Amount: {totalTax:C}");
            totalSale = beforeTax + totalTax;
            Console.WriteLine($"Total Sale price: {totalSale:C}");
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