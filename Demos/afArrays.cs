using System;

namespace Arrays
{
    #region
    public class App1
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
                int speed = GetInt("Enter Wind speed in mph as a + int: ");
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

        private double[] GetItems()
        {
            int size = GetInt($"Enter the number of items as a + int: ");
            double[] arr = new double[size];
            for (int i = 0; i < size; i++)
                arr[i] = GetDouble($"Enter next number as a + double: ");
            return arr;
        }

        private double AverageValueOfArrayElements(double[] arr)
        {
            double sum = 0;
            foreach(double num in arr)
                sum += num;
            return sum / arr.Length;
        }

        private void DisplayArrayElements(double[] arr)
        {
            Console.WriteLine("Number List:");
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
            Console.WriteLine();
        }

        private void ShuffleArrayElements(double[] arr)
        {
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                int randIdx = r.Next(arr.Length);
                double tmp = arr[i];
                arr[i] = arr[randIdx];
                arr[randIdx] = tmp;
            }
        }

        /* Sort with SELECTION SORT */
        static void SortArrayElementsDescending(double[] arr)
        {
            for (int scanIdx = 0; scanIdx < arr.Length - 1; scanIdx++)
            {
                int maxIdx = scanIdx;
                for (int i = scanIdx + 1; i < arr.Length; i++)
                {
                    if (arr[i] > arr[maxIdx])
                        maxIdx = i;
                }
                if (maxIdx != scanIdx)
                {
                    Swap(arr, scanIdx, maxIdx);
                }
            }
        }

        static void Swap(double[] arr, int a, int b)
        {
            double tmp = arr[a];
            arr[a] = arr[b];
            arr[b] = tmp;
        }

        public void App(string demoName)
        {
            try
            {
                Console.WriteLine($"{demoName} started");
                double[] numbers = GetItems();
                DisplayArrayElements(numbers);
                ShuffleArrayElements(numbers);
                DisplayArrayElements(numbers);
                double avg = AverageValueOfArrayElements(numbers);
                Console.WriteLine("The average value is " + avg);
                SortArrayElementsDescending(numbers);
                DisplayArrayElements(numbers);
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
                // Declare and create a new array of int
                int[] deck = new int[52];
                // Declare and initialize a string array.
                string[] suits = { "Spades", "Hearts", "Diamonds", "Clubs" };
                // Declare another array named Ranks
                string[] ranks = {"2", "3", "4", "5", "6", "7", "8", "9", "10",
                                "Jack", "Queen", "King", "Ace"};
                for (int i = 0; i < deck.Length; i++)
                    deck[i] = i;
                // Shuffle the Cards
                Random keygen = new Random();
                for (int i = 0; i < deck.Length; i++)
                {
                    int rndIdx = keygen.Next(deck.Length);
                    int tmp = deck[i];
                    deck[i] = deck[rndIdx];
                    deck[rndIdx] = tmp;
                }
                for (int i = 0; i < 5; i++)
                {
                    int card = deck[i];
                    string suit = suits[card / 13];
                    string rank = ranks[card % 13];
                    Console.WriteLine($"Card {i+1}: {rank} of {suit}");
                }
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