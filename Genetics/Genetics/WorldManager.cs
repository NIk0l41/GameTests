using System;
using System.Collections.Generic;
using System.Text;

namespace Genetics
{
    class WorldManager
    {
        public int CurrentPhase { get { return phases; } }
        int phases;

        List<Cow> cowList = new List<Cow>();
        public List<Cow> CowList { get { return cowList; } }

        string[,] world = new string[4,4]{
            {"","","","" },
            {"","","","" },
            {"","","","" },
            {"","","","" }
        };

        objects[,] worldObj = new objects[4, 4] {
            {objects.None, objects.Wall, objects.Wall, objects.None},
            {objects.None, objects.None, objects.None, objects.None},
            {objects.None, objects.Wall, objects.Wall, objects.None},
            {objects.None, objects.None, objects.None, objects.None}
        };

        /// <summary>
        /// Used for Initialisation
        /// </summary>
        /// <param name="NumberOfCows"></param>
        public WorldManager(int NumberOfCows) {
            Start(NumberOfCows);
        }

        /// <summary>
        /// To Be Called on Startup
        /// </summary>
        /// <param name="NumberOfBacteria"></param>
        public void Start(int NumberOfCows) {
            phases = 0;
            for (int i = 0; i<NumberOfCows; i++) {
                cowList.Add(new Cow(i));
            }
        }

        /// <summary>
        /// Moves the Environment forward in time.
        /// </summary>
        public void Next() {
            phases += 1;
            foreach (Cow c in cowList) {

            }
        }
    }
}
