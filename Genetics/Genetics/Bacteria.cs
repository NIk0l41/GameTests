using System;
using System.Collections.Generic;
using System.Text;

namespace Genetics
{
    class Cow
    {
        public Transform transform;
        public Chromosome1 chrom1;
        public Brain brain;

        int cowID;
        bool dead;
        State current;
        int sight;

        public int CowID { get { return cowID; } }
        public State Current { get { return current; } }



        public Cow(int ID) {
            cowID = ID;
            current = State.Alive;
            dead = false;
            Start();
        }

        public void Start()
        {
            chrom1 = new Chromosome1();
            transform = transform.Random();
            brain = new Brain(chrom1);
        }

        public void Update() {
            brain.Update();
        }

        public void Die() {
            current = State.Dead;
            dead = true;
        }

    }
}