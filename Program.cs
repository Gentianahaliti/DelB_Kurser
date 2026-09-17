using System;

// Jag skapar en student och en kurs för att testa programmet.
Student student = new Student("Anna");
Student student2 = new Student("Erik");
Student student3 = new Student("Sara");
Course course = new Course("Programmering", 2);

// Studenten går med i kursen.
student.Join(course);
course.Enroll(student2);

// Jag försöker anmäla samma student igen.
course.Enroll(student);

// Jag försöker anmäla en student när kursen är full.
course.Enroll(student3);

// Jag skriver ut kursens studenter och studentens kurser.
course.RollCall();
student.Schedule();
