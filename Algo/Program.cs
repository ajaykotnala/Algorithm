using System;

namespace Algo
{
    class Program
    {
        static void Main(string[] args)
        {

            //string balancedParentheses = "[()()]";// this is balanced else ')(' or '[(}]' this is unbalanced
            Console.WriteLine("Hello World!");

            ImplementBST obj = new ImplementBST();
           // obj.searchBST();
            obj.TraverseBST();
            //Base obj = new Child();
            //obj.M();
            // Child obj11 = new Base();
        }


    }

    class Base
    {
        public void M()
        {
            Console.WriteLine("this is m base");
        }
    }

    class Child : Base
    {
        public void M()
        {
            Console.WriteLine("this is m child");
        }
    }
}
