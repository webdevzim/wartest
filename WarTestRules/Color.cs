using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarTestRules
{
    enum Color
    {
        none,
        blue,
        green
    }

    static class ColorMethods
    {
        public static Color FlipColor (this Color color)
        {
            if (color == Color.blue) return Color.green;
            if (color == Color.green) return Color.blue;
            return color;
        }
    }
}
