using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    class AwaitFinally
    {
        public class Resource
        {
            internal static Task<Resource> OpenAsync()
            {
                throw new NotImplementedException();
            }

            internal static Task LogAsync(Resource res, Exception e)
            {
                throw new NotImplementedException();
            }

            internal Task CloseAsync()
            {
                throw new NotImplementedException();
            }
        }

        public async void DoStuff()
        {
            Resource res = null;
            try
            {
                res = await Resource.OpenAsync(); // You could always do this. 
            }
            catch (Exception e)
            {
                await Resource.LogAsync(res, e); // Now you can do this … 
            }
            finally
            {
                if (res != null) await res.CloseAsync(); // … and this. 
            }
        }
    }
}
