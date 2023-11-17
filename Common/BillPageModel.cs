using ASP.Net.DataAccess.Context;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.Net.Common
{
    public class BillPageModel : PageModel
    {

        protected BillContext Context { get; private set; }

        public BillPageModel(BillContext Context)
        {
            this.Context = Context;
        }
    }
}
