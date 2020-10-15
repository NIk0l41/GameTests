using System;
using System.Collections.Generic;
using System.Text;

namespace Genetics
{
    class Brain
    {
        Chromosome1 chrom1;

        bool isMale;

        public Brain(Chromosome1 chrom1) {
            this.chrom1 = chrom1;
            isMale = chrom1.IsMale;
        }

        public void Update()
        {

        }
    }
}
