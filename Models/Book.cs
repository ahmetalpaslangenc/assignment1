using System;

namespace BookApp.Models
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageNumber { get; set; }
        public DateTime DueDate { get; set; }

        public int DaysRemaining()
        {
            return (DueDate - DateTime.Now).Days;
        }

        public string DueDateColor()
        {
            var daysRemaining = DaysRemaining();
            if (daysRemaining <= 1)
                return "red";
            else if (daysRemaining <= 3)
                return "yellow";
            else
                return "green";
        }
    }
}

