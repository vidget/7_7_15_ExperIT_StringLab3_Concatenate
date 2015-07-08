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

            StringBuilder newString = new System.Text.StringBuilder();

            for (int x = 0; x < args.Length; x++)
            {
                newString.Append(args[x]);
                newString.Append(",");
            }

            Console.WriteLine(newString);
            Console.ReadLine();
        }
   



    }
}
