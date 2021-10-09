using System;

namespace RobertoCobeña3A7
{
    class Program
    {
        static void Main(string[] args)
        {
            int con1 = 0; int con2 = 101;
            do
            {
                con1 = con1 + 1;
                con2 = con2 - 1;
                Console.WriteLine(+con1);
                Console.Write("\t");
                Console.Write("");
                Console.WriteLine(+con2);
            } while (con1 < 100);
        }
    }
}

