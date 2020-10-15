using System;
using System.Collections.Generic;

namespace Genetics
{
    class Program
    {

        static GraphicsManager graphics;
        static WorldManager world;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            Console.WriteLine("How many cows do you want?");
            string input = Console.ReadLine();
            try
            {
                int num = Convert.ToInt32(input);
                Console.WriteLine("If you hit enter again, you'll enter the environment.");
                Console.ReadLine();
                bool active = true;
                while (active)
                {
                    active = Game(num);
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
                
        }

        static bool Game(int n) {
            bool active = true;
            Load(n);
            graphics.Refresh();
            while (active)
            {
                string input = Console.ReadLine();
                //Inputting 'x' will close the window.
                active = (input == "x") ? false : true;
                if (!active) {
                    break;
                }
                //Else, it will go through this switch.
                switch (input) {
                    case "a":
                        //Gotta work on whatever the hell this is :/
                        graphics.Menu(input);
                        break;
                    default:
                        graphics.Refresh();
                        break;
                }
            }
            return false;
        }

        static void Load(int n)
        {
            world = new WorldManager(n);
            graphics = new GraphicsManager(world, world.CowList);
        }
    }
}
