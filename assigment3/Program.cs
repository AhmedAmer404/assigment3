using System;
namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            string title = "Refactoring";
            switch (title)
            {
                case "Clean Code":
                    Console.WriteLine("Great Choice!");
                    break;
                 
                case "Refactoring":
                    Console.WriteLine("Nice Pick!");
                    break;

                default:
                    Console.WriteLine("Never Heared of it");
                    break;

            }
            #endregion
        }
    }
}
