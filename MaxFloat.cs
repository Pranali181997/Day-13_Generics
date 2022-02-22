using System;
using System.Collections.Generic;
using System.Text;

namespace Day13_Generics
{
    class MaxFloat
    {
        public static double FindMaxValue1(double Firstvalue, double Secondvalue, double Thirdvalue)
        {
            if (Firstvalue.CompareTo(Secondvalue) > 0 && Firstvalue.CompareTo(Thirdvalue) > 0)
            {
                return Firstvalue;
            }
            else if (Secondvalue.CompareTo(Thirdvalue) > 0 && Secondvalue.CompareTo(Thirdvalue) > 0)
            {
                return Secondvalue;
            }
            else
            {
                return Thirdvalue;
            }

        }
    }
}
