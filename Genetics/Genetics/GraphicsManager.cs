using System;
using System.Collections.Generic;
using System.Text;

namespace Genetics
{
    class GraphicsManager
    {
        char empty = "o"[0];
        char bac1 = "1"[0];
        char bac2 = "2"[0];

        Bacteria b1;
        Bacteria b2;

        public void Refresh(List<Bacteria> b) {
            b1 = b[0];
            b2 = b[1];
            line0();
        }

        public void line0() {
            Console.Write("");
        }
    }
}
