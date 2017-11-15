using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_BKIT
{
   abstract class Figure : IComparable
    {
        public string Type
        {
            get
            {
                return this._Type;
            }
            protected set
            {
                this._Type = value;
            }
        }
        string _Type;

        public abstract double AreaCalc();

        public override string ToString()
        {
            return this.Type + " площадью " + this.AreaCalc().ToString();
        }

        public int CompareTo(object obj)
        {
            Figure p = (Figure)obj;

            if (this.AreaCalc() < p.AreaCalc()) return -1;
            else if (this.AreaCalc() == p.AreaCalc()) return 0;
            else return 1;
        }
    }
}