using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lynkurs
{
    public abstract class AbClass1
    {
        public string Abname { get; set; }

        public void ImplMetode()
        {
            Console.WriteLine("Denne metoden har implementasjon!");
        }
        public abstract void UtenImplMetode();
    }
}
