using System;
using System.Collections.Generic;
using System.Text;

namespace Genetics
{
    class GraphicsManager
    {
        List<Cow> cowList = new List<Cow>();

        WorldManager world;

        IDictionary<objects, string> dic = new Dictionary<objects, string>();

        public GraphicsManager(WorldManager world, List<Cow> cowList) {
            this.cowList = cowList;
            this.world = world;
            SetDictionary();
        }

        void SetDictionary() {
            dic.Add(objects.None, ".");
            dic.Add(objects.Food, "F");
            dic.Add(objects.Wall, "B");
            dic.Add(objects.Water, "W");
        }

        string[,] grid = new string[4,4] {
            {"","","","" },
            {"","","","" },
            {"","","","" },
            {"","","","" }
        };

        public string[,] plane {get { return grid; }}

        public void Refresh()
        {
            Console.Clear();
            Process();
            Print();
        }

        /// <summary>
        /// Processes any changes to the Grid
        /// </summary>
        void Process() {
            //Clears the Grid for Refreshment
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 4; j++) {
                    grid[i, j] = dic[objects.None];
                }
            }

            //Refresh Cow Location if Alive
            for (int i = 0; i < cowList.Count; i++) {
                if (cowList[i].Current != State.Dead)
                {
                    int j = cowList[i].transform.x;
                    int k = cowList[i].transform.y;
                    grid[i, j] = i.ToString();
                }
            }
        }

        public void Menu(string input)
        {
            switch (input)
            {

            }
        }

        /// <summary>
        /// Prints the Information on the Console
        /// </summary>
        void Print() {
            Console.WriteLine("Frame: " + world.CurrentPhase);
            Console.WriteLine(grid[0, 0] + grid[0, 1] + grid[0, 2]+ grid[0, 3]);
            Console.WriteLine(grid[1, 0] + grid[1, 1] + grid[1, 2] + grid[1, 3]);
            Console.WriteLine(grid[2, 0] + grid[2, 1] + grid[2, 2] + grid[2, 3]);
            Console.WriteLine(grid[3, 0] + grid[3, 1] + grid[3, 2] + grid[3, 3]);
            Console.WriteLine("");
            Console.WriteLine("1) View Cow Data");
            Console.WriteLine("2) Next");
        }

        /// <summary>
        /// Prints Details for a Selected Organism.
        /// </summary>
        void PrintDetails(Cow a) {
            Console.WriteLine("");
            Console.WriteLine("Cow number: " + a.CowID);
            Console.WriteLine("-Chromosome 1 Data-");
            string tmp = (a.chrom1.IsMale) ? "Male" : "Female" ;
            Console.WriteLine("   Gender: " + tmp);
            tmp = a.chrom1.Constitution.ToString();
            Console.WriteLine("   Constitution: " + tmp);
            tmp = a.chrom1.SightDistance.ToString();
            Console.WriteLine("   Sight Distance: " + tmp);
            Console.ReadLine();
        }
    }
}
