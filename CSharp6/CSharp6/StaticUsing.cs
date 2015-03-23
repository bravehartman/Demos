using CSharp6.Helpers;
using System;
//using static System.Math;
//using static System.String;
//using static CSharp6.Helpers.Types;

namespace CSharp6
{
    public class StaticUsing
    {
        #region Old
        public int DoMath(int num)
        {
            return Math.Abs(num);
        }

        public bool IsNull(string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        public bool IsAuto(Types type)
        {
            return type == Types.Auto;
        }
        #endregion


        public int MathFuncs(int num)
        {
            return Abs(num);
        }

        public bool StringFuncs(string str)
        {
            return IsNullOrWhiteSpace(str);
        }

        public bool IsAuto(Types type)
        {
            return type == Auto;
        }
    }
}
