using ASP.Net.Common;
using ASP.Net.DataAccess.Context;
using ASP.Net.Models.Bill;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net.Pages
{
    public class AddBillModel : BillPageModel
    {

        [BindProperty]
        public Bill BillData { get; set; }

        public AddBillModel(BillContext context) : base(context) { }

        public void OnGet()
        {
            BillData = new Bill();
        }

        public void OnPost()
        {
            try
            {
                Context.Bills.Add(BillData);
                Context.SaveChanges();
                TempData["Status"] = $"���� #{BillData.Number} ��������";
            }
            catch (Exception ex)
            {
                TempData["Status"] = $"�� ������� ��������� ����: {ex.Message}";
            }
        }
    }
}
