using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb1_Generics
{
    internal class Box:IEquatable<Box>
    {
        public int Height { get; }
        public int Length { get; }
        public int Width { get; }

        public Box(int height, int length, int width)
        {
            this.Height = height;
            this.Length = length;
            this.Width = width;
        }

        public bool Equals(Box? other)
        {
            if (new BoxSameProp().Equals(this, other))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
