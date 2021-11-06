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
                csvLines1[0] = "first,line,of,csv";
                csvLines1[1] = "second,line,of,csv";
                List<string> csvLines2 = new();
                csvLines2.Add("first,line,of,csv");
                csvLines2.Add("second,line,of,csv");
                csvLines2.Add("third,line,of,csv");
                //write to a csv file. requires System.IOs    
                File.WriteAllLines(csvFileName, csvLines1);
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


            
    