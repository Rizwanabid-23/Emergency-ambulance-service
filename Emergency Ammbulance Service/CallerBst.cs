using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Emergency_Ammbulance_Service
{
    class CallerBst
    {
        public Caller root;
        private CallerBst()
        {
            this.root = null;
        }

        private static CallerBst instance = null;

        public static CallerBst bstInstance()
        {
            if (instance == null)
            {
                instance = new CallerBst();
            }
            return instance;
        }


        public void Insert_Caller(Caller z) // Function to insert new Caller in Tree
        {
       
            Caller y = null;
            Caller x = this.root;
            while (x != null)
            {
                y = x;
                if (int.Parse(z.number) < int.Parse(x.number))
                {
                    x = x.left;
                }
                else
                {
                    x = x.right;
                }
            }
            z.parent = y;
            if (y == null)
            {
                this.root = z;
            }
            else if (int.Parse(z.number) < int.Parse(y.number))
            {
                y.left = z;
            }
            else
            {
                y.right = z;
            }
        }

        public void transplant(CallerBst t, Caller u, Caller v)
        {
            if (u.parent == null)
            {
                t.root = v;
            }
            else if (u == u.parent.left)
            {
                u.parent.left = v;
            }
            else
            {
                u.parent.right = v;
            }
            if (v != null)
            {
                v.parent = u.parent;
            }
        }

        public Caller minimumT(Caller x)
        {
            while (x.left != null)
            {
                x = x.left;
            }
            return x;
        }


        public Caller search(string searchCaller)
        {
            Caller x = this.root;
            while (x != null && int.Parse(searchCaller) != int.Parse(x.number))
            {
                if (int.Parse(searchCaller) < int.Parse(x.number))
                {
                    x = x.left;
                }
                else
                {
                    x = x.right;
                }
            }
            if (x == null)
            {
                return null;
            }
            return x;

        }
    }
}
