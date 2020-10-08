using System;
using System.Collections.Generic;
using System.Text;

namespace Genetics
{
    struct Transform
    {
        int x;
        int y;

        public Transform(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public Transform Origin() {
            Random rnd = new Random();
            int x1 = rnd.Next(0,3);
            int y1 = rnd.Next(0,3);
            return new Transform(x1,y1);
        }

        public static bool operator == (Transform a, Transform b) {
            return a.x == b.x && a.y == b.y;
        }

        public static bool operator != (Transform a, Transform b) {
            return a.x != b.x || a.y != b.y;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public Transform Left() {
            return new Transform(-1,0);
        }

        public Transform Right() {
            return new Transform(1,0);
        }

        public Transform Up() {
            return new Transform(0,1);
        }

        public Transform Down() {
            return new Transform(0,-1);
        }
    }
}
