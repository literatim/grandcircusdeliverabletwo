using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace deliverable_two
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter two dates to check the amount of time (Days, Hours, and Minutes) elapsed between the two");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");

            //Obtain user input and convert to DateTime
            Console.WriteLine("Enter the soonest date (MM/DD/YYYY HH:mm format. Leave HH:mm blank to set to 12:00am): ");
            var date1 = GetDateTime(Console.ReadLine());
            Console.WriteLine("Enter the furthest date (MM/DD/YYYY formatLeave HH:mm blank to set to 12:00am): ");
            var date2 = GetDateTime(Console.ReadLine());

            //Calculate time elapsed between the two dates and display to user
            CalculateTimeElapsed(date1, date2);

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
        /// <summary>
        /// Parses user input using the DateTime struct
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        private static DateTime GetDateTime(string date)
        {
            string [] formats = { "MMddyyyy HH:mm" };
            DateTime dateTime;
            try
            {
                dateTime = DateTime.Parse(date);
            }
            catch (Exception e)
            {
               System.ArgumentException argE = new System.ArgumentException("That's not a valid date!");
               throw argE;
            }

            return dateTime;
        }

        private static TimeSpan CalculateTimeElapsed(DateTime date1, DateTime date2)
        {
            TimeSpan timeElapsed = date1 - date2;

            Console.WriteLine("   {0,-35} {1,20}", "Days:", timeElapsed.Days);
            Console.WriteLine("   {0,-35} {1,20}", "Hours:", timeElapsed.Hours);
            Console.WriteLine("   {0,-35} {1,20}", "Minutes:", timeElapsed.Minutes);

            return timeElapsed;
        }

    }
}
