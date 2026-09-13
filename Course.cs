using System;                     // Jag använder System för att kunna skriva ut text i konsolen.
using System.Collections.Generic; // Jag behöver List<> för att kunna ha listor med studenter.

// Den här klassen är en kurs.
// En kurs har ett namn, ett max antal platser och en lista med studenter.
public class Course
{
    public string Name;                 // Namnet på kursen.
    public int MaxSeats;                // Hur många studenter som får plats i kursen.
    public List<Student> Students;      // En lista som håller alla studenter som går kursen.
    