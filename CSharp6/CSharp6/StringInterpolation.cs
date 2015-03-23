using System;

namespace CSharp6
{
    public class StringInterpolation
    {
        #region Old
        public string GetFilename(string prefix, string account)
        {
            var date = DateTime.Today.ToString("yyyyMMdd");
            return string.Format("{0}_{1}_{2}.txt", prefix, account, date);
        }
        #endregion

        #region New
        public string CreateFilename(string prefix, string account)
        {
            var date = DateTime.Today.ToString("yyyyMMdd");
            return $"{prefix}_{account}_{date}.txt";
        }
        #endregion
    }
}
