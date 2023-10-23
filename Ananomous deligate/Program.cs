using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Ananomous deligate means ,We can define the method and call the deligate in a single line. 
namespace Ananomous_deligate
{
    public delegate void addDeligate(int x,int y);
    class Program
    {
        static void Main(string[] args)
        {
            addDeligate obj = delegate (int x, int y) {

                Console.WriteLine("My two no is " + x + "and " + y);
            
            };
            obj.Invoke(12, 45);
            Console.Read();
        }
    }
}
