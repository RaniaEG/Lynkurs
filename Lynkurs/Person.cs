using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lynkurs
{
    public class Person
    {
        // auto-implementerte egenskaper med verdi sjekk
        private string personName; // global variabel og er synlig kun til alle metodene i Person klasse
        public string PersonName
        {
            get { return personName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    Console.WriteLine("Du Du må gi et navn");

                else
                {
                    personName = value;
                }
            }
        }

        private int personAge;
        public int PersonAge
        {
            get { return personAge; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Du må gi positivt tall til alderen");

                else
                {
                    personAge = value;
                }
            }
        }

        // bruk av auto-implementerte egenskaper
        public string Name { get; set; }
        public int Age { get; set; }

        // bruk av instans variabler og set/get metoder
        private string name;
        private int age;

        public void SetName(string _name)
        {
            name = _name;
        }
        public string GetName()
        {
            return name;
        }

        public void SetAge(int _age)
        {
            age = _age;
        }
        public int GetAge()
        {
            return age;
        }

        // method overloading: to metoder har samme signatur men forskjellig antall parametere
        public void Spiser()
        {
            Console.WriteLine(this.name + " spiser mat");
        }

        public void Spiser(string mat)
        {
            // num er in lokal variabel og er synlig kun i denne metoden
            int num = 2;
            Console.WriteLine($"{this.name} spiser {mat}");
        }

        // Introduce metode er virtual og skal overrides i barneklassene
        public virtual void Introduce()
        {
            // Set PersonName if true, otherwise use the 'ukjent' string if false
            string displayName = !string.IsNullOrWhiteSpace(PersonName) ? PersonName : "Ukjent";

            // Set PersonAge if true, otherwise use the '0' value if false
            int displayAge = PersonAge > 0 ? PersonAge : 0;
            Console.WriteLine($"Hei! Jeg heter {displayName} og er {displayAge} år gammel.");
        }
    }
}
