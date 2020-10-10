using System;
using System.Collections.Generic;
using System.Text;

namespace Genetics
{
    class Bacteria
    {
        public Transform transform;
        public Chromosome1 chrom1;

        int bacID;
        bool dead;
        State current;

        public int BacteriaID { get { return bacID; } }
        public State Current { get { return current; } }

        public Bacteria(int ID) {
            bacID = ID;
            current = State.Alive;
            dead = false;
            Start();
        }

        public void Start()
        {
            chrom1 = new Chromosome1();
            transform = transform.Random();
        }

        public void Die() {
            current = State.Dead;
            dead = true;
        }

    }
}
