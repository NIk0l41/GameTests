using System;
using System.Collections.Generic;
using System.Text;

namespace Genetics
{
    class GraphicsManager
    {
        List<Cow> cowList = new List<Cow>();

        WorldManager world;

        public GraphicsManager(WorldManager world, List<Cow> cowList) {
            this.cowList = cowList;
            this.world = world;
        }

        int[,] grid = new int[4,4] {
            { 0, 0, 0, 0},
            { 0, 0, 0, 0},
            { 0, 0, 0, 0},
            { 0, 0, 0, 0}
        };

        public int[,] plane {get { return grid; }}

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
                    grid[i, j] = 0;
                }
            }

            //Refresh Cow Location if Alive
            for (int i = 0; i < cowList.Count; i++) {
                if (cowList[i].Current != State.Dead)
                {
                    int j = cowList[i].transform.x;
                    int k = cowList[i].transform.y;
                    grid[i, j] = i + 1;
                }
            }
        }

        /// <summary>
        /// Prints the Information on the Console
        /// </summary>
        void Print() {
            Console.WriteLine("Frame: " + world.CurrentPhase);
            Console.WriteLine(grid[0, 0].ToString() + grid[0, 1].ToString() + grid[0, 2].ToString()+ grid[0, 3].ToString());
            Console.WriteLine(grid[1, 0].ToString() + grid[1, 1].ToString() + grid[1, 2].ToString() + grid[1, 3].ToString());
            Console.WriteLine(grid[2, 0].ToString() + grid[2, 1].ToString() + grid[2, 2].ToString() + grid[2, 3].ToString());
            Console.WriteLine(grid[3, 0].ToString() + grid[3, 1].ToString() + grid[3, 2].ToString() + grid[3, 3].ToString());
            Console.WriteLine("");
            Console.WriteLine("1) View Bacteria Data");
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
