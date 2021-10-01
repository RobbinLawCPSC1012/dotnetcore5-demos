using System;
using System.Collections.Generic;
using System.IO;

namespace demos
{
    public class Files
    {
        #region
        public void App1()
        {
            Random randNum = new Random();
            int newRandNum = 0;
            string myDir = "temp";
            string myFile = "test.txt";
            string myDirPath = @"C:\temp";
            string path = @"C:\temp\test.txt";

            Console.WriteLine($"CurrentDirectory: {Environment.CurrentDirectory}\n");
            Console.WriteLine($"SystemDirectory: {Environment.SystemDirectory}\n");
            Console.WriteLine($"TempDirectory: {Environment.GetEnvironmentVariable("TEMP")}\n");

            string fname = Path.Combine(Directory.GetCurrentDirectory(), "test.txt");
            Console.WriteLine($"fname: {fname}");
            if(Directory.Exists(myDirPath))
            {
                Console.WriteLine($"{myDirPath} is a valid directory\n");
            }

            if (File.Exists(path))
            {
                File.Delete(path);
            }
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("program");
                    sw.WriteLine("loop");
                    sw.WriteLine("break");
                    sw.WriteLine("for");
                    sw.WriteLine("list");
                    sw.WriteLine("method");
                    sw.WriteLine("property");

                }
                
            }

            List<string> wordsInFile = new List<string>();
            List<char> charsInWord = new List<char>();
            int wordCount = 0;

            // check if File exists
            if (File.Exists(path))
            {
                
                StreamReader reader = new StreamReader(path);
                string curLine;
                while ((curLine = reader.ReadLine()) != null)
                { 
                    wordsInFile.Add(curLine);
                }
                reader.Close();
                for(int i = 0; i < wordsInFile.Count; i++)
                {
                    Console.WriteLine($"word index: {i}, word: {wordsInFile[i]}");
                }
                Console.WriteLine($"");
                newRandNum = randNum.Next(0, wordsInFile.Count - 1);
                Console.WriteLine($"Random word index: {newRandNum}\n");
                string data = wordsInFile[newRandNum];
                charsInWord.AddRange(data);
                for (int i = 0; i < charsInWord.Count; i++)
                {
                    Console.WriteLine($"char index: {i}, char: {charsInWord[i]}");
                }
                Console.WriteLine("");
            for (int i = 0; i < charsInWord.Count; i++)
                {
                    Console.Write($"{charsInWord[i]}");
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine($"The filename {path} does not exist.");
            }
        }
        #endregion
        #region
        public void App2(string demoName)
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
        #endregion
        #region
        public void App3(string demoName)
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
        #endregion
        #region
        public void App4(string demoName)
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
        #endregion
        #region
        public void App5(string demoName)
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
        #endregion
    }
}
    