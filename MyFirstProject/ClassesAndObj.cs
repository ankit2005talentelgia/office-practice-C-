using System;

namespace MyFirstProject
{
    internal class ClassesAndObj
    {
        // Basic Class examples with default & parametrized constructor

        //class Students
        //{
        //    private int studentId;
        //    private string name;
        //    private int age;
        //    private int marks;

        //    public Students()
        //    {
        //        studentId = 0;
        //        name = "";
        //        age = 0;
        //        marks = 0;
        //        Console.WriteLine("hello from default constructor");
        //    }

        //public Students(int studentId, string name,int age,int marks)
        //{
        //    this.studentId = studentId;
        //    this.name = name;
        //    this.age = age;
        //    this.marks = marks;
        //}
        //    public void getDetails()
        //    {
        //        Console.WriteLine($"all the details is :{ studentId}, {name}, {age}, {marks}");
        //    }
        //}



        // Abstract class starts
        //public abstract class Car
        //{
        //    public abstract void Start();
        //    public abstract void Sound();
        //}

        //public class Toyota:Car{
        //    public override void Start()
        //    {
        //        Console.WriteLine("toyota car started");
        //    }

        //    public override void Sound()
        //    {
        //        Console.WriteLine("toyota car is started and make very loud sounds");
        //    }
        //}


        // static and non static constructor
        //class Students
        //{
        //    static string school;
        //    string name;

        //    static Students(){
        //        school = "Harrow English School";
        //    }

        //    public Students()
        //    {
        //        name = "Ankit Kumar";
        //    }

        //    static public void DisplaySchool()
        //    {
        //        Console.WriteLine(school);
        //    }
        //    public void DisplayName()
        //    {
        //        Console.WriteLine($"name of this student is: {name}");
        //    }
        //}


        class Students
        {
            private Students()
            {
                Console.WriteLine("This is Private Constructor");
            }

            public void Display()
            {
                Console.WriteLine("method is calling");
            }
        }


        static void Main(string[] args)
        {
            //Students s = new Students(202563,"Ankit Kumar", 20, 98);
            //Students s = new Students();
            //s.getDetails();


            // objects of car class
            //Toyota t = new Toyota();
            //t.Start();


            //  static and non static methods
            //Students s = new Students();
            //s.DisplayName();
            //Students.DisplaySchool();


            // this is shows that we cannot make a private constructor's object as it is inaccessible.
            //Students s = new Students();
            //s.Display();
             Console.ReadLine();
        } 
    }
}
