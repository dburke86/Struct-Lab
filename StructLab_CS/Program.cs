﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructLab_CS
{
    struct Course
    {
        public string title;
        public int creditHours;
        public string program;
        public string instructor;

        public Course (string title, int credits, string prog, string inst) //This is a constructor.
        {
            this.title = title;
            this.creditHours = credits;
            this.program = prog;
            this.instructor = inst;
        }
        public string GetTitle()
        {
            return title.ToUpper();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Course cs101 = new Course("cs101", 6, "Computer Science", "Mr. Smith");
            Course cs102 = new Course();

            cs102.title = "cs102";
            cs102.creditHours = 6;
            cs102.program = "Computer Science";
            cs102.instructor = "Mrs. Jones";
            Console.WriteLine("The title of your course is {0}. This course is {1} credit hours. This course is part of the {2} program. The instructor for your course is {3}.", cs101.title, cs101.creditHours, cs101.program, cs101.instructor);
            Console.WriteLine();
            Console.WriteLine("The title of your course is {0}. This course is {1} credit hours. This course is part of the {2} program. The instructor for your course is {3}.", cs102.title, cs102.creditHours, cs102.program, cs102.instructor);
            Console.WriteLine("\n" + cs101.GetTitle() + "\n" + cs102.GetTitle());
        }
    }
}
