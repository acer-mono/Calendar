using System;
using System.Collections.Generic;
using System.Globalization;

namespace Calendar
{
    public class Calendar
    {
        private Dictionary<DayOfWeek, int> _days = new Dictionary<DayOfWeek, int>
        {
            {DayOfWeek.Sunday, 0},
            {DayOfWeek.Monday, 1},
            {DayOfWeek.Tuesday, 2},
            {DayOfWeek.Wednesday, 3},
            {DayOfWeek.Thursday, 4},
            {DayOfWeek.Friday, 5},
            {DayOfWeek.Saturday, 6}
        };
        private DateTime _date = DateTime.Now;
        private int Year => _date.Year;
        private int Month => _date.Month;
        private int DaysInMonth => DateTime.DaysInMonth(Year, Month);
        private int WeekDay => _days[_date.DayOfWeek];

        public void AddTime(TimeSpan time)
        {
            _date += time;
        }
        
        public void PrintWeek ()
        {
            Console.WriteLine(_date.ToString("MMMM/yyyy", CultureInfo.CreateSpecificCulture("us")));
            Console.WriteLine("Su\tMo\tTu\tWe\tTh\tFr\tSa");
            
            for (var i = 0; i < WeekDay; i++)
            {
                Console.Write("~~\t");
            }

            for ( var i = 1; i <= DaysInMonth; i++) 
            {
                if (i == _date.Day)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ResetColor();
                }
                
                Console.Write($"{i, 2}\t");
                
                if((i  + WeekDay) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }
            
            Console.WriteLine();
        }
    }
}