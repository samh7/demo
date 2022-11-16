
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using ConsoleApp1;

Animal bowser = new Animal("Boswer", 25, 45);
            Stream stream = File.Open("Animal.dat",
                FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, bowser);
            stream.Close();
            bowser = null;
            stream = File.Open("Animal.dat",
                FileMode.Open);
            bowser = (Animal)bf.Deserialize(stream);
            stream.Close();
            Console.WriteLine(bowser.ToString());


            bowser.Weight = 80;
            bowser.Height = 45 ;
            XmlSerializer serializer = new XmlSerializer(typeof(Animal));
            using(StreamWriter tw = new StreamWriter(@"C:\Users\Cy\c#\bowser.xml"))
            {
                serializer.Serialize(tw, bowser);
            }
            bowser = null;
            XmlSerializer deserializer = new XmlSerializer(typeof(Animal));

            StreamReader reader = new StreamReader(@"C:\Users\Cy\c#\bowser.xml");
            object obj = deserializer.Deserialize(reader);
            bowser = (Animal)obj;
            reader.Close();
            Console.WriteLine(bowser.ToString());

            List<Animal> theAnimals = new List<Animal>
            {
                new Animal("Mario", 40, 20),
                new Animal("Luigi", 30, 14),
                new Animal("P3ach", 60, 40),
            };
            using (Stream fs = new FileStream(@"animals.xml", FileMode.Create))
            {
                XmlSerializer serializer2 = new XmlSerializer(typeof(List<Animal>));
                serializer2.Serialize(fs, theAnimals);
            }
            theAnimals = null;


            StreamReader reader2 = new StreamReader("animals.xml");
            XmlSerializer deserializer2 = new XmlSerializer(typeof(List<Animal>));
           object obj2 = deserializer2.Deserialize(reader2);
            theAnimals = (List<Animal>)obj2;


            foreach(var item in theAnimals)
            {
                Console.WriteLine(item.ToString());
            }