using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class Car
    {
        int a;
        public int _newA { get; set; }
        public int _newB { get; set; }
        public Car(int a,int b)
        {
            _newA = a;
            _newB = b;

        }
        public string stering { get; set; }
        public int Wheel { get; set; }

        public Int32 headlight { get;  set; }
    }
}
