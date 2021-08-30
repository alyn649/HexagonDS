using System;

namespace HexagonDS
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;

            var h1 = new Hexagon(5);
            var h2 = new Hexagon(6, ref h1);

            Console.WriteLine(h2.getContent());
            Console.WriteLine(h2.next.getContent());

            h2.next.setContent(4);

            Console.WriteLine(h2.getContent());
            Console.WriteLine(h2.next.getContent());

        }
    }
}
