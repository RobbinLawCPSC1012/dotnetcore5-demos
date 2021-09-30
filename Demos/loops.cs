using System;

namespace demos
{
    class Loops
    {
        #region
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
        #endregion
        #region
        public void App1(string demoName)
        {
            try
            {
                Console.WriteLine($"{demoName} started");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("I will not sleep in class.");
                }
                //throw new Exception("ok");
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
        public void App2(string demoName)
        {
            
            try
            {
                Console.WriteLine($"{demoName} started");
                // Prompt and read number of students
                Console.Write("Enter the number of students: ");
                int numStudents = int.Parse(Console.ReadLine());
                // For Each student, prompt and read in their mark
                // Calculate a running total.
                double sumOfMarks = 0;
                double avgMark;
                double curMark;
                for (int i = 1; i <= numStudents; i++)
                {
                    Console.Write($"Enter mark for student #{i}: ");
                    curMark = double.Parse(Console.ReadLine());
                    sumOfMarks += curMark;
                }
                // Calculate average mark
                avgMark = sumOfMarks / numStudents;
                // Display average mark
                Console.WriteLine($"Average Mark: {avgMark:n2}");
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
    }
}