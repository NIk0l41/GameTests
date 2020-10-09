using System;
using System.Collections.Generic;
using System.Text;

namespace Genetics
{
    class GraphicsManager
    {
        int bac1 = 1;
        int bac2 = 2;

        List<Bacteria> bacList = new List<Bacteria>();

        WorldManager world;

        public GraphicsManager(WorldManager world, List<Bacteria> bacList) {
            this.bacList = bacList;
            this.world = world;
        }

        int[,] grid = new int[4,4] {
            { 0, 0, 0, 0},
            { 0, 0, 0, 0},
            { 0, 0, 0, 0},
            { 0, 0, 0, 0}
        };

        public int[,] plane {
            get {
                return grid;
            }
        }

        public void Refresh()
        {
            Console.Clear();
            Process();
            Print();
        }

        /// <summary>
        /// Processes what needs to be displayed.
        /// </summary>
        void Process() {
            for (int i = 0; i < bacList.Count; i++) {
                if (bacList[i].Current != State.Dead)
                {
                    int j = bacList[i].transform.x;
                    int k = bacList[i].transform.y;
                    grid[i, j] = i + 1;
                }
            }
        }

        /// <summary>
        /// Prints the Information on the Console
        /// </summary>
        void Print() {
            Console.WriteLine("Frame: ");
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
        void PrintDetails(Bacteria a) {
            Console.WriteLine("");
            Console.WriteLine("Bacteria number: " + a.BacteriaID);
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
