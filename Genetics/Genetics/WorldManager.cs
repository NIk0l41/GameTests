using System;
using System.Collections.Generic;
using System.Text;

namespace Genetics
{
    class WorldManager
    {
        public int Phases { get { return phases; } }
        int phases;

        List<Bacteria> bacList = new List<Bacteria>();
        public List<Bacteria> BacteriaList { get { return bacList; } }

        public void Start() {
            phases = 0;
        }

        /// <summary>
        /// Moves the Environment forward in time.
        /// </summary>
        public void Next() {
            phases += 1;
        }
    }
}
