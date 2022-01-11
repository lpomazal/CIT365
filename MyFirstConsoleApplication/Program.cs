using System;
using System.Windows.Forms;

namespace MyFirstConsoleApplication
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void GetUserNameAndLocation(string[] args)
        {
            Person user1 = new Person();
            Console.WriteLine("What is your name?");
            user1.Name = Console.ReadLine();
            Console.WriteLine("Hi {0}. Where are you from?", user1.Name);
            user1.location = Console.ReadLine();
            Console.WriteLine("I have never been to {0}. I bet it is nice. Press any key to continue...", user1.location);
            Console.ReadKey();
        }
        private static void ChristmasCountdown(string[] args)
        {
            DateTime todayDate = DateTime.Now;
            Console.WriteLine("Today's date is:" + todayDate.ToString("MMMM dd, yyyy") + ".");
            DateTime xmasDate = new DateTime(2022, 12, 25);
            double daysToChristmas = xmasDate.Subtract(DateTime.Today).TotalDays;
            Console.WriteLine("There are {0} days until Christmas!", daysToChristmas);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Program p = New Program();
            p.GetUsernameAndLocation();
            p.ChristmasCountdown();
        }
    }
}

    
