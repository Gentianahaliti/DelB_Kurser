using System;

// Jag skapar en student och en kurs för att testa programmet.
Student student = new Student("Anna");
Course course = new Course("Programmering", 2);

// Studenten går med i kursen.
student.Join(course);

// Jag skriver ut kursens studenter och studentens kurser.
course.RollCall();
student.Schedule();
