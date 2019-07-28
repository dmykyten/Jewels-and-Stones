using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelsAndStones
{
    class Solution
    {
        public static int NumJewelsInStones(string J,string S)
        {
            int output = 0;
            for (int i = 0;i != J.Length; i++)
            {
                if (S.IndexOf(J[i]) != -1 && S.IndexOf(J[i]) != S.Length)
                {
                    output += 1;
                    for (int j = S.IndexOf(J[i]) + 1; j != S.Length; j++)
                    {
                        if (S[j] == J[i])
                            output += 1;
                    }
                }
            }
            return output;
        }
        static void Main(string[] args)
        {
            string Jewels;
            Console.WriteLine("Reading Jewels values:");
            Jewels = Console.ReadLine();
            string Stones;
            Console.WriteLine("Reading Stones values:");
            Stones = Console.ReadLine();
            Console.WriteLine(NumJewelsInStones(Jewels, Stones));
            Console.ReadKey();
        }
    }
}
