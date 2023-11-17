using ASP.Net.Models.Bill;
using ASP.Net.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net.ViewComponents
{
    public class ServiceViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke(string Field, Service Service) 
        {
            return View(new ServiceViewModel(Field,Service));
        }
    }
}
