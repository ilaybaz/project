using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Playground
    {
        public List<Activity> Activities { get; set; }
        public Playground()
        {
            Activities = new List<Activity>();
        }
        public void AddActivity(Activity activity)
        {
            this.Activities.Add(activity);
        }
        public static List<Student> StudentsInActivity(Activity activity)
        {
            List<Student> list = activity.students;
            return list;
        }
        public static List<Activity> GetActivitiesForStudent(List<Activity> activities, Student student)
        {
            List<Activity> ActList = new List<Activity>();
            foreach(Activity activity in activities)
            {
                foreach(Student student1 in activity.students)
                {
                    if(student1 == student)
                    {
                        ActList.Add(activity);
                        break;
                    }
                }
            }
            return ActList;
        }
    }
}
