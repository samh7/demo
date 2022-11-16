using System;
namespace HelloWorld{
    class Program{
        //first c# program
        static void  Main(string[] args){
            // string  world = "world";
            // string aFriend = "Friend";
            // Console.WriteLine("Hello " + world);
            // Console.WriteLine($"Hello, {aFriend}");
            // int num = world.Length;
            // Console.WriteLine("World has " + world.Length +  " letters");

            // string greeting = "   Hello, World";

            // greeting = greeting.Replace("World", "Friend");
            // Console.WriteLine(greeting.TrimStart());
            // Console.WriteLine(greeting.ToUpper());
            // Console.WriteLine(greeting.Contains("Hello"));
            // Console.WriteLine(num);
        // int  a = 7;
        // int b = 3;

        //unsigned values can hold a minmum value of zero while signed go upto -ve max _value -1
        Console.WriteLine( int.MaxValue);    
        Console.WriteLine( int.MinValue);    
        //short, ushort, long etc

        double radius  = 5;
        double area = Math.PI * radius *radius;
        Console.WriteLine( area);    
        }
    }
}