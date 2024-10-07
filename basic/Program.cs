using System;

namespace basic;
class Program
{
    static void Main(string[] args)
    {
        int code = 123;
        double salary = 20000.99;
        char gender= 'M';
        string name = "Hong EngVathana";
        bool isSingle = true;
        Console.WriteLine("Hello All My Nameis :Hong EngVathana,I Live in Sream Reap(Angkor Wat) in Cambodia, So I'm a Poor Student I Live With Small Family And I Love My Family So Muose, Today I'm a Student in Rupp Year 2, My Mager is IT, I Have a plean For My lift to learn in USA  I want to be the base Developer ");
        Console.WriteLine("Today 6 Oct 2024 I learn C# Becouse I want to be a Developer FullStack With C# .NET ");
        Console.WriteLine(code + salary + gender + name + isSingle);
        Console.WriteLine("=========================================");
        Console.WriteLine("Code    :" + code);
        Console.WriteLine("Salary  :" + salary+"$");
        Console.WriteLine("Name    :" + name);
        Console.WriteLine("isSingle:" + isSingle);
        Console.WriteLine("=========================================");
        string mynameis = "Vathana";
        Console.WriteLine("Hello"+"  " + mynameis);
        Console.WriteLine("==================string=======================");
        string fistName = "Vathana";
        string lastName = "Hong";
        string fullName =fistName + lastName;
        Console.WriteLine(fullName);
        Console.WriteLine("===================int======================");
        int x = 5;
        int y = 6;
        Console.WriteLine(x * y);
        //To declare more than one variable of the same type, use a comma-separated list:
        int z =6,t=4,r=9;
        Console.WriteLine(z + t + r);
        //You can also assign the same value to multiple variables in one line:
        int g, b, d;
        g = b = d = 60;
        Console.WriteLine(g + b + d);
        Console.WriteLine("===================Identifiers======================");
        // Good
        int minutesPerHour = 60;
        // OK, but not so easy to understand what m actually is
        int m = 60;
        Console.WriteLine(minutesPerHour);
        Console.WriteLine(m);
        Console.WriteLine("===================Type_Casting======================");

        int myInt = 30;
        double myDouble = myInt;
        Console.WriteLine(myInt);
        Console.WriteLine(myDouble);

        Console.WriteLine("===================Canting======================");

        double myDouble2 = 99.99;
        int myI = (int)myDouble;

        Console.WriteLine(myDouble2);
        Console.WriteLine(myI);

        Console.WriteLine("Enter username:");
        string userName = Console.ReadLine();

        Console.WriteLine("Username is:" + userName);
        Console.WriteLine("=========================================");
        int n = 100 + 50;

        Console.WriteLine(n);

        Console.WriteLine("=========================================");

        int e = 90;
        e += 4;

        Console.WriteLine(e);
        Console.WriteLine("===================Math======================");

        Console.WriteLine(Math.Max(5, 10));
        Console.WriteLine(Math.Sqrt(69));
        Console.WriteLine(Math.Abs(-4.7));
        Console.WriteLine(Math.Round(10.102));

        Console.WriteLine("===============Strign==========================");

        string greeting = "Hello";
        Console.WriteLine(greeting);

        string text = "AIEHGPEIRHGKEPJRHGKEWJRHGEKWJRHGIWERH";
        Console.WriteLine("The length of the text string is:" + text.Length);

        string text1 = "Hello World";
        // Outputs "HELLO WORLD"
        Console.WriteLine(text1.ToUpper());
        Console.WriteLine(text1.ToLower());




    }
}

