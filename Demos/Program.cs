using System;

namespace demos
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            program.Sequence();
            program.Decision();
            //program.Loops();
            //program.Files();
             
        }
        public void Sequence()
        {
            var apps = new Sequence();
            apps.App1("1");
            apps.App2("2");
            apps.App3("3");
            apps.App4("4");
            apps.App5("5");
            apps.App6("6");
            apps.App7("7");
            apps.App8("8");
            apps.App9("9");
            apps.App10("10");
            apps.App11("11");
            apps.App12("12");
        }
        public void Decision()
        {
            var apps = new Decision();
            apps.App1("1");
            apps.App2("2");
            apps.App3("3");
            apps.App4("4");
            apps.App5("5");
            apps.App6("6");
            apps.App7("7");
            apps.App8("8");
            apps.App9("9");
            apps.App10("10");
            apps.App11("11");
            apps.App12("12");
        }
        public void Loops()
        {
            var apps = new Loops();
            apps.App1("For Loop Simple Demo");
            apps.App2("For Loop Class Average Demo");
            apps.App3("For Loop Total Sales Demo");
            apps.App4("For Loop Class Average with High/Low Play Only Once");
            apps.App5("For Loop Year End Balance");
            apps.App6("For & While Loop Comparison");
            apps.App7("While Loop Temperature");
            apps.App8("While Loop Soccer Team");
            apps.App9("While Loop Guess the Number Only Play Once");
            apps.App10("Do While Simple Demo");
            apps.App11("Do While Loop Class Average with High/Low Play Many Times");
            apps.App12("Do While Loop Add Calculator Play Many Times");
        }
        public void Files()
        {
            var apps = new Files();
            apps.App1();
            apps.App2("");
            apps.App3("");
            apps.App4("");
            apps.App5("5");
        }
        // public void Decision()
        // {
        //     var apps = new Decision();
        //     apps.App1("1");
        //     apps.App2("2");
        //     apps.App3("3");
        //     apps.App4("4");
        //     apps.App5("5");
        //     apps.App6("6");
        //     apps.App7("7");
        //     apps.App8("8");
        //     apps.App9("9");
        //     apps.App10("10");
        //     apps.App11("11");
        //     apps.App12("12");
        // }  
    }
}
