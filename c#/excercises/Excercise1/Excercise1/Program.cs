using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Timers;

namespace Excercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time();

            time = 121;
            Console.WriteLine(time.ToString());

            int minutes = (int)time;
            Console.WriteLine(minutes);


            Time.HelloWorld();
        }
    }
}





public  struct Time
{

    private readonly int minutes;
    private int MM;
    private int HH;
    public Time(int hh, int mm)
    {
        HH = hh;
        MM = mm;
        minutes = hh * 60 + mm;
    }

    public Time ToTime(int mins)
    {
        int hours = 0;
        while (mins%60 == 0)
        {   
            hours++;
            mins-=60;
        }
        int minutes = mins;
        return new Time(hours,minutes);
    }

    public int Minutes()
    {
        return MM;
    }
    public int TotalMinutes()
    {
        int mins = HH * 60 + MM;
        return mins;
    }
    public override string ToString()
    {
        return $"{HH}:{MM}";
    }
    public static Time operator +(Time left, Time right)
     {
        Time newTime = new Time(0,0);
        newTime.MM = left.MM + right.MM;
        newTime.HH = left.HH + right.HH;
        return  newTime;
    }

    public static Time operator +(Time left, int right)
    {
        Time newTime = new Time(0, 0);
        newTime.HH = left.HH + right;
        newTime.MM = left.MM + right;
        return newTime;
    }

    public static Time operator -(Time left, Time right)
    {
        Time newTime = new Time(0, 0);
        newTime.MM = left.MM - right.MM;
        newTime.HH = left.HH - right.HH;
        return newTime;
    }
    public static void HelloWorld()
    {
        Console.WriteLine("Hello, World");
    }

    public static implicit operator Time(int number)
    {
        Time time_ = new Time();
        int hours = (int) number / 60;
        number -= (hours * 60);
        time_.HH = hours;
        time_.MM = number;
        return time_;
    }

    //static in types means they wiil ony have static members
    //static is used for memnber variables/methods that dont need instances of the type to be created
    public static explicit operator int(Time time)
    {
        return time.TotalMinutes();
    }
  
}