using System;
using System.Collections.Generic;
using System.IO;

namespace Files
{
    #region
    public class App1
    {
        public void App(string demoName)
        {
            try
            {
                Console.WriteLine($"{demoName} started");
                const string csvFileName = "Data.dat";
                string[] csvLines1 = new string[2];
                csvLines1[0] = "first,line,of,array,csv";
                csvLines1[1] = "second,line,of,array,csv";
                List<string> csvLines2 = new();
                csvLines2.Add("first,line,of,list,csv");
                csvLines2.Add("second,line,of,list,csv");
                csvLines2.Add("third,line,of,list,csv");
                //write to a csv file. requires System.IOs    
                File.WriteAllLines(csvFileName, csvLines2);
                Console.WriteLine($"Data successfully written to file at: {Path.GetFullPath(csvFileName)}");
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
        public void App(string demoName)
        {
            try
            {
                Console.WriteLine($"{demoName} started");
                const string csvFileName = "Data.dat";
                string[] csvFileInput = File.ReadAllLines(csvFileName);
                for(int i = 0; i < csvFileInput.Length; i++)
                {
                    Console.WriteLine($"lineIndex: {i}; line: {csvFileInput[i]}");
                    string[] items = csvFileInput[i].Split(',');
                    for(int j = 0; j < items.Length; j++)
                    {
                        Console.WriteLine($"itemIndex: {j}; item: {items[j]}");
                    }
                    Console.WriteLine();
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
    #region
    public class App3
    {
        private int GetIntBetweenMinMax(String msg, int min, int max)
        {
            bool inValidInput = true;
            int num = 0;
            while (inValidInput)
            {
                try
                {
                    Console.Write(msg);
                    num = int.Parse(Console.ReadLine());
                    if (num < min || num > max)
                        throw new Exception($"Must be between {min} and {max}");
                    inValidInput = false; 
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Invalid: {ex.Message}");
                }
            }
            return num;
        }
        private const string SPECIALCHARACTERS = @",:;\/!?@#$%^&*~`0123456789";
        private string GetString(String msg)
        {
            bool inValidInput = true;
            string str = "";
            while (inValidInput)
            {
                try
                {
                    Console.Write(msg);
                    str = Console.ReadLine();
                    foreach(char character in SPECIALCHARACTERS)
                    if (str.Contains(character))
                        throw new FormatException($"String contains an invalid character.");
                    inValidInput = false; 
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Invalid: {ex.Message}");
                }
            }
            return str;
        }
        const string csvFileName = "Data.dat";
        private void LoadArraysAndStoreInCSVFile(string[] studentNames, int[] studentGrades, int size)
        {
            //Load the arrays with valid values.
            for (int i = 0; i < size; i++)
            {
                studentNames[i] = GetString("Student Name: ");
                studentGrades[i] = GetIntBetweenMinMax("Student Grade: ", 0, 100);
            }
            //Create one array using the csv (comma separated values) 
            //info from the two parallel arrays.
            string[] csvLines1 = new string[size];
            for (int i = 0; i < size; i++)
            {
                csvLines1[i] = studentNames[i] + "," + studentGrades[i].ToString();
            }
            //Write the one array to a csv file line by line (each line is an element in the array).
            File.WriteAllLines(csvFileName, csvLines1);
        }
        private void ReadInCSVFileAndDisplay(string[] studentNames, int[] studentGrades, int size)
        {
            //Read each line of the file into the elements of one array.
            string[] csvFileInput = File.ReadAllLines(csvFileName);
            //Tranverse the elements of the array and for each split the string
            //using the delimiter character as the split point.
            for(int i = 0; i < csvFileInput.Length; i++)
            {
                string[] items = csvFileInput[i].Split(',');
                studentNames[i] = items[0];
                studentGrades[i] = int.Parse(items[1]);
            }
            //Print the studentName and studentGrades info to the terminal.
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Name: {studentNames[i]}, Grade: {studentGrades[i]}");
            }
        }
        public void App(string demoName)
        {
            try
            {
                Console.WriteLine($"{demoName} started");
                int studentCount = GetIntBetweenMinMax("How many students in your class? ", 0, 100);
                string[] studentNames = new string[studentCount];
                int[] studentGrades = new int[studentCount];
                LoadArraysAndStoreInCSVFile(studentNames, studentGrades, studentCount);
                Console.ReadLine();
                ReadInCSVFileAndDisplay(studentNames, studentGrades, studentCount);
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
                // Random randNum = new Random();
                // int newRandNum = 0;
                // string myDir = "temp";
                // string myFile = "test.txt";
                // string myDirPath = @"C:\temp";
                // string path = @"C:\temp\test.txt";

                // Console.WriteLine($"CurrentDirectory: {Environment.CurrentDirectory}\n");
                // Console.WriteLine($"SystemDirectory: {Environment.SystemDirectory}\n");
                // Console.WriteLine($"TempDirectory: {Environment.GetEnvironmentVariable("TEMP")}\n");

                // string fname = Path.Combine(Directory.GetCurrentDirectory(), "test.txt");
                // Console.WriteLine($"fname: {fname}");
                // if(Directory.Exists(myDirPath))
                // {
                //     Console.WriteLine($"{myDirPath} is a valid directory\n");
                // }

                // if (File.Exists(path))
                // {
                //     File.Delete(path);
                // }
                // if (!File.Exists(path))
                // {
                //     // Create a file to write to.
                //     using (StreamWriter sw = File.CreateText(path))
                //     {
                //         sw.WriteLine("program");
                //         sw.WriteLine("loop");
                //         sw.WriteLine("break");
                //         sw.WriteLine("for");
                //         sw.WriteLine("list");
                //         sw.WriteLine("method");
                //         sw.WriteLine("property");

                //     }
                    
                // }

                // List<string> wordsInFile = new List<string>();
                // List<char> charsInWord = new List<char>();
                // int wordCount = 0;

                // // check if File exists
                // if (File.Exists(path))
                // {
                    
                //     StreamReader reader = new StreamReader(path);
                //     string curLine;
                //     while ((curLine = reader.ReadLine()) != null)
                //     { 
                //         wordsInFile.Add(curLine);
                //     }
                //     reader.Close();
                //     for(int i = 0; i < wordsInFile.Count; i++)
                //     {
                //         Console.WriteLine($"word index: {i}, word: {wordsInFile[i]}");
                //     }
                //     Console.WriteLine($"");
                //     newRandNum = randNum.Next(0, wordsInFile.Count - 1);
                //     Console.WriteLine($"Random word index: {newRandNum}\n");
                //     string data = wordsInFile[newRandNum];
                //     charsInWord.AddRange(data);
                //     for (int i = 0; i < charsInWord.Count; i++)
                //     {
                //         Console.WriteLine($"char index: {i}, char: {charsInWord[i]}");
                //     }
                //     Console.WriteLine("");
                // for (int i = 0; i < charsInWord.Count; i++)
                //     {
                //         Console.Write($"{charsInWord[i]}");
                //     }
                //     Console.WriteLine("");
                // }
                // else
                // {
                //     Console.WriteLine($"The filename {path} does not exist.");
                // }
                Console.WriteLine($"{demoName} ended");
                Console.WriteLine("");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in {demoName}: {ex.Message}");
            }
        }
        #endregion
    }
}


            
    