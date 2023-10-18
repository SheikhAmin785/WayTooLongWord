using System;

namespace WayTooLongWord
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

           for(int i = 0; i < n; i++)
            {
                string x= Console.ReadLine();
                int length = x.Length;
                if (length <= 10)
                {
                    Console.WriteLine(x);                }
                else
                {
                    Console.WriteLine($"{x[0]}{length - 2}{x[length-1]}");

                }

            }
            
        }
    }
}
