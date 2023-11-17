using ASP.Net.Models.Bill;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net.ViewComponents
{
    public class BillViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Bill bill) => View(bill);
    }
}
