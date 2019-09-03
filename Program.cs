using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp90
{
    class Test
    {
        public int val;
        public Test(int x) { val = x; }
    }

    public class Link
    {
        public int val;
            public Link(int y)
        {
            val = y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            Test test = new Test(x);
            Test test1 = new Test(x);
            Test test2 = new Test(x);
            test = test1 = test2;
            Link link = new Link(x);
            Console.WriteLine(test.val);
            Console.WriteLine(test1.val);
            Console.WriteLine(test2.val);
            x = 5;
            test1.val = 15;
            Console.WriteLine(test.val);
            Console.WriteLine(test1.val);
            Console.WriteLine(test2.val);
        }
    }
}
