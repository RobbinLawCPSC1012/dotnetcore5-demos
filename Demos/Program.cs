using System;

namespace demos
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            //program.Loops();
            program.Files();
             
        }
        public void Loops()
        {
            var loops = new Loops();
            loops.App1("For Loop Simple Demo");
            loops.App2("For Loop Class Average Demo");
            loops.App3("For Loop Total Sales Demo");
            loops.App4("For Loop Class Average with High/Low Play Only Once");
            loops.App5("For Loop Year End Balance");
            loops.App6("For & While Loop Comparison");
            loops.App7("While Loop Temperature");
            loops.App8("While Loop Soccer Team");
            loops.App9("While Loop Guess the Number Only Play Once");
            loops.App10("Do While Simple Demo");
            loops.App11("Do While Loop Class Average with High/Low Play Many Times");
            loops.App12("Do While Loop Add Calculator Play Many Times");
        }
        public void Files()
        {
            var files = new Files();
            files.App1();
        }
        
        
        
    }
}
