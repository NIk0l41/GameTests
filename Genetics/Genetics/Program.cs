using System;
using System.Collections.Generic;

namespace Genetics
{
    class Program
    {

        List<Bacteria> bacList = new List<Bacteria>();

        void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            Console.WriteLine("So, this is a thing.");
            Console.ReadLine();
            Console.WriteLine("If you hit enter again, you'll enter the environment.");
            Console.ReadLine();
            bool active = true;
            while (active) {
                active = Game();
            }
        }

        bool Game() {
            return false;
        }
    }
}
