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