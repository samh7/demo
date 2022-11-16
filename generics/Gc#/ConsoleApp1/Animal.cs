using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   [Serializable()]
    public class Animal: ISerializable
    {
        public string? Name { get; set; }
        public double? Weight { get; set; }
        public double? Height { get; set; }
        public int? AnimalID { get; set; }
        public Animal() { }
        public Animal(string name = "No Name",
            double height = 0,
            double weight = 0)
        {
            Name = name;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return $"{Name} of height {Height} weighs {Weight}";
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Height", Height);
            info.AddValue("Weight", Weight);
        }

        public Animal(SerializationInfo info, StreamingContext context)
        {
            Name = (string?)info.GetValue("Name", typeof(string));
            Weight = (double?)info.GetValue("Weight", typeof(double));
            Height = (double?)info.GetValue("Height", typeof(double));
        }
    }
}
