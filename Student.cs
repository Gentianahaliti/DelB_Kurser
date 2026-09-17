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
}
