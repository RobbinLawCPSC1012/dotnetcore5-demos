using System;

namespace demos
{
    class Loops
    {
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
                int days;
                double sales;
                double totalSales;

                Console.Write("Enter the number of days: ");
                days = int.Parse(Console.ReadLine());

                totalSales = 0;
                for (int i = 1; i <= days; i++)
                {
                    Console.Write($"Enter sales as a number for day #{i}: $ ");
                    sales = double.Parse(Console.ReadLine());
                    totalSales += sales;
                }

                Console.WriteLine($"Total Sales: {totalSales:C}");
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
                int numStudents;
                double curMark;
                double minMark = 101;
                double maxMark = -1;
                double sumOfMarks = 0;
                double avgMark;

                // Grab our input
                Console.Write("Enter number of students: ");
                numStudents = int.Parse(Console.ReadLine());

                // Loop over each of our students
                for (int i = 1; i <= numStudents; i++)
                {
                    Console.Write($"Enter mark for student # {i}: ");
                    curMark = double.Parse(Console.ReadLine());

                    // Is this the highest or lowest mark we've seen?
                    if (curMark < minMark)
                    {
                        minMark = curMark;
                    }
                    if (curMark > maxMark)
                    {
                        maxMark = curMark;
                    }

                    // Add it to our totals
                    sumOfMarks += curMark;
                }

                // Calculate the average
                avgMark = (double)sumOfMarks / numStudents;

                // Print our results
                Console.WriteLine($"\nAverage Mark: {avgMark}, Highest Mark: {maxMark}, Lowest Mark: {minMark}");                
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
        #region
        public void App6(string demoName)
        {
            try
            {
                Console.WriteLine($"{demoName} started");
                int i = 0;
                while (i < 4)
                {
                    Console.WriteLine($"WHILE {i}");
                    i++;
                }

                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"FOR {j}");
                }
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
        public void App7(string demoName)
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
        public void App8(string demoName)
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
        public void App9(string demoName)
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
        public void App10(string demoName)
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
        public void App11(string demoName)
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
        public void App12(string demoName)
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