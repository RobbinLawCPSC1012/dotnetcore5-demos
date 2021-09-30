using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new Program();
            app.forloop();
           // return 0;
        }
        #region forloop
        private void forloop()
        {
            try
            {
                Console.WriteLine("forloop Demo started");
                
                Console.WriteLine("forloop Demo ended");
                Console.WriteLine("");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in forloop: {ex.Message}");
            }
            
        }
        #endregion
    }
}
