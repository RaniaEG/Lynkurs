using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lynkurs
{
    public class Lærer : Ansatte, IPersonReise
    {
        public string Kurs {  get; set; }

        public override void AbIntroduce()
        {
            Console.WriteLine($"Lærer {AbName} underviser {Kurs}");
        }

        public override void GjørArbeidsOppgaver()
        {
            Console.WriteLine($"Lærer {AbName} foreleser, veileder og sensurerer i {Kurs}");
        }

        public void Register(int år)
        {
            Console.WriteLine($"Lærer {AbName} startet på jobb i {år}");
        }
    }
}
