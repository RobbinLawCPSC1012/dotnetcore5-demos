using System;
using System.Collections.Generic;
using System.IO;

namespace Objects
{
    #region
    public class CommonMethods
    {
        private const string SPECIALCHARACTERS = @",:;\/!?@#$%^&*~`0123456789";
        //This is a class method that can be called without instantiating an object
        //of this class. The key word static makes it a class method.
        //Just call that class name and method, CommonMethods.GetString("hi","yes");
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
        //This is another class method.
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
                    //We do not have set (mutator) access to the readonly field after instanciation.
                    // newStudent.StudentName = "jimmy";
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
                WithArrayOfObjects();
                //WithListOfObjects();
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
    public class StudentInfoWithAutoProperties 
    {
        //String auto-implemented property.
        //By default the get (accessor) is public so StudentName can be on the right side of 
        //an = outside of this class.
        //For example you can have string myStudentName = myInstanceName.StudentName;
        //Private set (mutator) means that only the constructor or member methods can set it
        //or mutate it so StudentName cannot be on the left side of an = outside of this class.
        //For example you cannot have myInstanceName.StudentName = "hi";
        //NEVER make an auto-implemented properties set (mutator) public as there is no validation.
        public string StudentName {get; private set;}
        //int auto-implemented property
        public int StudentGrade {get; private set;}
        //greedy constructor, to make sure fields and properties have meaningful values.
        public StudentInfoWithAutoProperties(string studentName, int studentGrade)
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
        public StudentInfoWithAutoProperties() : this("James", 50) {}
        //Instance method that has set access to StudentName.
        public void AnotherInstanceMethod(String newName)
        {
            StudentName = newName;
        }
    }
    public class App2
    {
        public void AddStudents(List<StudentInfoWithAutoProperties> students)
        {
            String PreformValidation = "yes";
            string studentName;
            int studentGrade;
            bool adding = true;
            //Adding a student with default values "James, 50".
            StudentInfoWithAutoProperties newStudent0 = new StudentInfoWithAutoProperties();
            students.Add(newStudent0);
            //Because the properties set is private we cannot set (mutate) 
            //it separately outside of the constructor after the object 
            //has been created (instanciated).
            //newStudent0.StudentName = "hi";
            //We can access the private set this way though.
            newStudent0.AnotherInstanceMethod("hello");
            int i = 1;
            while(adding)
            {
                try
                {
                    studentName = CommonMethods.GetString($"Student Name {i}: ", PreformValidation);
                    studentGrade = CommonMethods.GetIntBetweenMinMax($"Student Grade {i}: ", 0, 100, PreformValidation);
                    StudentInfoWithAutoProperties newStudent = new StudentInfoWithAutoProperties(studentName, studentGrade);
                    students.Add(newStudent);
                    string myStudentNameString = newStudent.StudentName;
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
        public void DisplayStudents(List<StudentInfoWithAutoProperties> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"Name {i}: {students[i].StudentName}, Grade {i}: {students[i].StudentGrade}");
            }
            foreach (StudentInfoWithAutoProperties student in students)
            {
                Console.WriteLine($"Name : {student.StudentName}, Grade : {student.StudentGrade}");
            }
        }

        public void App(string demoName)
        {
            try
            {
                Console.WriteLine($"{demoName} started");
                List<StudentInfoWithAutoProperties> students = new List<StudentInfoWithAutoProperties>();
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
    public class StudentInfoWithFullProperties 
    {
        //String fully-implemented property with a backing field.
        //By default the get (accessor) is public so StudentName can be on the right side of 
        //an = outside of this class.
        //For example you can have string myStudentName = myInstanceName.StudentName;
        //Public set (mutator) now means that any code outside of this class can set it
        //or mutate it so StudentName can now be on the left side of an = outside of this class.
        //For example you can now have myInstanceName.StudentName = "hi";
        //Because of this we now need validation inside the setter (mutator).
        private string _StudentName;
        public string StudentName 
        {
            get {return _StudentName;} 
            set
            {
                //validation in the setter (mutator)
                if(string.IsNullOrEmpty(value))
                    throw new ArgumentException("Student Name cannot be empty");
                _StudentName = value;
            }
        }
        //int fully-implemented property with backing field.
        //This structure is performing ENCAPSULATION, nothing outside this
        //class can see the field directly, only the property.
        private int _StudentGrade;
        public int StudentGrade
        {
            get {return _StudentGrade;} 
            set
            {
                //validation in the setter (mutator)
                if (value < 0 || value > 100)
                    throw new FormatException($"Student Grade must be between 0 and 100 inclusive");
                _StudentGrade = value;
            }
        }
        //greedy constructor, to make sure fields and properties have meaningful values.
        public StudentInfoWithFullProperties(string studentName, int studentGrade)
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
        public StudentInfoWithFullProperties() : this("James", 50) {}

        #region code added for App4
        public override string ToString()
        {
            return $"{StudentName},{StudentGrade}";
        }
        #endregion
        #region code added for App5
        public static StudentInfoWithFullProperties OurParse(string text)
        {
            string [] items = text.Split(',');
            if (items.Length != 2) 
                throw new FormatException("Input string is not the correct CSV format" );
            return new StudentInfoWithFullProperties(
                items[0],
                int.Parse(items[1])
            );
        }
        public static bool TryParse(string text, out StudentInfoWithFullProperties result)
        {
            bool valid = false;
            try
            {
                result = OurParse(text);
                valid = true;
            }
            catch (Exception ex)
            { 
                Console.WriteLine($"catch StudentInfoWithFullProperties.TryParse: {ex.Message}");  
                result = null;
            }
            //This code runs if the try is successful and does not have a return
            //and if the catch does not have a return as in this case.
            return valid;
        }
        #endregion
    }
    public class App3
    {
        public void AddStudents(List<StudentInfoWithFullProperties> students)
        {
            String PreformValidation = "yes";
            string studentName;
            int studentGrade;
            bool adding = true;
            //Adding a student with default values "James, 50".
            StudentInfoWithFullProperties newStudent0 = new StudentInfoWithFullProperties();
            students.Add(newStudent0);
            //Because the properties set is public we can set (mutate) 
            //it separately outside of the constructor after the object 
            //has been created (instanciated).
            //newStudent0.StudentName = "hi";
            //Because we now have validation in the setter we will NOT
            //allow bad data to creep in.
            //newStudent0.StudentName = "";
            int i = 1;
            while(adding)
            {
                try
                {
                    studentName = CommonMethods.GetString($"Student Name {i}: ", PreformValidation);
                    studentGrade = CommonMethods.GetIntBetweenMinMax($"Student Grade {i}: ", 0, 100, PreformValidation);
                    StudentInfoWithFullProperties newStudent = new StudentInfoWithFullProperties(studentName, studentGrade);
                    students.Add(newStudent);
                    string myStudentNameString = newStudent.StudentName;
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
        public void DisplayStudents(List<StudentInfoWithFullProperties> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"Name {i}: {students[i].StudentName}, Grade {i}: {students[i].StudentGrade}");
            }
            foreach (StudentInfoWithFullProperties student in students)
            {
                Console.WriteLine($"Name : {student.StudentName}, Grade : {student.StudentGrade}");
            }
        }
        public void App(string demoName)
        {
            try
            {
                Console.WriteLine($"{demoName} started");
                List<StudentInfoWithFullProperties> students = new();
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
    public class App4
    {
        public void App(string demoName)
        {
            try
            {
                Console.WriteLine($"{demoName} started");
                const string csvFileName = "StudentData.dat";
                List<StudentInfoWithFullProperties> students = new();
                students.Add(new StudentInfoWithFullProperties("Charles", 55));
                students.Add(new StudentInfoWithFullProperties("Jimmy", 45));
                students.Add(new StudentInfoWithFullProperties("Jill", 99));
                students.Add(new StudentInfoWithFullProperties("John", 88));
                students.Add(new StudentInfoWithFullProperties("James", 77));
                students.Add(new StudentInfoWithFullProperties("Robbin", 22));
                List<string> csvLines = new();
                foreach (var item in students)
                    csvLines.Add(item.ToString());
                //write to a csv file. requires using System.IO    
                File.WriteAllLines(csvFileName, csvLines);
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
    public class App5
    {
        public void App(string demoName)
        {
            try
            {
                Console.WriteLine($"{demoName} started");
                const string csvFileName = "StudentData.dat";
                List<StudentInfoWithFullProperties> students = new();
                //read the csv file and each line becomes a new product added to the productlist.
                string[] csvFileInput = File.ReadAllLines(csvFileName);
                StudentInfoWithFullProperties student = null;
                //each line read from the file is a string that now has to be parsed into different types.
                foreach(string line in csvFileInput)
                {
                    try
                    {
                    bool returnedBool = StudentInfoWithFullProperties.TryParse(line, out student);
                    //This line of code is here only to show that the bool is always returned.
                    Console.WriteLine($"returnedBool is: {returnedBool} for: {line}");
                    if(returnedBool != false)
                        students.Add(student);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Exception (App foreach catch): {ex.Message}");
                    }    
                }
                foreach (var item in students)
                    Console.WriteLine(item.ToString());
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