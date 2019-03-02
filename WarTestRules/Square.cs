using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarTestRules
{
    struct Square
    {
        public static Square none = new Square(-1, -1);
        public int x { get; private set; }
        public int y { get; private set; }

        public Square(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Square(string name) // e2, h8
        {
            if (name.Length == 2 &&
                name[0] >= 'a' && name[0] <= 'o' &&
                name[1] >= '1' && name[1] <= '9')
            {
                y = name[0] - 'a';
                x = name[1] - '1';
            }
            else
                this = none;
        }

        public string Name
        {
            get
            {
                return ((char)('a' + x)).ToString() +
                        (y + 1).ToString();
            }
        }

        public bool OnBoard ()
        {
            return (x >= 0 && x < 9) &&
                   (y >= 0 && y < 15);

        }
    }
}
