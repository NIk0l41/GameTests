using System;
using System.Collections.Generic;
using System.Text;

namespace Genetics
{
    class WorldManager
    {
        public int CurrentPhase { get { return phases; } }
        int phases;

        List<Bacteria> bacList = new List<Bacteria>();
        public List<Bacteria> BacteriaList { get { return bacList; } }


        /// <summary>
        /// Used for Initialisation
        /// </summary>
        /// <param name="NumberOfBacteria"></param>
        public WorldManager(int NumberOfBacteria) {
            Start(2);
        }

        /// <summary>
        /// To Be Called on Startup
        /// </summary>
        /// <param name="NumberOfBacteria"></param>
        public void Start(int NumberOfBacteria) {
            phases = 0;
            for (int i = 0; i<NumberOfBacteria; i++) {
                bacList.Add(new Bacteria(i));
            }
        }

        /// <summary>
        /// Moves the Environment forward in time.
        /// </summary>
        public void Next() {
            phases += 1;
            foreach (Bacteria b in bacList) {

            }
        }
    }
}
