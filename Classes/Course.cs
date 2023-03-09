using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Course
    {
        public string Title { get; set; }
        public int Credits { get; set; }
        public List<string> DaysOfWeek { get; set; }
        public Dictionary<string, int> Books { get; set; }
        public List<Student> StudentRoster { get; set; }

        public Course(string title, int credits, List<string> daysOfWeek, Dictionary<string, int> books, List<Student> studentRoster)
        {
            Title = title;
            Credits = credits;
            Books = books;
            StudentRoster = studentRoster;
        }


    }

}
