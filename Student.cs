using System;  
using System.Collections.Generic;
// Jag tar in System-biblioteket. Det behövs för grundläggande saker i C#,
// som att kunna skriva ut text med Console.WriteLine och använda vanliga funktioner.
// Detta behöver jag också för att kunna få tillgång till List<> i C#.

// Den här klassen är en student.
// En klass är som en mall. Jag kan skapa flera studenter från samma mall.
// Varje student kommer ha sin egen data, till exempel sitt namn och sina kurser.
public class Student
{
    public string Name;   // Här sparar jag studentens namn.
                          // Typen string betyder text.
    public List<Course> Courses; // Den här listan håller alla kurser som studenten går i.

    public Student(string name)   // Detta är konstruktorn.
                                  // Den körs när jag skapar en ny student.
                                  // Jag skickar med ett namn när jag skapar studenten.
    {
        Name = name;              // Här sparar jag namnet som jag fick in.
                                  // Nu har studenten ett namn direkt.
        Courses = new List<Course>(); // Jag startar en tom lista över kurserna.
    }

    public void Join(Course course) // Den här metoden gör att studenten går med i en kurs.
    {
        // Jag anropar kursens metod som anmäler studenten.
        // Då blir kursen och studenten kopplade ihop.
        course.Enroll(this);        // Jag skickar med den här studenten till kursen.
    }

    public void Leave(Course course) // Den här metoden gör att studenten lämnar en kurs.
    {
        // Jag anropar kursens metod som tar bort studenten.
        // Då tas studenten bort från kursen och kursen tas bort från studentens lista.
        course.Remove(this);         // Jag skickar med den här studenten till kursen.
    }

    public void Schedule() // Den här metoden skriver ut vilka kurser studenten går.
    {
        // Jag skriver först en rubrik med studentens namn.
        Console.WriteLine($"Kurser för {Name}:");

        // Om listan är tom betyder det att studenten inte går i någon kurs.
        if (Courses.Count == 0)
        {
            Console.WriteLine("Studenten går inte någon kurs ännu.");
        }
        else
        {
            // Om listan inte är tom går jag igenom alla kurser en i taget.
            foreach (Course course in Courses)
            {
                // Jag skriver ut namnet på varje kurs.
                Console.WriteLine($"- {course.Name}");
            }
        }
    }

    public override string ToString() // Den här metoden gör att studenten visas som text.
    {
        // När programmet behöver skriva ut studenten returnerar den bara namnet.
        return Name;
    }
}
