using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lynkurs
{
    public class Student : Person
    {
        public List<string> CoursesTaken { get; set; }
        

        // Override Introduce() metoden i Person superklassen
        public override void Introduce()
        {
            Console.WriteLine("Hei! Jeg er studenten " + PersonName + ", " + PersonAge + " år og jeg tar disse kursene:  ");
            for (int i = 0; i < CoursesTaken.Count; i++)
            {
                Console.WriteLine(CoursesTaken[i]);
            }

        }

    }
}
