using System;

namespace demos
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new Program();
            app.App1("For Loop Simple Demo");
            app.App2("For Loop ClassAve Demo");
            app.App3("For Loop TotalSales Demo");

            
           // return 0;
        }
        #region
        private void App(string demoName)
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
        private void App1(string demoName)
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
        private void App2(string demoName)
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
        private void App3(string demoName)
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
