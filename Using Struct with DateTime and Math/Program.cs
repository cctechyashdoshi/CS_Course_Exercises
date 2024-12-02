using System;

namespace Using_Struct_with_DateTime_and_Math
{
    internal class Program
    {
        public struct Event
        {
            public DateTime StartDate;
            public DateTime EndDate;

            public Event(DateTime startDate, DateTime endDate)
            {
                StartDate = startDate;
                EndDate = endDate;
            }

            public double GetDuration()
            {
                return (EndDate - StartDate).TotalDays;
            }

            public bool IsOverlapping(Event otherEvent)
            {
                return (StartDate < otherEvent.EndDate && EndDate > otherEvent.StartDate);
            }
        }

        public class Exercise
        {
            public void TestEvents()
            {
                Event event1 = new Event(new DateTime(2024, 07, 01), new DateTime(2024, 07, 10));
                Event event2 = new Event(new DateTime(2024, 07, 05), new DateTime(2024, 07, 15));

                Console.WriteLine($"Event 1 Duration: {event1.GetDuration()} days");
                Console.WriteLine($"Event 2 Duration: {event2.GetDuration()} days");

                bool overlap = event1.IsOverlapping(event2);
                Console.WriteLine($"Events Overlap: {overlap}");
            }
        }

        static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.TestEvents();
        }
    }
}
