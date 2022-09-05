using System;
namespace Hello
{
    class Hello
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split();
            int a = int.Parse(ss[0]);
            int b = int.Parse(ss[1]);
            if(b-45<0)
            {
                if(a-1<0)
                {
                    Console.WriteLine("{0} {1}", 23, b + 15);
                }
                else
                {
                    Console.WriteLine("{0} {1}", a - 1, b + 15);
                }
            }
            else
            {
                Console.WriteLine("{0} {1}", a, b - 45);
            }
        }


    }
}