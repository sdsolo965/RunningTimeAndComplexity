using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RunningTimeAndComplexity
{
    class Program
    {
        static void Main(string[] args)
        {
            int reps = Convert.ToInt32(Console.ReadLine());
            List<int> inputVals = new List<int>();
            for (int i = 0; i < reps; i++)
            {
                inputVals.Add(Convert.ToInt32(Console.ReadLine()));
            }

            foreach (var inputVal in inputVals)
            {
                Console.WriteLine(Program.IsPrimeOrNot(inputVal) == false ? "Not prime" : "Prime");
            }

        }

        public static bool IsPrimeOrNot(int inputVal)
        {
            bool prime = inputVal != 1;
                for (int i = 2; i * i <= inputVal; i++)
                {
                    if (inputVal % i != 0) continue;
                    prime = false;
                    break;
                }

            return prime;
        }
    }
}
