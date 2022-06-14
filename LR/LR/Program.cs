
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LR
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split(' ');
            int[] left = new int[n];
            int[] right = new int[n];
            int c = 0;
            right[n - 1] = int.Parse(line[n - 1]);
            for (int i = n - 2; i > 0; i--)
            {
                right[i] = Math.Min(int.Parse(line[i]), right[i + 1]);
            }
            for (int i = 1; i < n - 1; i++)
            {
                left[i] = Math.Max(int.Parse(line[i]), left[i - 1]);
                if (left[i] <= right[i])
                {
                    c++;
                }
            }
            Console.WriteLine(c);
        }
    }
}
