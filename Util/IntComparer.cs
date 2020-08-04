using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StateEditor.Util
{
    class IntComparer : IComparer<int>
    {
        public bool Invert;

        public IntComparer() {
            Invert = false;
        }

        public int Compare(int x, int y) {
            return x.CompareTo(y);
        }
    }
}
