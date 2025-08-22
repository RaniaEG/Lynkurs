// See https://aka.ms/new-console-template for more information
using Lynkurs;
using System;

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
