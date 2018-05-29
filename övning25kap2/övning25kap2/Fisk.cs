using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiskTest
{
    class Fisk
    {
        public string sort;
        public double vikt, längd;

        public int pris()
        {
            return (int)Math.Round(vikt * 7.25 / 100);
        }

        public int frakt()
        {
            return (int)Math.Round(vikt * 0.02 + längd * 0.01);
        }
    }
}
