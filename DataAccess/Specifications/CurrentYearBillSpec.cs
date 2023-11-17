using ASP.Net.BasicClasses;
using ASP.Net.Models.Bill;

namespace ASP.Net.DataAccess.Specifications
{
    public class CurrentYearBillSpec : BaseSpecification<Bill>
    {
        public CurrentYearBillSpec()
        {
            Criteria = b => b.CreationDate.Year == DateTime.Today.Year;
            Includes.Add(b => b);
        }
    }
}
