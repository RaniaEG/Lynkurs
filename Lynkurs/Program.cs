// See https://aka.ms/new-console-template for more information
using Lynkurs;
using System;
using System.Globalization;

/*
//Forelesning 1
Console.WriteLine("Hello, World!");

// variabler og datatyper
int nummer = 30;
string text1 = nummer.ToString();
// int til string
string text2 = "lynkurs";
Console.WriteLine(text2[1]);
// string til int
int input = int.Parse(Console.ReadLine());


// klasser og objekter

// oppretter et objekt av klasse Person
Person person = new Person();

// ved bruk av instans variabler og set/get metoder
person.SetName("Håkon");
string personName = person.GetName();
Console.WriteLine(personName);

person.SetAge(20);
// enten den
int personAge = person.GetAge();
Console.WriteLine(personAge);
//eller den
Console.WriteLine(person.GetAge());

Person person1 = new Person();

// auto-implementerte egenskaper
person1.Name = "Elin";
person1.Age = 19;
Console.WriteLine($"Person {person1.Name} er {person1.Age} år gammel");

// auto-implementerte egenskaper med verdi sjekk
Person person2 = new Person();
person2.PersonName = "Kristian";
person2.PersonAge = -20;
Console.WriteLine($"Person {person2.PersonName} er {person2.PersonAge} år gammel");
Person person3 = new Person();

person3.PersonName = "";
person3.PersonAge = 22;
Console.WriteLine($"Person {person3.PersonName} er {person3.PersonAge} år gammel");


// metoder (metode overloading)
person.Spiser();
person.Spiser("Kylling");


// if-betingelse og operatører
int tall1 = 5;
int tall2 = 10;

// for å sammenligne tall1 med tall2 
if (tall1 == tall2)
    Console.WriteLine("Tallene er like.");
else
    Console.WriteLine("Tallene er ikke like.");

// for å finne ut hvilket tall er det største
if (tall1 > tall2) // denne skal alltid ha betingelse
    Console.WriteLine($"Tall1 {tall1} er den største.");
else if (tall2 > tall1)   // denne skal alltid ha betingelse
    Console.WriteLine($"Tall2 {tall2} er den største.");
else    // denne skal ikke ha betingelse
    Console.WriteLine("Tallene er like");

// for å finne ut om tallet er oddetall eller partall
Console.WriteLine("Vennligst skriv et tall: ");
int x = int.Parse(Console.ReadLine());
if (x % 2 == 0)
    Console.WriteLine($"Tallet {x} er partall.");
else if (x % 2 == 1)
    Console.WriteLine($"Tallet {x} er oddetall.");
else
    Console.WriteLine($"Tallet {x} er verken oddetall eller partall.");
*/


//Forelesning 2
// var er noe i C# som heter type inference
var p1 = new Person { PersonName = "Ole", PersonAge = 12 };
/*Person p1 = new Person();
p1.PersonName = "Ole";
p1.PersonAge = 12; */
var p2 = new Person { PersonName = "Ida", PersonAge = 20 };
var p3 = new Person { PersonName = "Karoline", PersonAge = 35 };

// List<Person>
List<Person> persons = new List<Person>(3);
persons.Add(p1);
persons.Add(p2);
persons.Add(p3);

//Console.WriteLine("Antall elementer i persons liste: " + persons.Count 
//    + " og antall plasser i persons liste: " + persons.Capacity);

persons.Add(new Person { PersonName = "Espen", PersonAge = 17 });
//Console.WriteLine("Antall elementer i persons liste: " + persons.Count
//    + " og antall plasser i persons liste: " + persons.Capacity);

// Foreach with persons
//foreach (Person person in persons)
//{
//    Console.WriteLine(person.PersonName + " - " + person.PersonAge);
//}

// For loop with persons 
//for (int i=0;i<persons.Count;i++)
//{
// Check value of auto-implemented property for a specified element in the list
//    if (persons[i].PersonName == "Espen")
//        Console.WriteLine(persons[i].PersonName + " - " + persons[i].PersonAge);
// Check if element p1 exists to print it
//    if (persons.Contains(p1))
//        Console.WriteLine("person's name: "+persons[i].PersonName + " and person's age: " + persons[i].PersonAge);
//    break;
//}

// While loop with persons
//int j = 0;
//while (j<persons.Count) // pass på at betingelsen ikke er true hele tiden
//{
//    Console.WriteLine(persons[j].PersonName + " - " + persons[j].PersonAge);
//    j++;
//}

// Do/while loop
//int j = 6;
//do
//{ 
//    Console.WriteLine(j);
//    j++;
//}
//while (j<4);


// LINQ query
//var namesQuery =
//    from p in persons
//    where p.PersonAge >= 18
//    orderby p.PersonAge ascending
//    select p.PersonName;

//List<string> adultNames = namesQuery.ToList();

//Console.WriteLine("\nLooping throughout a LINQ query:");
//foreach (string name in namesQuery)
//{
//    Console.WriteLine(name);
//}
// Looping throughout a list of results from the LINQ query
//foreach (string name in adultNames)
//{
//    Console.WriteLine(name);
//}


// Array of integers
//int[] scores = { 55, 72, 91, 40, 88 };
//Console.WriteLine("for loop wit array:");
//for (int i = 0; i < scores.Length; i++)
//{
//    Console.WriteLine("scores[" + i + "] = " + scores[i]);
//}

// Array of strings
//string[] namesArray = new string[] { "Leila", "Øyvind", "Mona" };
//Console.WriteLine("Print array elements with foreach loop:");
//foreach (string n in namesArray)
//{
//    Console.WriteLine("Name: " + n);
//}



// Inheritance + method overrides

// Create object of type Student
Student s1 = new Student
{
    PersonName = "Sindre",
    PersonAge = 19,
    CoursesTaken = new List<string> { "Databases", "Object-Oriented Programming", "Algorithms" }
};

// Create object of type Teacher
Teacher t1 = new Teacher { PersonName = "David", PersonAge = 45, Subject = "Mathematics" };

// Polymorphic list (base type references, derived instances)
List<Person> schoolPeople = new List<Person>();
schoolPeople.Add(s1);
schoolPeople.Add(t1);
schoolPeople.Add(p1);

// Which Introduce() method will be executed ????
foreach (Person person in schoolPeople)
{
    person.Introduce();

}




