using ASP.Net.Models.Bill;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net.ViewComponents
{
    public class BillServiceViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke(Service service) => View(service);
    }
}
