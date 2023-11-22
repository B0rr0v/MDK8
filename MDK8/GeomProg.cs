using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK8
{
    public class GeomProg : ISeries, IComparable
    {
        public double Start { get; set; }
        public double Step { get; set; }

        double current;// текущее значение

        public double Next
        {
            get { return GetNext(); }
        }

        public GeomProg(double startVal, double stepVal)
        {
            Start = startVal;
            Step = stepVal;
        }
        public void SetStart(double a)
        {
            Start = a;
            current = Start;
        }

        public double GetNext()
        {
            current *= Step;
            return current;

        }
        public void Reset()
        {
            current = Start;
        }
        public int CompareTo(GeomProg obj)
        {
            if (obj.Step < Step) return 1;
            if (obj.Step > Step) return -1;
            return 0;
          
        }
    }
}
