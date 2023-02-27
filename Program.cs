using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp6
{
    class Student
    {
        public string Name { get; set; }
        public int TimeTaken { get; set; }
        public Student(string name, int timeTaken)
        {
            Name = name;
            TimeTaken = timeTaken;
        }
        public override string ToString()
        {
            return "Student name: " + this.Name + ", Time taken: " + this.TimeTaken;
        }
    }


   

    class Program
    {
        static void Main(string[] args)
        {
            Playground Gina = new Playground();

            Activity run = new Activity("run");
            Activity pushup = new Activity("pushup");

            Student John = new Student("John", 11);
            Student Jerry = new Student("Jerry", 12);
            Student James = new Student("James", 9);
            Student Don = new Student("Don", 5);

            Gina.AddActivity(run);
            Gina.AddActivity(pushup);

            run.AddStudent(John);
            run.AddStudent(Jerry);
            run.AddStudent(James);

            pushup.AddStudent(Don);
            pushup.AddStudent(John);
            pushup.AddStudent(Jerry);
            pushup.AddStudent(James);

            List<Student> Students = new List<Student>();

            Students.Add(John);
            Students.Add(Jerry);
            Students.Add(James);

            List<Student> Fastest3 = Activity.GetTopThreeFastestStudents(run);
            Console.WriteLine("Top 3 Fastest Students run:");
            Fastest3.ForEach(Console.WriteLine);
            Fastest3 = Activity.GetTopThreeFastestStudents(pushup);
            Console.WriteLine("Top 3 Fastest Students pushup:");
            Fastest3.ForEach(Console.WriteLine);
            Student fastest = Activity.GetFastestStudent(run);
            Console.WriteLine("Fastest Students run:");
            Console.WriteLine(fastest);
            Console.WriteLine("Students run:");
            run.students.ForEach(Console.WriteLine);
            Console.WriteLine("First Student in run:");
            Console.WriteLine(run.students[0]);
            List<Student> listy = Playground.StudentsInActivity(pushup);
            Console.WriteLine("Students pushup:");
            listy.ForEach(Console.WriteLine);
            List<Activity> listact = Playground.GetActivitiesForStudent(Gina.Activities, Don);
            Console.WriteLine("Don activities");
            listact.ForEach(Console.WriteLine);
        }
    }   
}
