using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Interfaces
{
    interface IDraw
    {
        void SetLocating(int xCoord, int yCoord);
        void Draw(Canvas canvas);
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}