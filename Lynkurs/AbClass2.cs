using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lynkurs
{
    // For å teste arv mellom abstrakte klasser
    public abstract class AbClass2 : AbClass1
    {
        public string Abname2 { get; set; }

        public void ImplMetode2()
        {
            Console.WriteLine("Metode2 har implementasjon!");
        }
        public abstract void UtenImplMetode2();
    }
}
