using ASP.Net.DataAccess.Context;
using ASP.Net.Models.Bill;
using Microsoft.EntityFrameworkCore;
using ASP.Net.Common;
using ASP.Net.DataAccess.Extensions;
using ASP.Net.DataAccess.Specifications;

namespace ASP.Net.Pages
{
    public class ViewYearlyModel : BillPageModel
    {        
        public List<Bill> Bills { get; protected set; }

        public ViewYearlyModel(BillContext Context) :base(Context) { }

        public void OnGet()
        {
            Bills = Context.Bills
                .Include(bill => bill.Electricity)
                .Include(bill => bill.HotWaterAndHeating)
                .Include(bill => bill.ColdWater)
                .AsQueryable()
                .Specify<Bill>(new CurrentYearBillSpec()).ToList();
        }
    }
}
