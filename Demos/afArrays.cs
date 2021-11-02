using System;

namespace Arrays
{
    #region
    public class App1
    {
        public void App(string demoName)
        {
            try
            {
                Console.WriteLine($"{demoName} started");
                char[] myCharArray = {'c', 'd', 'e'};
                int[] myIntArray = {1, 2, 4, 7};
                double[] myDoubleArray = {3.4, 6.8, 88.88};
                string[] stormStrength =
                {
                    "No Hurricane. It's just windy yo.",
                    "HURRICANE --- Category 1",
                    "HURRICANE --- Category 2",
                    "HURRICANE --- Category 3",
                    "HURRICANE --- Category 4",
                    "HURRICANE --- Category 5"
                };
                Console.WriteLine("Enter Wind speed in mph:");
                int speed = int.Parse(Console.ReadLine());
                int stormLevel = 0;
                if (speed >= 74 && speed <= 95)
                    stormLevel = 1;
                else if (speed >= 96 && speed <= 110)
                    stormLevel = 2;
                else if (speed >= 111 && speed <= 130)
                    stormLevel = 3;
                else if (speed >= 131 && speed <= 155)
                    stormLevel = 4;
                else if (speed > 155)
                    stormLevel = 5;
                string stormString = stormStrength[stormLevel];
                Console.WriteLine($"STORM LEVEL: {stormString}");
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
    public class App2
    {
        private int GetInt(String msg)
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
                        throw new Exception("Must be bigger than zero.");
                    inValidInput = false; 
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Invalid: {ex.Message}");
                }
            }
            return num;
        }

        private double GetDouble(String msg)
        {
            bool inValidInput = true;
            double num = 0;
            while (inValidInput)
            {
                try
                {
                    Console.Write(msg);
                    num = double.Parse(Console.ReadLine());
                    if (num < 0.0)
                        throw new Exception("Must be bigger than zero.");
                    inValidInput = false; 
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Invalid: {ex.Message}");
                }
            }
            return num;
        }

        public void App(string demoName)
        {
            try
            {
                Console.WriteLine($"{demoName} started");
                int size = GetInt("Enter Size as a + integer: ");
                double[] arr = new double[size];
                double sum = 0;
                // Get Each number for the array from the user.
                for (int i = 0; i < size; i++)
                {
                    Console.Write("Enter a number: ");
                    arr[i] = GetDouble("Enter a number as a + double: ");
                    sum += arr[i];
                }
                double avg = sum / size;
                Console.WriteLine($"Num Elements: {size} Average: {avg}");
                double min = arr[0];
                double max = arr[0];
                double bigCount = 0;
                for (int i = 0; i < size; i++)
                {
                    if (arr[i] > avg)
                        bigCount++;
                    if (arr[i] < min)
                        min = arr[i];
                    if (arr[i] > max)
                        max = arr[i];
                }
                Console.WriteLine($"Number of Elements larger than average: {bigCount}");
                Console.WriteLine($"MaxElt: {max} minElt: {min}");
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
    public class App3
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
    public class App4
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
    public class App5
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
    public class App6
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
    public class App7
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
    public class App8
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
    public class App9
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
    public class App10
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