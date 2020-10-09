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


        public Chromosome1(bool isMale, double constitution, double sightDistance) {
            this.isMale = isMale;
            this.constitution = constitution;
            this.sightDist = sightDistance;
        }

    }

    class Chromosome2
    {

    }
}
