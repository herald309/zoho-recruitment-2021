using System;
using System.Text;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder builder = new StringBuilder();
            int middle = input.Length / 2;
            for(int i= middle; i< input.Length; i++)
            {
                builder.Append(input[i]);
                Console.WriteLine(builder.ToString());
            }

            int lastElement = input.Length - (middle +1);
            for (int i = 0; i < lastElement; i++)
            {
                builder.Append(input[i]);
                Console.WriteLine(builder.ToString());
            }
            Console.ReadKey();
        }
    }
}
