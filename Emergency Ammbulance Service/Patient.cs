using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Ammbulance_Service
{
    internal class Patient : Person
    {
        public long EC  { get; private set;}
        public string hospital { get; private set;}


        public Patient(string name, int phone, int CNIC, string address, string hospital,long ec): base(name, phone, CNIC, address)
        {
            this.hospital = hospital;
            this.EC = Hash(name);
        }
        private long Hash(String str)
        {
            int p = 31;
            int m = (int)(1e9 + 9);
            long pp = 1;
            long value = 0;
            for (int i = 0; i < str.Length; i++)
            {
                value = (value + (str[i] - 'a' + 1) * pp) % m;
                pp = (pp * p) % m;
            }
            return value;
        }
    }
}
