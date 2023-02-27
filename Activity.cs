using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Activity
    {
        public string Name { get; set; }
        public List<Student> students { get; set; }

        public Activity(string Name)
        {
            this.Name = Name;   
            this.students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            
            this.students.Add(student);
        }
        public override string ToString()
        {
            string result = "Activity name: " + Name + "\n";
            return result;
        }
        public static Student GetFastestStudent(Activity activity)
        {
            Student fastest = activity.students.First();
            foreach (Student student in activity.students)
            {
                if (student.TimeTaken < fastest.TimeTaken)
                {
                    fastest = student;
                }
            }
            return fastest;
        }
        public static List<Student> GetTopThreeFastestStudents(Activity activity)
        {
            List<Student> fastest = new List<Student>();
            LinkedList<Student> students = new LinkedList<Student>(activity.students);
            for (int i = 0; i < 3 && students.Count > 0; i++)
            {
                Student fast = students.First.Value;
                foreach (Student student in students)
                {
                    if (student.TimeTaken < fast.TimeTaken)
                    {
                        fast = student;
                    }
                }
                fastest.Add(fast);
                students.Remove(fast);
            }
            return fastest;
        }



    }
}

