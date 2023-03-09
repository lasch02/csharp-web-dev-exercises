// TODO: Instantiate your objects and test your exercise solutions with print statements here.

using Classes;
using System;

Student whateverTheNewName = new Student("Dion", 111, 1, 4.0);
Student rosco = new Student("Rosco", 323);

//Console.WriteLine(whateverTheNewName.Name);

//whateverTheNewName.Name = "D";

//Console.WriteLine(whateverTheNewName.Name);
//Console.WriteLine(rosco.Gpa);

//*********************Does not work******************************
//foreach (Student student in rosco) ;
//{
//    Console.WriteLine(rosco);
//}


//Console.WriteLine(rosco.Name);
//Console.WriteLine(rosco.StudentId);
//Console.WriteLine(rosco.NumberOfCredits);
//Console.WriteLine(rosco.Gpa);

Student joe = new Student("Joe");
Student rob = new Student("Rob");
Student jak = new Student("Jak");
Student bill = new Student("Bill");

Console.WriteLine(joe.StudentId);
Console.WriteLine(rob.StudentId);
Console.WriteLine(jak.StudentId);
Console.WriteLine(bill.StudentId);