using System;

namespace Calendar
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var calendar = new Calendar();
            calendar.PrintWeek();
            
            while (true)
            {
                Console.WriteLine("Choose period:\n1-days\n2-hours\n3-minutes");
                int.TryParse(Console.ReadLine(), out var period);
                Console.WriteLine("Enter amount: ");
                int.TryParse(Console.ReadLine(), out var amount);
                switch (period)
                {
                    case 1: calendar.AddTime(TimeSpan.FromDays(amount));
                        break;
                    case 2: calendar.AddTime(TimeSpan.FromHours(amount));
                        break;
                    case 3: calendar.AddTime(TimeSpan.FromMinutes(amount));
                        break;
                    default: Console.WriteLine("Incorrect period value.");
                        return;
                }
                calendar.PrintWeek();
            }
        }
    }
}