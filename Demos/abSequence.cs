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
            Console.WriteLine($"{"howMany:",8} [{howMany,-10:d2}] lamps");
            //right justified, decimal whole number, 3 digits 
            Console.WriteLine($"{"howMany:",8} [{howMany,10:d3}] lamps");
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
            //String building by forming one long string.
            string desc =
                $"\n{"Name:",15} {name,-8}" +
                $"\n{"Price:",15} {price,-8:c}" +
                $"\n{"How Many:",15} {howMany,-8:d}" +
                $"\n{"Height:",15} {height,-8:n} cm" +
                $"\n{"Has Light Bulb:",15} {hasLightBulb,-8}\n";
            Console.WriteLine(desc);
            //https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/string-interpolation
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

            // Console.WriteLine("  Room");
            // double roomWidth = getSafeDouble("     Width: ");
            // double roomLength = getSafeDouble("     Length: ");

            // Console.WriteLine("  Window");
            // double windowWidth = getSafeDouble("     Width: ");
            // double windowHeight = getSafeDouble("     Height: ");

            // Console.WriteLine("  Door");
            // double doorWidth = getSafeDouble("     Width: ");
            // double doorHeight = getSafeDouble("     Height: ");

            // Console.WriteLine("  Closet");
            // double closetWidth = getSafeDouble("     Width: ");
            // double closetHeight = getSafeDouble("     Height: ");

            // Console.WriteLine("  Paint");
            // Console.WriteLine("     1. Basic 29.99 / gallon");
            // Console.WriteLine("     2. Premium 39.99 / gallon");
            // Console.WriteLine("     3. Deluxe 49.99 / gallon");
            // int paintGrade = getSafeInt("     Choose your paint grade: ");

            // Console.WriteLine("  Flooring");
            // Console.WriteLine("     1. Carpet / 2.75 ^ft.");
            // Console.WriteLine("     2. Tile  / 3.50 ^ft.");
            // Console.WriteLine("     3. Hardowood  / 4.85 ^ft.");
            // int flooringType = getSafeInt("     Choose your flooring: ");

            // double casingPrice = getSafeDouble("\n  Casing Price: ");
            // double baseBoardPrice = getSafeDouble("\n  Baseboard Price: ");

            double roomWidth = 10;
            double roomLength = 12;
            double windowWidth = 4.5;
            double windowHeight = 3.0;
            double doorWidth = 2.5;
            double doorHeight = 7.0;
            double closetWidth = 5.0;
            double closetHeight = 7.0;
            int paintGrade = 3;
            int flooringType = 2;
            double casingPrice = 1.29;
            double baseBoardPrice = 2.59;

            //////////////////////////////////////////////////////////////////////////////////////////////
            // calculate wall area 
            double wallArea = (roomLength * 2 * 8 + roomWidth * 2 * 8) - (windowWidth * windowHeight + doorHeight * doorWidth + closetHeight * closetWidth);

            //////////////////////////////////////////////////////////////////////////////////////////////
            // calculate casing
            double casingLength = windowHeight * 2 + windowWidth * 2 + doorWidth + doorHeight * 2 + closetWidth + closetHeight * 2;
            casingLength *= 1.1;

            //////////////////////////////////////////////////////////////////////////////////////////////
            // calculate baseboard
            double baseBoardLength = roomWidth * 2 + roomLength * 2 - doorWidth - closetWidth;
            baseBoardLength *= 1.1;

            //////////////////////////////////////////////////////////////////////////////////////////////
            // calculate flooring 
            double floorArea = roomWidth * roomLength;

            //////////////////////////////////////////////////////////////////////////////////////////////
            // calculate baseboard and casing cost
            double casingCost = Math.Round(casingPrice * casingLength,2,MidpointRounding.ToEven);
            double baseBoardCost = Math.Round(baseBoardPrice * baseBoardLength,2,MidpointRounding.ToEven);



            //////////////////////////////////////////////////////////////////////////////////////////////
            // set paint price and description

            double paintPrice = 0.0;
            double dGallons = 0.0;
            string paintDescription = "none";

            switch (paintGrade)
            {
                case 1:
                    {
                        dGallons = wallArea / 300 + floorArea / 200;
                        paintPrice = 29.99;
                        paintDescription = "Basic paint";

                        break;
                    }
                case 2:
                    {
                        dGallons = wallArea / 400 + floorArea / 250;
                        paintPrice = 39.99;
                        paintDescription = "Premium paint";


                        break;
                    }
                case 3:
                    {
                        dGallons = wallArea / 500 + floorArea / 300;
                        paintPrice = 49.99;
                        paintDescription = "Deluxe paint ";
                        break;
                    }
                
            }
            int iGallons = (int)Math.Ceiling(dGallons);
            double paintCost = iGallons * paintPrice;

            //////////////////////////////////////////////////////////////////////////////////////////////
            // set flooring cost and description
            double flooringPrice = 0.0;
            string flooringDescription = "none";

            if (flooringType == 1)
            {
                flooringPrice = 2.75;
                flooringDescription = "Carpet";
            }
            else if (flooringType == 2)
            {
                flooringPrice = 3.50;
                flooringDescription = "Tile";
            }
            else
            {
                flooringPrice = 4.85;
                flooringDescription = "Hardwood";
            }

            double flooringCost = Math.Round(floorArea * flooringPrice,2,MidpointRounding.ToEven);
            string sFlooringCost = string.Format("{0:0.00}", flooringCost);        
            
            //////////////////////////////////////////////////////////////////////////////////////////////
            // calculate totals
            double netTotal = paintCost + flooringCost + casingCost + baseBoardCost;
            double GST = Math.Round(netTotal * .05,2,MidpointRounding.ToEven);
            double total = netTotal + GST;
            string desc =
                $"\n{"Packing Slip",40}" +
                $"\n{"*******************************************************************",50}" +
                $"\n{"Wall Area (sqft):",35} {wallArea,-8:n}" +
                $"\n{"Ceiling Area (sqft):",35} {floorArea,-8:n}" +
                $"\n{"Required Paint (Gallons):",35} {iGallons,-8:n}{"@",-1} {paintPrice,-8:c}{"=",-1} {paintCost,-8:c}" +
                $"\n{"Hardwood Required (ft):",35} {floorArea,-8:n}{"@",-1 } {flooringPrice,-8:c}{"=",-1} {sFlooringCost,-8:c}" +
                $"\n{"Casing Required (ft):",35} {casingLength,-8:n}{"@",-1} {casingPrice,-8:c}{"=",-1} {casingCost,-8:c}" +
                $"\n{"Baseboard Required (ft):",35} {baseBoardLength,-8:n}{"@",-1} {baseBoardPrice,-8:c}{"=",-1} {baseBoardCost,-8:c}" +
                $"\n{"Net Total:",35}{"=",20} {netTotal,-8:c}" +
                $"\n{"GST:",35}{"=",20} {GST,-8:c}" +
                $"\n{"Total:",35}{"=",20} {total,-8:c}";
            Console.WriteLine(desc);


        // static public int getSafeInt(string prompt)
        // {
        //     int dInput = 0;
        //     bool bValid = false;
        //     while (!bValid)
        //     {
        //         try
        //         {
        //             Console.Write(prompt);
        //             dInput = Convert.ToInt32(Console.ReadLine());
        //             bValid = true;
        //         }
        //         catch (Exception e)
        //         {
        //             Console.WriteLine("\nInvalid input... try again.");
        //         }
        //     }

        //     return dInput;
        // }

        // static public double getSafeDouble(string prompt)
        // {
        //     double dInput = 0.0;
        //     bool bValid = false;
        //     while (!bValid)
        //     {
        //         try
        //         {
        //             Console.Write(prompt);
        //             dInput = Convert.ToDouble(Console.ReadLine());
        //             bValid = true;
        //         }
        //         catch (Exception e)
        //         {
        //             Console.WriteLine("\nInvalid input... try again.");
        //         }
        //     }

        //     return dInput;
        // }




            // double wallArea = 286.0;
            // double ceilingArea = 120.0;
            // double gallonsRequired = 1.0;
            // double hardwood = 120.0;
            // double casing = 55.55;
            // double baseboard = 40.15;
            // double netTotal = 645.64;
            // double gst = 32.28;
            // double total = 677.92;

            
            // Console.WriteLine($"{demoName} ended");
            // Console.WriteLine("");
        }
    }
    #endregion
}