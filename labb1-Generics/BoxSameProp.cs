using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb1_Generics
{
    internal class BoxSameProp:EqualityComparer<Box>
    {
        public override bool Equals(Box U1, Box U2)
        {
            if (U1.Height == U2.Height && U1.Length == U2.Length && U1.Width == U2.Width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode(Box b)
        {
            return b.GetHashCode();
        }
    }
}
