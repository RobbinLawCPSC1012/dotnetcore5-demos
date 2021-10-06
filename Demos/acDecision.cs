using System;

namespace Decision
{
    #region
    public class App1
    {
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            Console.Write($"Please enter any value between 1 and 4: ");
            double myDouble = double.Parse(Console.ReadLine());
            if (myDouble > 3.0)
                Console.WriteLine($"The number is > 3");
            if (myDouble > 4.0)
                Console.WriteLine($"The number is > 4");
            if (myDouble < 3.0)
                Console.WriteLine($"The number is < 3");

            if (myDouble > 3.0)
                Console.WriteLine($"The number is > 3");
            else
                Console.WriteLine($"The number is < 3");

            if (myDouble > 3.0)
                Console.WriteLine($"The number is > 3");
            else if (myDouble < 2.0)
                Console.WriteLine($"The number is < 2");
            else
                Console.WriteLine($"The number is > 2 but < 3");
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
    #region
    public class App2
    {
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            const double CUTOFF = 50.0;
            double level1,
                   level2,
                   level3,
                   average;
            Console.Write("Enter First Pollution level reading (10 to 100): ");
            level1 = double.Parse(Console.ReadLine());
            Console.Write("Enter Second Pollution level reading (10 to 100):");
            level2 = double.Parse(Console.ReadLine());
            Console.Write("Enter Third Pollution level reading (10 to 100): ");
            level3 = double.Parse(Console.ReadLine());
            average = (level1 + level2 + level3) / 3;
            // Check for hazardous condition.
            if (average >= CUTOFF)
                Console.WriteLine("HAZARDOUS CONDITION!!1");
            else
                Console.WriteLine("Nah it's safe.");
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
            // Prompt for and read in an integer
            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());
            // Display message if number is divisible by 2 and 3.
            if (num % 2 == 0 && num % 3 == 0)
            {
                Console.WriteLine($"{num} is divisible by 2 and 3.");
            }
            if (num % 2 == 0 || num % 3 == 0)
            {
                Console.WriteLine($"{num} is divisible by 2 OR 3.");
            }
            if (num % 2 == 0 ^ num % 3 == 0)
            {
                Console.WriteLine($"{num} is divisible by 2 XOR 3.");
            }
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
            const double exerciseWeight = 30;
            const double quizWeight = 20;
            const double coreWeight = 25;
            const double advancedWeight = 25;
            Console.Write("Enter in users's In-Class Exercise score in %: ");
            double exerciseScore = double.Parse(Console.ReadLine());
            double exWeightVal = exerciseWeight * (exerciseScore / 100);
            Console.Write("Enter in users's Quiz score in %: ");
            double quizScore = double.Parse(Console.ReadLine());
            double quizWeightVal = quizWeight * (quizScore / 100);
            Console.Write("Enter in users's Core Portfolio score in %: ");
            double coreScore = double.Parse(Console.ReadLine());
            double coreWeightVal = coreWeight * (coreScore / 100);
            Console.Write("Enter in users's Advanced Core Portfolio score in %: ");
            double advancedScore = double.Parse(Console.ReadLine());
            double advWeightVal = advancedWeight * (advancedScore / 100);
            double weightTotal = exWeightVal + quizWeightVal + coreWeightVal + advWeightVal;
            if (weightTotal >= 50 && (exerciseScore >= 50) && (quizScore >= 50) && (coreScore >= 50))
                Console.WriteLine("Student has passed!");
            else
                Console.WriteLine("Student FAIL.");
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
            Console.Write("Enter Wind speed in mph as an integer: ");
            int speed = int.Parse(Console.ReadLine());
            if (speed >= 74 && speed <= 95)
                Console.WriteLine($"STORM LEVEL: HURRICANE --- Category 1");
            else if (speed >= 96 && speed <= 110)
                Console.WriteLine($"STORM LEVEL: HURRICANE --- Category 2");
            else if (speed >= 111 && speed <= 130)
                Console.WriteLine($"STORM LEVEL: HURRICANE --- Category 3");
            else if (speed >= 131 && speed <= 155)
                Console.WriteLine($"STORM LEVEL: HURRICANE --- Category 4");
            else if (speed > 155)
                Console.WriteLine($"STORM LEVEL: HURRICANE --- Category 5");
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
            double width, height, woodLength, glassArea;
            const double MAX_WIDTH = 5.0;
            const double MIN_WIDTH = 0.5;
            const double MAX_HEIGHT = 3.0;
            const double MIN_HEIGHT = 0.75;
            string widthString, heightString;
            Console.Write("Give the width of the window : ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            if (width < MIN_WIDTH)
            {
                Console.WriteLine("Width is too small.\n\n ");
                Console.WriteLine("Using minimum");
                width = MIN_WIDTH;
            }
            if (width > MAX_WIDTH)
            {
                Console.WriteLine("Width is too large.\n\n");
                Console.WriteLine("Using maximum");
                width = MAX_WIDTH;
            }
            Console.Write("Give the height of the window : ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            if (height < MIN_HEIGHT)
            {
                Console.WriteLine("Height is too small.\n\n");
                Console.WriteLine("Using minimum");
                height = MIN_HEIGHT;
            }
            if (height > MAX_HEIGHT)
            {
                Console.WriteLine("Height is too large.\n\n");
                Console.WriteLine("Using maximum");
                height = MAX_HEIGHT;
            }
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
                woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
                glassArea + " square metres");
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
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            bool isLeapYear = false;
            // (if year is divisible by 4 AND the year is not divisible by 100)
            // OR the year is divisible by 400.
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                isLeapYear = true;
            if (isLeapYear)
                Console.WriteLine($"{year} is a leap year!");
            else
                Console.WriteLine($"{year} is NOT a leap year.");
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
            // Get user Input
            Console.WriteLine("Enter student's grade % (0-100):");
            int grade = int.Parse(Console.ReadLine());
            // Store our letter grade in a string.
            string letterGrade;
            // Calculate our letter grade with If statements.
            if (grade > 100)
                letterGrade = "X";
            else if (grade >= 80 && grade <= 100)
                letterGrade = "A";
            else if (grade >= 70 && grade <= 79)
                letterGrade = "B";
            else if (grade >= 60 && grade <= 69)
                letterGrade = "C";
            else if (grade >= 50 && grade <= 59)
                letterGrade = "D";
            else if (grade >= 0 && grade <= 49)
                letterGrade = "F";
            else
                letterGrade = "X";
            // If we have an invalid letter grade, let the user know.
            if (letterGrade == "X")
                Console.WriteLine("Invalid score entered.");
            else
                Console.WriteLine($"The letter Grade is:  {letterGrade}");
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
            Console.Write("Enter 1, 2, or 3: ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 == 1)
                Console.WriteLine("One");
            else if (num1 == 2)
                Console.WriteLine("Two");
            else if (num1 == 3)
                Console.WriteLine("Three");
            else
                Console.WriteLine("Invalid 1.");

            // Determine the number entered.
            switch (num1)
            {
                case int num when num == 1:
                    Console.WriteLine("One One");
                    break;

                case 2:
                    Console.WriteLine("Two Two");
                    break;

                case 3:
                    Console.WriteLine("Three Three");
                    break;

                default:
                    Console.WriteLine("Invalid 2.");
                    break;
            }
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
            // Prompt the user for a grade of pet food.
            Console.WriteLine("Our pet food is available in three grades.");
            Console.WriteLine("A, B, and C. Which do you want pricing for? ");
            //char foodGrade = char.Parse(Console.Read());
            string foodGrade = Console.ReadLine().ToUpper();
            Console.WriteLine("Please enter a char");
            char foodGradeChar = char.Parse(Console.ReadLine());
            switch (foodGradeChar)
            {
                case 'A':
                    Console.WriteLine(foodGradeChar);
                    break;
                default:
                    Console.WriteLine("Hey");
                    break;
            }
            switch (foodGrade)
            {
                case "A":
                    Console.WriteLine("30c per lb.");
                    break;
                case "B":
                    Console.WriteLine("20c per lb.");
                    break;
                case "C":
                    Console.WriteLine("15c per lb.");
                    break;
                default:
                    Console.WriteLine("Invalid Choice.");
                    break;
            }
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
            // Prompt the user to enter the name of a season.
            Console.WriteLine("Enter the name of a season: ");
            string season = Console.ReadLine().ToLower();
            string spanish = "";
            switch (season)
            {
                case "spring":
                    spanish = "La Primavera";
                    break;
                case "summer":
                    spanish = "El Verano";
                    break;
                case "autumn":
                case "fall":
                    spanish = "El Otoño";
                    break;
                case "winter":
                    spanish = "El Invierno";
                    break;
                default:
                    spanish = "Incorrect Input";
                    break;
            }
            Console.WriteLine(spanish);
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
            Console.Write("Enter the Sale Total (before tax): ");
            double beforeTax = double.Parse(Console.ReadLine());
            Console.Write("Enter your province: ");
            string provinceStr = Console.ReadLine();
            double taxRate;
            switch (provinceStr.ToLower())
            {
                case "british columbia":
                case "bc":
                    taxRate = 0.12;
                    break;
                case "saskatchewan":
                case "sk":
                    taxRate = 0.11;
                    break;
                case "manitoba":
                case "mb":
                case "ontario":
                case "on":
                    taxRate = 0.13;
                    break;
                case "quebec":
                case "qc":
                    taxRate = 0.14975;
                    break;
                case "newfoundland and labrador":
                case "newfoundland":
                case "nl":
                case "new brunswick":
                case "nb":
                case "nova scotia":
                case "ns":
                case "prince edward island":
                case "pe":
                    taxRate = 0.15;
                    break;
                case "alberta":
                case "ab":
                case "yukon":
                case "yt":
                case "northwest territories":
                case "nt":
                case "nunavut":
                case "nu":
                    taxRate = 0.05;
                    break;
                default:
                    taxRate = -1;
                    break;
            }
            double salesTax;
            double finalPrice;
            if (taxRate < 0) // Check for invalid Input
                Console.WriteLine("Invalid Input.");
            else
            {
                salesTax = beforeTax * taxRate;
                finalPrice = beforeTax + salesTax;
                Console.WriteLine($"Item Price: {beforeTax:C}");
                Console.WriteLine($"Sales Tax: {salesTax:C}");
                Console.WriteLine($"Price for item in {provinceStr}: {finalPrice:C}");
            }
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
}