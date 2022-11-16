using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Text;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirName = @"FileFile";
            if (Directory.Exists(dirName)) { }
            else
            {
                Directory.CreateDirectory(dirName);
            }
            string fileName = @"FileFile/FileFile.txt";
            if (File.Exists(fileName))
            {
                Console.WriteLine("File Exists");
                string[] textToWrite = new string[] { "hello", "goodbye", "world" };
                File.AppendAllLines(fileName, textToWrite);
                Console.WriteLine("File Written To");


            }
            else
            {
                File.Create(fileName).Close();
                Console.WriteLine("File Created");
                string[] textToWrite = new string[] { "hello", "goodbye", "world" };
                File.WriteAllLines(fileName, textToWrite);
                Console.WriteLine("File Written To");
            }
            var fInfo = new FileInfo(fileName);
            byte[] byteFile = File.ReadAllBytes(fileName);
            Console.WriteLine(byteFile.ToString());
            var fileName2 = @"FileFile/File/";
            File.WriteAllBytes(fileName, byteFile);
            var drives = Directory.GetLogicalDrives();
            foreach (var drive in drives)
            {

                Console.WriteLine(drive);
            }

            var files = Directory.GetFiles("FileFile");
            Console.WriteLine();
            foreach (var file in files)
            {

                Console.WriteLine(file);
            }

            Console.WriteLine();


            var subFolders = Directory.GetDirectories("/Users");
            foreach (var folder  in subFolders)
            {

                Console.WriteLine(folder);
            }

        }


    }

}