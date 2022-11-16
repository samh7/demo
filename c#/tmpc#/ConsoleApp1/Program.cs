using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Text;
using System.IO;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            FullAddress address = new FullAddress(123, "Wajaks Street", "Lewinsky Street", "Thika", "Tom", "Jerry", 01019010);
            var hvf = FullAddress.firstName;
            address.GetFullAddress();
        }
    }
    public class ShortAddress
    {
        public string firstName { get; set; }
        public string secondName { get; set; }
        public uint phoneNumber { get; set; }

        public ShortAddress(string FirstName, string SecondName, uint PhoneNumber)
        {
            firstName = FirstName;
            secondName = SecondName;
            phoneNumber = PhoneNumber;
        }

    }

    public class FullAddress : ShortAddress
    {
        public int houseNumber { get; set; }
        public string street1Name { get; set;}
        public string street2Name { get; set;}
        public string cityName { get; set;}

        public FullAddress(int houseNumber, string street1Name, string street2Name, string cityName, string FisrtName, string SecondName, uint PhoneNumber)
            : base(FisrtName, SecondName, PhoneNumber)
        {
            this.houseNumber = houseNumber;
            this.street1Name = street1Name;
            this.street2Name = street2Name;
            this.cityName = cityName;
        }
        public void GetFullAddress()
        {
            Console.WriteLine($"Fisrt Name: {firstName}");
            Console.WriteLine($"Second Name: {secondName}");
            Console.WriteLine($"Phone No.: {phoneNumber}");
            Console.WriteLine($"House Name: {houseNumber}");
            Console.WriteLine($"Street 1 Name: {street1Name}");
            Console.WriteLine($"Street 2 Name: {street2Name}");
            Console.WriteLine($"City Name: {cityName}");
        }
    }
}