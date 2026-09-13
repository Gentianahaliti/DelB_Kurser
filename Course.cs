using System;                     // Jag använder System för att kunna skriva ut text i konsolen.
using System.Collections.Generic; // Jag behöver List<> för att kunna ha listor med studenter.

// Den här klassen är en kurs.
// En kurs har ett namn, ett max antal platser och en lista med studenter.
public class Course
{
    public string Name;                 // Namnet på kursen.
    public int MaxSeats;                // Hur många studenter som får plats i kursen.
    public List<Student> Students;      // En lista som håller alla studenter som går kursen.
        public Course(string name, int maxSeats)    // Den här metoden körs när man skapar en kurs
    {
        Name = name;                            // Sparar namnet som skickas in
        MaxSeats = maxSeats;                    // Sparar max antal platser som skickas in
        Students = new List<Student>();         // Startar en tom lista med studenter (alla kurser börjar tomma)
    }
        public void Enroll(Student student)     // Metod som ska anmäla en student till kursen
    {
        // Logik kommer senare
    }

    public void Remove(Student student)     // Metod som ska ta bort en student från kursen
    {
        // Logik kommer senare
    }

    public void RollCall()                  // Metod som skriver ut alla studenter i kursen
    {
        // Logik kommer senare
    }

    public override string ToString()       // Metod som gör om kursen till text
    {
        return "";                          // Fylls i senare
    }
