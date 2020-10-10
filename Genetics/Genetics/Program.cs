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
            Console.WriteLine("How many bacteria do you want?");
            string input = Console.ReadLine();
            bool a;
            try
            {
                int num = Convert.ToInt32(input);
                a = true;
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                a = false;  
            }
            if (a)
            {
                Console.WriteLine("If you hit enter again, you'll enter the environment.");
                Console.ReadLine();
                bool active = true;
                while (active)
                {
                    active = Game();
                }
            }
        }

        static bool Game() {
            bool active = true;
            Load();
            graphics.Refresh();
            while (active)
            {
                string input = Console.ReadLine();
                active = (input == "x") ? false : true;
                if (!active) {
                    break;
                }
                switch (input) {
                    case "a":
                        graphics.Refresh();
                        break;
                    default:
                        break;
                }
            }
            return false;
        }

        static void Load()
        {
            world = new WorldManager();
            graphics = new GraphicsManager(world, world.BacteriaList);
        }
    }
}
