using System;

public class Person
{
    protected string name;
    protected int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    protected void Greet()
    {
        Console.WriteLine("Hello, my name is {0} and I am {1} years old.", name, age);
    }
}

public class Student : Person
{
    private string school;

    public Student(string name, int age, string school) : base(name, age)
    {
        this.school = school;
    }

    public void Learn()
    {
        Greet(); // Can call the protected Greet() method in the base class
        Console.WriteLine("I am a student of {0}.", school);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student myStudent = new Student("Alona", 17, "DSW");
        myStudent.Learn();
    }
}
