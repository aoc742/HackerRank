using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerlandRadioTransmiterrs
{
    class Program
    {
        static int hackerlandRadioTransmitters(int[] x, int k)
        {
            // Complete this function
        }

        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] x_temp = Console.ReadLine().Split(' ');
            int[] x = Array.ConvertAll(x_temp, Int32.Parse);
            int result = hackerlandRadioTransmitters(x, k);
            Console.WriteLine(result);
        }
    }
}
