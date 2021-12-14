using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Ammbulance_Service
{
    internal class RedBlackNode
    {
        internal RedBlackNode left, right;
        internal int element;
        internal int color;

        public RedBlackNode(int theElement) : this(theElement, null, null)
        {
        }
        public RedBlackNode(int theElement, RedBlackNode lt, RedBlackNode rt)
        {
            left = lt;
            right = rt;
            element = theElement;
            color = 1;
        }
    }
}
