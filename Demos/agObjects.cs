using System;
using System.Collections.Generic;

namespace Objects
{
    #region
    public class CommonMethods
    {
        private const string SPECIALCHARACTERS = @",:;\/!?@#$%^&*~`0123456789";
        public static string GetString(String msg, String PreformValidation)
        {
            bool inValidInput = true;
            string str = "";
            while (inValidInput)
            {
                try
                {
                    Console.Write(msg);
                    str = Console.ReadLine();
                    if(PreformValidation == "yes")
                    {
                        if(string.IsNullOrEmpty(str))
                            throw new ArgumentException("The string cannot be empty");
                        foreach(char character in SPECIALCHARACTERS)
                            if (str.Contains(character))
                                throw new FormatException($"The string contains an invalid character.");
                    }
                    inValidInput = false; 
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Invalid: {ex.Message}");
                }
            }
            return str;
        }
        public static int GetIntBetweenMinMax(String msg, int min, int max, String PreformValidation)
        {
            bool inValidInput = true;
            int num = 0;
            while (inValidInput)
            {
                try
                {
                    Console.Write(msg);
                    num = int.Parse(Console.ReadLine());
                    if(PreformValidation == "yes")
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
    }
    #endregion
    #region
    public class StudentInfoWithFields 
    {
        //string field, readonly means it can only be set by the constructor and never again.
        public readonly string StudentName;
        //int field
        public readonly int StudentGrade;
        //greedy constructor, to make sure fields and properties have meaningful values.
        public StudentInfoWithFields(string studentName, int studentGrade)
        {
            //validation in the constructor
            if(string.IsNullOrEmpty(studentName))
                throw new ArgumentException("Student Name cannot be empty");
            if (studentGrade < 0 || studentGrade > 100)
                throw new FormatException($"Student Grade must be between 0 and 100 inclusive");
            StudentName = studentName;
            StudentGrade = studentGrade;
        }
    }
    public class App1
    {
        private void WithArrayOfObjects()
        {
            String PreformValidation = "yes";
            int studentCount = CommonMethods.GetIntBetweenMinMax("How many students in your class? ", 0, 100, PreformValidation);
            StudentInfoWithFields[] students = new StudentInfoWithFields[studentCount];
            string studentName;
            int studentGrade;
            for (int i = 0; i < students.Length; i++)
            {
                try
                {
                    studentName = CommonMethods.GetString($"Student Name {i}: ", PreformValidation);
                    studentGrade = CommonMethods.GetIntBetweenMinMax($"Student Grade {i}: ", 0, 100, PreformValidation);
                    students[i] = new StudentInfoWithFields(studentName, studentGrade);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception: {e.Message}");
                    i--;
                }
                
            }
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Name {i}: {students[i].StudentName}, Grade: {students[i].StudentGrade}");
            }
        }
        private void WithListOfObjects()
        {
            String PreformValidation = "yes";
            List<StudentInfoWithFields> students = new List<StudentInfoWithFields>();
            string studentName;
            int studentGrade;
            bool adding = true;
            int i = 0;
            while(adding)
            {
                try
                {
                    studentName = CommonMethods.GetString($"Student Name {i}: ", PreformValidation);
                    studentGrade = CommonMethods.GetIntBetweenMinMax($"Student Grade {i}: ", 0, 100, PreformValidation);
                    StudentInfoWithFields newStudent = new StudentInfoWithFields(studentName, studentGrade);
                    students.Add(newStudent);
                    // newStudent.StudentName = "jimmy";
                    // students.Add(new StudentInfoWithFields(studentName, studentGrade));
                    i++;
                    if (CommonMethods.GetString("Add another? y/n: ", "yes") == "n")
                        adding = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception: {e.Message}");
                }
            }
            for (int j = 0; j < students.Count; j++)
            {
                Console.WriteLine($"Name {j}: {students[j].StudentName}, Grade {j}: {students[j].StudentGrade}");
            }
        }
        public void App(string demoName)
        {
            try
            {
                Console.WriteLine($"{demoName} started");
                //WithArrayOfObjects();
                WithListOfObjects();
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
    public class StudentInfoWithProperties 
    {
        //String auto-implemented property.
        //By default the get (accessor) is public so StudentName can be on the right side of 
        //an = outside of this class.
        //For example you can have string myStudentName = myInstanceName.StudentName;
        //Private set (mutator) means that only the constructor or member methods can set it
        //or mutate it so StudentName cannot be on the left side of an = outside of this class.
        //For example you cannot have myInstanceName.StudentName = "hi";
        public string StudentName {get; private set;}
        //int auto-implemented property
        public int StudentGrade {get; private set;}
        //greedy constructor, to make sure fields and properties have meaningful values.
        public StudentInfoWithProperties(string studentName, int studentGrade)
        {
            //validation in the constructor
            if(string.IsNullOrEmpty(studentName))
                throw new ArgumentException("Student Name cannot be empty");
            if (studentGrade < 0 || studentGrade > 100)
                throw new FormatException($"Student Grade must be between 0 and 100 inclusive");
            StudentName = studentName;
            StudentGrade = studentGrade;
        }
        //Non greedy constructor, to make sure fields and properties have some default values.
        //Constructor chaining.
        public StudentInfoWithProperties() : this("James", 50) {}
        //Instance method that has set access to StudentName.
        public void AnotherInstanceMethod()
        {
            StudentName = "jimmy";
        }
    }
    public class App2
    {
        public void AddStudents(List<StudentInfoWithProperties> students)
        {
            String PreformValidation = "yes";
            string studentName;
            int studentGrade;
            bool adding = true;
            int i = 0;
            StudentInfoWithProperties newStudent1 = new StudentInfoWithProperties();
            students.Add(newStudent1);
            while(adding)
            {
                try
                {
                    studentName = CommonMethods.GetString($"Student Name {i}: ", PreformValidation);
                    studentGrade = CommonMethods.GetIntBetweenMinMax($"Student Grade {i}: ", 0, 100, PreformValidation);
                    StudentInfoWithProperties newStudent = new StudentInfoWithProperties(studentName, studentGrade);
                    students.Add(newStudent);
                    string myStudentNameString = newStudent.StudentName;
                    // newStudent.StudentName = "hi";
                    i++;
                    if (CommonMethods.GetString("Add another? y/n: ", "yes") == "n")
                        adding = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception: {e.Message}");
                }
            }
        }
        public void DisplayStudents(List<StudentInfoWithProperties> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"Name {i}: {students[i].StudentName}, Grade {i}: {students[i].StudentGrade}");
            }
            foreach (StudentInfoWithProperties student in students)
            {
                Console.WriteLine($"Name : {student.StudentName}, Grade : {student.StudentGrade}");
            }
        }

        public void App(string demoName)
        {
            try
            {
                Console.WriteLine($"{demoName} started");
                List<StudentInfoWithProperties> students = new List<StudentInfoWithProperties>();
                AddStudents(students);
                DisplayStudents(students);
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