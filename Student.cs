using System;

// Den här klassen är en student.
// En student har ett namn och senare kan vi lägga till mer info.
public class Student
{
    public string Name;   // Namnet på studenten

    public Student(string name)   // Konstruktor som körs när man skapar en student
    {
        Name = name;              // Sparar namnet som skickas in
    }
}
