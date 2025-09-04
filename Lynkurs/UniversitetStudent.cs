using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lynkurs
{
    public class UniversitetStudent : Ansatte
    {
        public string Grade {  get; set; }
        public int StudieÅr {  get; set; }

        public string StudieProgram { get; set; }

        public override void AbIntroduce()
        {
            Console.WriteLine($"Student {AbName} går i {StudieÅr} studie år.");
        }

        public override void GjørArbeidsOppgaver()
        {
            Console.WriteLine($"Student {AbName} jobber som LA.");
        }


    }
}
