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
        Caller caller;
        internal long element;

        internal int color;
        
        public RedBlackNode(long element) : this(element, null, null, null)
        {
        }
        public RedBlackNode(long element,Caller caller, RedBlackNode lt, RedBlackNode rt)
        {
            left = lt;
            right = rt;
            this.caller = caller;
            this.element =  element;
            color = 1;
        }
    }
}
