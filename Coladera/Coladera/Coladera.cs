using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coladera
{
    class Coladera
    {
        protected static int _num;
        protected bool[] _cousins= new bool[1000];

        public Coladera(int num)
        {
            _num = num;
        }

        public void llenado()
        {
            for(int i = 0; i < _num; i++)
            {
                _cousins[i] = true;
            }
        }

        public void colado()
        {
            for(int j = 2; j < _num; j++)
            {
                for(int i = 2; i * j < _num; i++)
                {
                    _cousins[i * j] = false;
                }
            }
        }

        public override string ToString()
        {
            string s="";
            for(int i=2;i<_num;i++)
            {
                if (_cousins[i])
                {
                    s += i.ToString() + ", ";
                }
            }
            return s;
        }
    }
}
