using CSharp6.Helpers;

namespace CSharp6
{
    public class NullConditionalOperator
    {
        #region Old
        public string DisplayDebtor1Address1(Loan loan)
        {
            if (loan != null && loan.Debtor1 != null && loan.Debtor1.Address != null)
            {
                return loan.Debtor1.Address.Street1;
            }
            return null;
        }
        #endregion


        #region New
        public string DisplayDebtor2Address1(Loan loan)
        {
            return loan?.Debtor2?.Address?.Street1;
        }
        #endregion
    }
}
