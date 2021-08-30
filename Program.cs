using System;

namespace HexagonDS
{
    class Program
    {
        static void Main(string[] args)
        {

            var h1 = new Hexagon();
            var h2 = new Hexagon();

            h1.val(7);
            h2.val(8);

            Console.WriteLine(h1.val());
            Console.WriteLine(h2.val());

            h1[0] = h2;

            h2.val(9);
            h1.val(10);

            Console.WriteLine(h1[0].val());
            Console.WriteLine(h2[5].val());

        }
    }
}
