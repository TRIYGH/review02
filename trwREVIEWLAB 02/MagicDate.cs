using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trwREVIEWLAB_02
{
    class MagicDate
    {
        private int mon, dy, yr;
        private bool isMagic = false;

        public int Month
        {
            set
            {
                mon = value;
            }

            get
            {
                return mon;
            }
        }

        public int Day
        {
            set
            {
                dy = value;
            }

            get
            {
                return dy;
            }
        }

        public int Year
        {
            set
            {
                yr = value;
            }

            get
            {
                return yr;
            }
        }

        public bool DetermineIfMagic()
        {
            if (dy*mon == yr)
                isMagic = true;
            return isMagic;
        }
    }
}
