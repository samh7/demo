using System.IO;
using System.Threading;
namespace ConsoleApp2{
    public class Program{
        static void Main(string[] args){
           CreateFile();
           
        }
        public static void CreateFile(){
            object j = new object();
            // lock(j){
                StreamWriter h = new StreamWriter("file");
                h.Close();
                int[] arrByte = new int[1024*1024*1024];
                for (ulong i = 0; i < (1024*1024*128); i++){
                    arrByte[i] = (int) i;
                    System.Console.WriteLine(arrByte);
                }   
            // }
        }
    }  
}