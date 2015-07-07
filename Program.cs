using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7_15_ExperIT_StringLab3_Concatenate
{
    class Program
    {
        
  static void Main(string[] args)
        {

            for (int x = 0; x < args.Length; x++)
            {
                Console.Write(args[x].ToUpper());
                Console.Write(",");
            }

            Console.ReadLine();
        }
   



   



    }
}
