using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lynkurs
{
    public abstract class Ansatte : AbPerson
    {
        public int AnstteID { get; set; }
        public string Fagområde {  get; set; }

        public abstract void GjørArbeidsOppgaver();

    }
}
