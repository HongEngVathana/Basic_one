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
    }
}

