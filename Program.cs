// Jag skapar en student och en kurs för att testa programmet.
Student student = new Student("Anna");
Student student2 = new Student("Erik");
Student student3 = new Student("Sara");
Course course = new Course("Programmering", 2);
Course course2 = new Course("Matematik", 2);

// Studenten går med i kursen.
student.Join(course);
student.Join(course2);
course.Enroll(student2);

// Jag försöker anmäla samma student igen.
course.Enroll(student);

// Jag försöker anmäla en student när kursen är full.
course.Enroll(student3);

// Jag skriver ut kursens studenter och studentens kurser.
course.RollCall();
student.Schedule();

// Jag tar bort Erik direkt från kursens håll.
course.Remove(student2);
student2.Schedule();

// Studenten lämnar kursen.
student.Leave(course);
student.Schedule();

// Jag försöker ta bort studenten en gång till.
student.Leave(course);
