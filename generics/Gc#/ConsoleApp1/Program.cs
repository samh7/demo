using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
namespace ConsoleApp1
{
    public class Program
    { 
        static void Main(string[] args)
        {
            // if(DateTime.Now.ToString() == DateTime.")
            //    System.Console.WriteLine(DateTime.Now.ToString());
            
            // else8601 = YYYY-MM-DD
            //C#Date = MM-DD-TT
        DateTime date = new DateTime();
                // System.Console.WriteLine("Hello, World");
                date = DateTime.Now;
                // string dateString = (string) Convert.ToString(date.ToShortTimeString());
                if (date.ToShortDateString() == "11/9/2022" && date.ToShortTimeString() == "11:09 AM")

                        System.Console.WriteLine(date.ToShortTimeString());
                    else 
                    System.Console.WriteLine("Hello, World");
                // if (date.ToShortDateString() == "10/9/2022")
                //     System.Console.WriteLine("Happy New Year");
                // else
                //     System.Console.WriteLine("Still 2021");
        }
    }   
}