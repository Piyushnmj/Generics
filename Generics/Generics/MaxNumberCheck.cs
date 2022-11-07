using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MaxNumberCheck
    {
        public static int MaxIntegerNumber(int val1, int val2, int val3)
        {
            if (val1.CompareTo(val2) > 0 && val1.CompareTo(val3) > 0)
                return val1;
            if (val2.CompareTo(val1) > 0 && val2.CompareTo(val3) > 0)
                return val2;
            if (val3.CompareTo(val1) > 0 && val3.CompareTo(val2) > 0)
                return val3;
            return val1;
        }

        public static double MaxFloatNumber(double val1, double val2, double val3)
        {
            if (val1.CompareTo(val2) > 0 && val1.CompareTo(val3) > 0)
                return val1;
            if (val2.CompareTo(val1) > 0 && val2.CompareTo(val3) > 0)
                return val2;
            if (val3.CompareTo(val1) > 0 && val3.CompareTo(val2) > 0)
                return val3;
            return val1;
        }

        public static string MaxStringNumber(string String1, string String2, string String3)
        {
            if (String1.CompareTo(String2) > 0 && String1.CompareTo(String3) > 0)
                return String1;
            if (String2.CompareTo(String1) > 0 && String2.CompareTo(String3) > 0)
                return String2;
            if (String3.CompareTo(String1) > 0 && String3.CompareTo(String2) > 0)
                return String3;
            return String1;
        }
    }
}
