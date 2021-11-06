using System;
using System.Collections.Generic;

namespace Arrays
{
    #region
    public class App1
    {
        private int GetPositiveInt(String msg)
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
                // char myChar = 'a';
                char[] myCharArray = {'c', 'd', 'e'};
                int[] myIntArray = {1, 2, 4, 7};
                int myDoubleArraySize = 2;
                double[] myDoubleArray = new double[myDoubleArraySize];
                myDoubleArray[0] = 55.3;
                myDoubleArray[1] = 88.3;
                for(int i = 0; i < myDoubleArray.Length; i++)
                {
                    Console.WriteLine($"index: {i}; value: {myDoubleArray[i]}");
                }
                string[] stormStrength =
                {
                    "No Hurricane. It's just windy yo.",
                    "HURRICANE --- Category 1",
                    "HURRICANE --- Category 2",
                    "HURRICANE --- Category 3",
                    "HURRICANE --- Category 4",
                    "HURRICANE --- Category 5"
                };
                int speed = GetPositiveInt("Enter Wind speed in mph as a + int: ");
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
        private int GetPositiveInt(String msg)
        {
            try
            {
                Console.Write(msg);
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                    throw new Exception("Must be bigger than zero.");
                return num;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Invalid: {ex.Message}");
                return GetPositiveInt(msg);
            }
        }

        private double GetDouble(String msg)
        {
            try
            {
                Console.Write(msg);
                double num = double.Parse(Console.ReadLine());
                return num;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Invalid: {ex.Message}");
                return GetDouble(msg);
            }
        }

        private double[] GetArrayItems()
        {
            int size = GetPositiveInt($"Enter the number of items as a + int: ");
            double[] arr = new double[size];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = GetDouble($"Enter next number as a double: ");
            return arr;
        }

        private double AverageValueOfArrayItems(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            return sum / arr.Length;
        }

        private double MinValueOfArrayItems(double[] arr)
        {
            double min = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                        min = arr[i];
                }
                return min;
        }

        private double MaxValueOfArrayItems(double[] arr)
        {
            double max = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                        max = arr[i];
                }
                return max;
        }

        private void DisplayArrayItems(double[] arr, string msg)
        {
            Console.WriteLine(msg);
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
            Console.WriteLine();
        }

        public void App(string demoName)
        {
            try
            {
                Console.WriteLine($"{demoName} started");
                double[] numbers = GetArrayItems();
                DisplayArrayItems(numbers, "Entered Numbers:");
                double avg = AverageValueOfArrayItems(numbers);
                Console.WriteLine("The average value is " + avg);
                double min = MinValueOfArrayItems(numbers);
                double max = MaxValueOfArrayItems(numbers);
                Console.WriteLine($"min: {min} max: {max}");
                // Sort array in ascending order.
                Array.Sort(numbers);
                DisplayArrayItems(numbers, "Sorted Accending:");
                // reverse array to sort in decending order.
                Array.Reverse(numbers);
                DisplayArrayItems(numbers, "Sorted Decending");
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
        private int GetPositiveInt(String msg)
        {
            try
            {
                Console.Write(msg);
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                    throw new Exception("Must be bigger than zero.");
                return num;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Invalid: {ex.Message}");
                return GetPositiveInt(msg);
            }
        }
        
        private int GetIntBetweenMinMax(String msg, int min, int max)
        {
            try
            {
                Console.Write(msg);
                int num = int.Parse(Console.ReadLine());
                if (num < min || num > max)
                    throw new Exception($"Must be between {min} and {max}");
                return num;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Invalid: {ex.Message}");
                return GetIntBetweenMinMax(msg, min, max);
            }
        }
        private const string SPECIALCHARACTERS = @",:;\/!?@#$%^&*~`0123456789";
        private string GetString(String msg)
        {
            try
            {
                Console.Write(msg);
                string str = Console.ReadLine();
                foreach(char character in SPECIALCHARACTERS)
                if (str.Contains(character))
                    throw new FormatException($"String contains an invalid character.");
                return str;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Invalid: {ex.Message}");
                return GetString(msg);
            }
        }
        private void WithArrays()
        {
            Console.WriteLine("*** Using traditional arrays where size must be statically set at declaration ***");
            var studentCount = GetPositiveInt("How many students in your class? ");
            string[] studentNames = new string[studentCount];
            int[] studentGrades = new int[studentCount];
            for (int i = 0; i < studentCount; i++)
            {
                studentNames[i] = GetString("Student Name: ");
                studentGrades[i] = GetIntBetweenMinMax("Student Grade: ", 0, 100);
            }
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"Name: {studentNames[i]}, Grade: {studentGrades[i]}");
            }
        }

        private void WithLists()
        {
            Console.WriteLine("*** Using dynamic arrays called lists where size is not set at declaration ***");
            List<string> studentNames = new List<string>();
            List<int> studentGrades = new List<int>();
            var adding = true;
            while(adding)
            {
                studentNames.Add(GetString("Student Name: "));
                studentGrades.Add(GetIntBetweenMinMax("Student Grade: ", 0, 100));
                if (GetString("Add another? y/n: ") == "n")
                    adding = false;
            }
            for (int i = 0; i < studentNames.Count; i++)
            {
                Console.WriteLine($"Name: {studentNames[i]}, Grade: {studentGrades[i]}");
            }
        }

        public void App(string demoName)
        {
            try
            {
                Console.WriteLine($"{demoName} started");
                WithArrays();
                WithLists();
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