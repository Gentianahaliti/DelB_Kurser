using System;  
using System.Collections.Generic;
// Jag tar in System-biblioteket. Det behövs för grundläggande saker i C#,
// som att kunna skriva ut text med Console.WriteLine och använda vanliga funktioner.

// Den här klassen är en student.
// En klass är som en mall. Jag kan skapa flera studenter från samma mall.
// Varje student kommer ha sin egen data (t.ex. sitt eget namn).
public class Student
{
    public string Name;   // Här skapar jag en variabel som ska hålla studentens namn.
                          // Typen är string, vilket betyder text.
    public List<Course> Courses; // En lista som håller alla kurser studenten går.

    public Student(string name)   // Detta är konstruktorn.
                                  // Den körs automatiskt när jag skapar en ny student.
                                  // Jag måste skicka in ett namn när jag skapar en student.
    {
        Name = name;              // Här sparar jag namnet jag fick in i variabeln Name.
                                  // Det betyder att studenten får sitt namn direkt när den skapas.
        Courses = new List<Course>(); // Startar en tom lista över studentens kurser.
    }

    public void Join(Course course) // Metod som låter studenten gå med i en kurs.
    {
        course.Enroll(this);        // Anmäler studenten till kursen.
    }

    public void Leave(Course course) // Metod som låter studenten lämna en kurs.
    {
        course.Remove(this);         // Tar bort studenten från kursen.
    }

    public void Schedule() // Metod som skriver ut studentens kurser.
    {
        Console.WriteLine($"Kurser för {Name}:"); // Skriver ut studentens namn.

        // Kollar om studenten inte går någon kurs.
        if (Courses.Count == 0)
        {
            Console.WriteLine("Studenten går inte någon kurs ännu.");
        }
        else
        {
            // Skriver ut kurserna som studenten går.
            foreach (Course course in Courses)
            {
                Console.WriteLine($"- {course.Name}");
            }
        }
    }

    public override string ToString() // Metod som gör om studenten till text.
    {
        return Name; // Returnerar studentens namn.
    }
}
