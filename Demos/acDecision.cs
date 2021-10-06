using System;

namespace Decision
{
    #region
    public class App1
    {
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            Console.Write($"Please enter any value: ");
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