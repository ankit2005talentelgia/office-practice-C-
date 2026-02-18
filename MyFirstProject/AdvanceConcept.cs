using System;

namespace MyFirstProject
{
    class AdvanceConcepts
    {
        // this is function overloading

        //static int sum(int a,int b)
        //{
        //    return a + b;
        //}

        //static int sum(int a,int b,int c)
        //{
        //    return a + b + c;
        //}

        //static double sum(double a,double b)
        //{
        //    return a + b;
        //}

        // print the details of the students
        //static void printDetails(string name,int age, int collId,int marks)
        //{
        //    Console.WriteLine($"name of student is: {name}");
        //    Console.WriteLine($"Age of this student is: {age}");
        //    Console.WriteLine($"college id of this student is: {collId}");
        //    Console.WriteLine($"maths makrs of this student is: {marks}");
        //}

        // class implementation of the students details
        class StudentDetails
        {
            public string name { get; set; }
            public int age { get; set; }
            public int collId { get; set; }
            public int marks { get; set; }

            // set the value with the help of constructor
            public StudentDetails(string name, int age, int collId, int marks)
            {
                this.name = name;
                this.age = age;
                this.collId = collId;
                this.marks = marks;
            }

            // print the students details
            public void printDetails()
            {
                Console.WriteLine($"name of the student is: {this.name}");
                Console.WriteLine($"Age of this student is: {this.age}");
                Console.WriteLine($"college id of this student is: {this.collId}");
                Console.WriteLine($"maths makrs of this student is: {this.marks}");
            }

        }

        static void Main(string[] args)
        {
            //Console.WriteLine($"sum of two number is {sum(2,3)}");
            //Console.WriteLine(sum(1, 2, 3));
            //Console.WriteLine(sum(3.2, 5.2));

            //Console.WriteLine("enter your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("enter your age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter your college id number");
            //int collId = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter your marks in maths");
            //int marks = Convert.ToInt32(Console.ReadLine());

            //printDetails(name, age, collId, marks);



            // Now make this things with the help of class
            StudentDetails stdnt = new StudentDetails("Ankit Kumar", 20, 2236694, 98);
            //stdnt.name = "ankit Kumar";
            //stdnt.age = 20;
            //stdnt.collId = 2233695;
            //stdnt.marks = 98;
            stdnt.printDetails();

            Console.ReadLine();
        }
    }
}