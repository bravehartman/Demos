
namespace CSharp6
{
    public class AutoPropertyInitializers
    {
        #region Old
        public string FirstName { get; set; }
        public string LastName { get; private set; }

        public AutoPropertyInitializers()
        {
            FirstName = "John";
            LastName = "Doe";
        }
        #endregion

        #region New
        public string First { get; set; } = "Jane";
        public string Last { get; private set; } = "Doe";
        public string Middle { get; } = "M"; // = readonly, can be set in constructor
        
        public void ChangeName(string first, string last, string middle)
        {
            First = first;
            Last = last;
            //Middle = middle; //Error
        }

        #endregion

        
    }
}
