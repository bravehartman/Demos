using CSharp6.Helpers;
using System;
using System.ComponentModel;

namespace CSharp6
{
    public class NameOf : INotifyPropertyChanged
    {
        #region Old
        public void CalculateInterest(Loan loan)
        {
            if (loan == null) throw new ArgumentNullException("loan");
        }
        #endregion


        #region New
        public void CalculatePayoff(Loan loan)
        {
            if (loan == null) throw new ArgumentNullException(nameof(loan));
        }
        #endregion

        #region INPC
        private string customerNameValue;

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string CustomerName
        {
            get
            {
                return customerNameValue;
            }

            set
            {
                if (value != customerNameValue)
                {
                    customerNameValue = value;
                    NotifyPropertyChanged(nameof(CustomerName));
                }
            }
        }
        #endregion
    }

}
