using System.Collections.Generic;


namespace CSharp6
{
    public class IndexInitializers
    {
        #region Old
        Dictionary<int, string> Nums;

        public IndexInitializers()
        {
            Nums[7] = "seven";
            Nums[9] = "nine";
            Nums[13] = "thirteen";
        }
        #endregion

        #region
        Dictionary<int, string> Numbers = new Dictionary<int, string>
        {
            [7] = "seven",
            [9] = "nine",
            [13] = "thirteen"
        };
        #endregion

    }
}
