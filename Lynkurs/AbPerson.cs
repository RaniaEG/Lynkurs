using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lynkurs
{
    public abstract class AbPerson
    {
        public string AbName { get; set; }
        public int AbAlder { get; set; }
        public int AbID { get; set; }

        public void AbSpiser(){
            Console.WriteLine("Vanlig person spiser mat.");
        }

        public abstract void AbIntroduce();
    }
}
