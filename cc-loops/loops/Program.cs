using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new Program();
            app.ForLoop();
           // return 0;
        }
        #region X
        private void X()
        {
            try
            {
                Console.WriteLine("X Demo started");
                
                Console.WriteLine("X Demo ended");
                Console.WriteLine("");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in X: {ex.Message}");
            }
            
        }
        #endregion
        #region ForLoop
        private void ForLoop()
        {
            string methodName = "ForLoop Demo";
            try
            {
                Console.WriteLine($"{methodName} started");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("I will not sleep in class.");
                }
                Console.WriteLine($"{methodName} ended");
                Console.WriteLine("");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in {methodName}: {ex.Message}");
            }
            
        }
        #endregion
        #region ForClassAve
        private void ForClassAve()
        {
            try
            {
                Console.WriteLine("ForClassAve Demo started");
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
                Console.WriteLine("ForClassAve Demo ended");
                Console.WriteLine("");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in ForClassAve: {ex.Message}");
            }
            
        }
        #endregion
        #region ForTotalSales
        private void ForTotalSales()
        {
            try
            {
                Console.WriteLine("ForTotalSales Demo started");
                
                Console.WriteLine("ForTotalSales Demo ended");
                Console.WriteLine("");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in ForTotalSales: {ex.Message}");
            }
            
        }
        #endregion
    }
}
