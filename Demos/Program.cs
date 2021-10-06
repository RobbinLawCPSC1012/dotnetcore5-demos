﻿using System;

namespace Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            //program.Sequence();
            program.Decision();
            //program.Loops();
            //program.MethodsExceptions();
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
            app12.App("12");
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
            app1.App("For Loop Simple Demo");
            var app2 = new Loops.App2();
            app2.App("For Loop: Class Average Demo");
            var app3 = new Loops.App3();
            app3.App("For Loop: Total Sales Demo");
            var app4 = new Loops.App4();
            app4.App("For Loop: Class Average with High/Low Play Only Once");
            var app5 = new Loops.App5();
            app5.App("For Loop: Year End Balance");
            var app6 = new Loops.App6();
            app6.App("For & While Loop Comparison");
            var app7 = new Loops.App7();
            app7.App("While Loop: Temperature");
            var app8 = new Loops.App8();
            app8.App("While Loop: Soccer Team");
            var app9 = new Loops.App9();
            app9.App("While Loop: Guess the Number Only Play Once");
            var app10 = new Loops.App10();
            app10.App("Do While Simple Demo");
            var app11 = new Loops.App11();
            app11.App("Do While Loop: Class Average with High/Low Play Many Times");
            var app12 = new Loops.App12();
            app12.App("Do While Loop: Add Calculator Play Many Times");
        }
        public void MethodsExceptions()
        {
            var app1 = new MethodsExceptions.App1();
            //app1.App("Methods Simple Demo");
            var app2 = new MethodsExceptions.App2();
            //app2.App("Methods input Validation Demo");
            var app3 = new MethodsExceptions.App3();
            //app3.App("Methods Circle Area and Circumference");
            var app4 = new MethodsExceptions.App4();
            //app4.App("Methods Equation of a Line");
            var app5 = new MethodsExceptions.App5();
            //app5.App("Methods Math Calculator");
            var app6 = new MethodsExceptions.App6();
            //app6.App("Methods Boxed In");
            var app7 = new MethodsExceptions.App7();
            //app7.App("Methods Overloading Draw Triangles");
            var app8 = new MethodsExceptions.App8();
            //app8.App("Try Catch Simple Demo");
            var app9 = new MethodsExceptions.App9();
            app9.App("Try Catch Finally Demo");
            var app10 = new MethodsExceptions.App10();
            //app10.App("Try Catch Circle Area and Circumference");
            var app11 = new MethodsExceptions.App11();
            //app11.App("Try Catch Boxed In");
            var app12 = new MethodsExceptions.App12();
            //app12.App("Try Catch Draw Triangles");
        }
        public void Files()
        {
            
        }
    }
}
