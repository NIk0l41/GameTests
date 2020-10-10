using System;
using System.Collections.Generic;
using System.Text;

namespace Genetics
{
    class Chromosome1
    {

        bool isMale;
        double constitution;
        double sightDist;

        public bool IsMale { get { return isMale; } }
        public double Constitution { get{ return constitution; } }
        public double SightDistance { get { return sightDist; } }

        public Chromosome1() {
            InitRandom();
        }

        void InitRandom()
        {
            Random rnd = new Random();
            isMale = (rnd.Next(0,1) == 0) ? true : false;
            constitution = rnd.Next(0,10);
            sightDist = rnd.Next(1,5);
        }

    }

    class Chromosome2
    {

    }
}
