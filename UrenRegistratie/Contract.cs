using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrenRegistratie
{
    public static class Contract
    {
        public static DateTime Begin { get { return new DateTime(2015, 8, 2); } }
        public static DateTime End { get { return new DateTime(2016, 2, 2); } }
        public static int Uren { get { return 16;} }
    }
}
