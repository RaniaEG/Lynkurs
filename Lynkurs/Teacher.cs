using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lynkurs
{
    public class Teacher : Person
    {
        public string Subject { get; set; }

        

        // Override Introduce() metoden i Person superklassen
        public override void Introduce()
        {
            Console.WriteLine("\nHei! Jeg er lærer " + PersonName + ", " + PersonAge + " år, og jeg underviser i " + Subject + ".");
        }

        
    }

}
