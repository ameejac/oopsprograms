using System;

namespace oops
{
    class Program
    {

        public void MainFunction()
        {
            Console.WriteLine("Main class");
        }
        static void Main(string[] args)
        {
            //main class instance
            Program obj = new Program();
            obj.MainFunction();


            Program obj2 = new Program();
            obj2.MainFunction();

            //other class instace
            demo dObj = new demo();
            dObj.addition();

            demo amee = new demo();
            amee.addition();
        }
    }

    class demo
    {
        int x = 10;
        int y = 20;
        int z;

        public void addition()
        {
            z = x + y;
            Console.WriteLine("other class in Namespace");
            Console.WriteLine(z);
        }
    }
}
