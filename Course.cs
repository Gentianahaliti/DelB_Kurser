using System;                     // Jag använder System för att kunna skriva ut text i konsolen.
using System.Collections.Generic; // Jag tar in List<> så jag kan skapa listor med studenter.

// Den här klassen är en kurs.
// En kurs har ett namn, ett max antal platser och en lista med studenter.
public class Course
{
    public string Name;                 // Variabel som håller kursens namn.
    public int MaxSeats;                // Variabel som håller hur många studenter som får plats i kursen.
    public List<Student> Students;      // En lista som ska hålla alla studenter som går kursen.

    public Course(string name, int maxSeats)    // Konstruktorn. Den körs automatiskt när jag skapar en kurs.
    {
        Name = name;                            // Sparar kursens namn.
        MaxSeats = maxSeats;                    // Sparar max antal platser.
        Students = new List<Student>();         // Startar en tom lista. Alla kurser börjar utan studenter.
    }

    public void Enroll(Student student)     // Metod som ska anmäla en student till kursen.
    {
        // Kollar om studenten redan finns i kursen.
        if (Students.Contains(student))
        {
            Console.WriteLine($"{student.Name} går redan kursen {Name}.");
            return;
        }

        // Kollar om det finns plats kvar i kursen.
        if (Students.Count < MaxSeats)
        {
            Students.Add(student);          // Lägger till studenten i listan.
            student.Courses.Add(this);      // Lägger till kursen i studentens lista.
            Console.WriteLine($"{student.Name} har anmälts till kursen {Name}.");
        }
        else
        {
            // Om kursen är full skriver jag ut ett meddelande.
            Console.WriteLine($"Kursen {Name} är full. {student.Name} kunde inte anmälas.");
        }
    }

    public void Remove(Student student)     // Metod som ska ta bort en student från kursen.
    {
        // Kollar om studenten finns i listan.
        if (Students.Contains(student))
        {
            Students.Remove(student);       // Tar bort studenten från listan.
            student.Courses.Remove(this);   // Tar bort kursen från studentens lista.
            Console.WriteLine($"{student.Name} har tagits bort från kursen {Name}.");
        }
        else
        {
            // Om studenten inte finns i kursen skriver jag ut ett meddelande.
            Console.WriteLine($"{student.Name} finns inte i kursen {Name}.");
        }
    }

    public void RollCall()                  // Metod som skriver ut alla studenter i kursen.
    {
        Console.WriteLine($"Studenter i kursen {Name}:");  // Skriver ut kursens namn.

        // Kollar om listan är tom.
        if (Students.Count == 0)
        {
            Console.WriteLine("Inga studenter är anmälda ännu."); // Om tom, skriv ut detta.
        }
        else
        {
            // Annars loopar jag igenom listan och skriver ut varje students namn.
            foreach (Student s in Students)
            {
                Console.WriteLine($"- {s.Name}");
            }
        }
    }

    public override string ToString()       // Metod som gör om kursen till text.
    {
        // Returnerar kursens namn och hur många studenter som är anmälda.
        return $"{Name} ({Students.Count}/{MaxSeats} studenter)";
    }
}
