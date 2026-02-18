using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // this program is all about the basics of console and all the methods of console that exists

            // print any input string 
            //Console.WriteLine("hello world");
            //int x = 10;
            //Console.WriteLine($"this is the value of x {x}");


            //string str = "Ankit Kumar";
            ////Console.Write(str);
            ////Console.WriteLine(str);
            //Console.WriteLine($"hello {str}");
            //Console.WriteLine("hello " + str);



            // practice for taking the inputs from the user
            //string st = Console.ReadLine();
            //Console.WriteLine("hello " + st);


            // read function only reads the 1st character of any string and return the corrosping ascii value of that string
            //int st = Console.Read();
            //Console.WriteLine(st);
            //Console.ReadLine();
            //Console.ReadLine();


            // perform adding the two number with taking the user inputs from the user

            //Console.WriteLine("enter any number you want ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter another number you want to choose ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int result = num1 + num2;
            //Console.WriteLine($"the number of both the number is $ {result}");
            //Console.ReadLine();


            // background color for changing background color and forground color for changing text color

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            // this title is set on the top of cmd and replace the file name which is written
            Console.Title = "learning about the background and foreground color"; 
            Console.WriteLine("this is background color ");
            Console.WriteLine("this is text color which i have written ");
            Console.ReadLine();

        }
    }
}