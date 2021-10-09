using System;

namespace Loops
{
    #region
    public class App1
    {
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            //i++ is the same as i = i + 1
            for (int i = 1; i < 4; i++)
                    Console.WriteLine("I will not sleep in class.");
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
    #region
    public class App2
    {
        public void App(string demoName)
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
    }
    #endregion
    #region
    public class App3
    {
        public void App(string demoName)
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
    }
    #endregion
    #region
    public class App4
    {
        public void App(string demoName)
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
                    minMark = curMark;
                if (curMark > maxMark)
                    maxMark = curMark;
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
    }
    #endregion
    #region
    public class App5
    {
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
    #region
    public class App6
    {
        public void App(string demoName)
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
    }
    #endregion
    #region
    public class App7
    {
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            const double maxTemp = 39.2; // MAX TEMP in C
            // Get current temperature.
            // As long as necessary, instruct the technician to adjust temperature.
            Console.Write("Please enter new temperature: ");
            double curTemp = double.Parse(Console.ReadLine());
            while (curTemp > maxTemp)
            {
                Console.WriteLine($"Warning! Temp: {curTemp}C is too high. Decrease by {curTemp - maxTemp}");
                Console.Write("Please enter new temperature: ");
                curTemp = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Phew! You did it! Got those temperatures under control!");
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
    #region
    public class App8
    {
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            const int minPlayers = 9;
            const int maxPlayers = 15;
            int players;
            int teamSize;
            int numTeams;
            int leftOver;
            teamSize = 0;
            while (teamSize < minPlayers || teamSize > maxPlayers)
            {
                //Get number of players per team
                Console.Write("Enter Players per team (between 9-15): ");
                teamSize = int.Parse(Console.ReadLine());
            }
            // Get the number of available players
            players = 0;
            while (players < 1)
            {
                Console.Write("Enter Number of available players: ");
                players = int.Parse(Console.ReadLine());
            }
            // Calculate the number of teams
            numTeams = players / teamSize;
            // Calculate the number of left over players
            leftOver = players % teamSize;
            // display results (teams, left over)
            Console.WriteLine($"\nNumber of Teams: {numTeams} \tNumber of Left Over Players: {leftOver}");
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
    #region
    public class App9
    {
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            //Generate a random number between 1 and 100.
            Random rnd = new Random();
            int num = rnd.Next(1, 101);
            // Ask the user to guess the number until it is correct.
            // for each guess indicate if guess is "too high" "too low" or "correct".
            int guess;
            int numAttempts = 0;
            int MAX_ATTEMPTS = 5;
            bool guessNotCorrect = true;
            while (guessNotCorrect && numAttempts < MAX_ATTEMPTS)
            {
                Console.WriteLine($"You have {MAX_ATTEMPTS - numAttempts} remaining quesees.");
                Console.Write("Guess a number (1-100): ");
                guess = int.Parse(Console.ReadLine());
                numAttempts++;
                if (guess < num)
                {
                    Console.WriteLine("Too Low!");
                }
                else if (guess > num)
                {
                    Console.WriteLine("Too high!");
                }
                else
                {
                    guessNotCorrect = false;
                }
            }
            if (guessNotCorrect)
            {
                Console.WriteLine($"You ran out of tries! Number was {num}.");
            }
            else
            {
                Console.WriteLine("Hooray! You got the number!");
            }
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
    #region
    public class App10
    {
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            // Prompt the user to enter a series of integer numbers, 0 to stop
            // Display sum of all numbers entered.
            int num;
            int sum = 0;
            do {
                Console.Write("Enter an integer number (0 to exit): ");
                num = int.Parse(Console.ReadLine());
                sum += num;
            } while (num != 0);
            Console.WriteLine($"\nSum of Numbers {sum}");
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
    #region
    public class App11
    {
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            double curMark;
            double minMark = 101;
            double maxMark = -1;
            double sumOfMarks = 0;
            double avgMark;
            int numStudents = 1;
            do{
                Console.Write($"Enter mark for student #{numStudents} or 999 to quit the program: ");
                curMark = double.Parse(Console.ReadLine());
                if(curMark >= 0 && curMark <= 100){
                    if (curMark < minMark)
                    {
                        minMark = curMark;
                    }
                    if (curMark > maxMark)
                    {
                        maxMark = curMark;
                    }
                    sumOfMarks += curMark;
                    numStudents++;
                } else if (curMark == 999) {
                    if (sumOfMarks != 0) {
                        avgMark = sumOfMarks / (double)numStudents;
                        Console.WriteLine($"\nAverage Mark: {avgMark}, Highest Mark: {maxMark}, Lowest Mark: {minMark}");
                    }
                } else {
                    Console.WriteLine($"Invalid Mark entered, try again!");
                }
            } while (curMark != 999);
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
    #region
    public class App12
    {
        public void App(string demoName)
        {
            Console.WriteLine($"{demoName} started");
            String playAgain = "y";
            String stringEntered = "1";
            double numEntered;
            double total = 0;
            Console.WriteLine($"*** Welcome to the Adding Machine. ***");
            do {
                Console.WriteLine($"Enter = when done.");
                while (stringEntered != "="){
                    Console.Write($"Enter a number: ");
                    stringEntered = Console.ReadLine();
                    if (stringEntered != "=")
                    {
                        numEntered = double.Parse(stringEntered);
                        total += numEntered;
                    }
                }
                stringEntered = "1";
                Console.WriteLine($"The total is {total}");
                total = 0;
                Console.Write($"Would you like to play again y or n? ");
                playAgain = Console.ReadLine();
            } while (playAgain != "n");
            Console.WriteLine($"{demoName} ended");
            Console.WriteLine("");
        }
    }
    #endregion
}