using System;
using System.Collections.Generic;
using System.Text;

namespace Day13_Generics
{
    class MaxInt
    {
        //    public static T findMaxValue(T Firstvalue,T Secondvalue,T Thirdvalue) 
        //    {
        //        if (Comparer<T>.Default.Compare(Firstvalue, Secondvalue) > 0 && Comparer<T>.Default.Compare(Secondvalue, Thirdvalue))
        //        {
        //            return Firstvalue;
        //        }
        //        else if (Comparer<T>.Default.Compare(Firstvalue, Thirdvalue) >0  && Comparer<T>.Default.Compare(Secondvalue, Thirdvalue))
        //        {
        //            return Secondvalue;
        //        }
        //    else
        //        {
        //            return Thirdvalue;
        //        }

        //    }
        //}
        public static int FindMaxValue(int Firstvalue, int Secondvalue, int Thirdvalue)
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

