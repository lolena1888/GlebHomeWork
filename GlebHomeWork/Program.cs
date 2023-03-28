//Создайте структуру с именем train, содержащую поля: название пункта назначения, номер поезда, время отправления.
//Другой класс: массив из пяти элементов типа train, иметь возможность упорядочить(отсортировать) элементы по номерам поездов.
//Добавить возможность вывода информации о поезде, номер которого введен пользователем.
//Добавить возможность сортировки массив по пункту назначения, причем поезда с одинаковыми пунктами назначения должны быть упорядочены по времени отправления.


// Создать класс с двумя переменными. Добавить функцию вывода на экран и функцию изменения этих переменных.
// Добавить функцию, которая находит сумму значений этих переменных, и функцию которая находит наибольшее значение из этих двух переменных.

var gleb = new Person(18, "Gleb Tchernych");
var elena = new Person(57, "Elena Lavrinenko");

gleb.PersonInfo();
elena.PersonInfo();




public class Person
{
    public Person()
    {
        
    }

    public Person(int age,string name)
    {
        Age = age;
        Name = name;
    }
    public int Age { get; set; }
    public string Name { get; set; }
    public int Birthday { get; set;}
    public string Address { get; set; }

    public void PersonInfo()
    {
        Console.WriteLine("Class Person");
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
    public void Walk()
    {
        Console.WriteLine("Walking");
    }

    public void Work()
    {
        Console.WriteLine("Working");

    }

}

public class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }
    public DateTime StartWorkAt { get; set; }

    public void ReportTo()
    {
        Console.WriteLine("Reporting");
    }
}

public class Student
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string Class { get; set; }
    public string[] Grades { get; set; }

    public void Exam()
    {
        Console.WriteLine("Getting exam");
    }
}
public class Athlete
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string Sport { get; set; }
    public void Compete()
    {
        Console.WriteLine("Competing");
    }


}
