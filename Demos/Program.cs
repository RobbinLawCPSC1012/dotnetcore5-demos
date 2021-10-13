using System;

namespace Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            //program.Sequence();
            //program.Decision();
            program.Loops();
            //program.MethodsExceptions();
            //program.Arrays();
            //program.Objects();
            //program.Files();
        }
        public void Sequence()
        {
            var app1 = new Sequence.App1();
            app1.App("1");
            var app2 = new Sequence.App2();
            app2.App("2");
            var app3 = new Sequence.App3();
            app3.App("3");
            var app4 = new Sequence.App4();
            app4.App("4 - String Building with String Interpolation Formatting");
            var app5 = new Sequence.App5();
            app5.App("5 - More Complicated String Building");
            var app6 = new Sequence.App6();
            app6.App("6 - Math");
            var app7 = new Sequence.App7();
            app7.App("7 - ReadLine and Parse");
            var app8 = new Sequence.App8();
            app8.App("8 - Circle Circumference");
            var app9 = new Sequence.App9();
            app9.App("9 - Average Velocity");
            var app10 = new Sequence.App10();
            app10.App("10 - Simple Future Value");
            var app11 = new Sequence.App11();
            app11.App("11 - Calculating GST");
            var app12 = new Sequence.App12();
            app12.App("12 - ");
        }
        public void Decision()
        {
            var app1 = new Decision.App1();
            app1.App("1 - If, If Else, and If Else If Demo");
            var app2 = new Decision.App2();
            app2.App("2 - If Else: Pollution Level");
            var app3 = new Decision.App3();
            app3.App("3 - Boolean Operands");
            var app4 = new Decision.App4();
            app4.App("4 - If Else with Boolean: Pass or Fail");
            var app5 = new Decision.App5();
            app5.App("5 - If Else If: Storm Level");
            var app6 = new Decision.App6();
            app6.App("6 - If: Glazer Calculator");
            var app7 = new Decision.App7();
            app7.App("7 - If, If Else: Leap Year");
            var app8 = new Decision.App8();
            app8.App("8 - If Else If: Student Grade");
            var app9 = new Decision.App9();
            app9.App("9 - If Else If compared with equivalent Switch Case");
            var app10 = new Decision.App10();
            app10.App("10 - Switch Case: Pet Food");
            var app11 = new Decision.App11();
            app11.App("11 - Switch Case: Seasons in Spanish");
            var app12 = new Decision.App12();
            app12.App("12 - Switch Case: All Provinces Sales Tax Calculator");
        }
        public void Loops()
        {
            var app1 = new Loops.App1();
            //app1.App("1 - For Loop Simple Demo");
            var app2 = new Loops.App2();
            //app2.App("2 - For Loop: Class Average Demo");
            var app3 = new Loops.App3();
            //app3.App("3 - For Loop: Total Sales Demo");
            var app4 = new Loops.App4();
            //app4.App("4 - For Loop: Class Average with High/Low Play Only Once");
            var app5 = new Loops.App5();
            //app5.App("5 - For Loop: Year End Balance");
            var app6 = new Loops.App6();
            //app6.App("6 - For & While Loop Comparison");
            var app7 = new Loops.App7();
            //app7.App("7 - While Loop: Temperature");
            var app8 = new Loops.App8();
            //app8.App("8 - While Loop: Soccer Team");
            var app9 = new Loops.App9();
            app9.App("9 - While Loop: Guess the Number Only Play Once");
            var app10 = new Loops.App10();
            //app10.App("10 - Do While Simple Demo");
            var app11 = new Loops.App11();
            //app11.App("11 - Do While Loop: Class Average with High/Low Play Many Times");
            var app12 = new Loops.App12();
            //app12.App("12 - Do While Loop: Add Calculator Play Many Times");
        }
        public void MethodsExceptions()
        {
            var app1 = new MethodsExceptions.App1();
            //app1.App("1 - Methods Simple Demo");
            var app2 = new MethodsExceptions.App2();
            //app2.App("2 - Methods input Validation Demo");
            var app3 = new MethodsExceptions.App3();
            //app3.App("3 - Methods Circle Area and Circumference");
            var app4 = new MethodsExceptions.App4();
            //app4.App("4 - Methods Equation of a Line");
            var app5 = new MethodsExceptions.App5();
            //app5.App("5 - Methods Math Calculator");
            var app6 = new MethodsExceptions.App6();
            //app6.App("6 - Methods Boxed In");
            var app7 = new MethodsExceptions.App7();
            //app7.App("7 - Methods Overloading Draw Triangles");
            var app8 = new MethodsExceptions.App8();
            //app8.App("8 - Try Catch Simple Demo");
            var app9 = new MethodsExceptions.App9();
            app9.App("9 - Try Catch Finally Demo");
            var app10 = new MethodsExceptions.App10();
            //app10.App("10 - Try Catch Circle Area and Circumference");
            var app11 = new MethodsExceptions.App11();
            //app11.App("11 - Try Catch Boxed In");
            var app12 = new MethodsExceptions.App12();
            //app12.App("12 - Try Catch Draw Triangles");
        }
        public void Arrays()
        {
            var app1 = new Arrays.App1();
            app1.App("1 - ");
            var app2 = new Arrays.App2();
            app2.App("2 - ");
            var app3 = new Arrays.App3();
            app3.App("3 - ");
            var app4 = new Arrays.App4();
            app4.App("4 - ");
            var app5 = new Arrays.App5();
            app5.App("5 - ");
            var app6 = new Arrays.App6();
            app6.App("6 - ");
            var app7 = new Arrays.App7();
            app7.App("7 - ");
            var app8 = new Arrays.App8();
            app8.App("8 - ");
            var app9 = new Arrays.App9();
            app9.App("9 - ");
            var app10 = new Arrays.App10();
            app10.App("10 - ");
            var app11 = new Arrays.App11();
            app11.App("11 - ");
            var app12 = new Arrays.App12();
            app12.App("12 - ");
        }
        public void Objects()
        {
            var app1 = new Objects.App1();
            app1.App("1 - ");
            var app2 = new Objects.App2();
            app2.App("2 - ");
            var app3 = new Objects.App3();
            app3.App("3 - ");
            var app4 = new Objects.App4();
            app4.App("4 - ");
            var app5 = new Objects.App5();
            app5.App("5 - ");
            var app6 = new Objects.App6();
            app6.App("6 - ");
            var app7 = new Objects.App7();
            app7.App("7 - ");
            var app8 = new Objects.App8();
            app8.App("8 - ");
            var app9 = new Objects.App9();
            app9.App("9 - ");
            var app10 = new Objects.App10();
            app10.App("10 - ");
            var app11 = new Objects.App11();
            app11.App("11 - ");
            var app12 = new Objects.App12();
            app12.App("12 - ");
        }
        public void Files()
        {
            var app1 = new Files.App1();
            app1.App("1 - ");
            var app2 = new Files.App2();
            app2.App("2 - ");
            var app3 = new Files.App3();
            app3.App("3 - ");
            var app4 = new Files.App4();
            app4.App("4 - ");
        }
    }
}
