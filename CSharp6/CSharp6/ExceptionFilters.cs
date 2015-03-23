using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    public class ExceptionFilters
    {
        public void DoStuff()
        {
            try
            {

            }
            catch (Exception ex) if (ex.Message.StartsWith("Error")) // will be when
            {

            }
            catch (Exception ex) if (ex.Message.StartsWith("Warning")) // will be when
            {

            }
        }
    }
}
