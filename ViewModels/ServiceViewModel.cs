using ASP.Net.Models.Bill;

namespace ASP.Net.ViewModels
{
    public class ServiceViewModel
    {
        private readonly string _field = string.Empty;

        public Service Service { get; set; }

        public string PaymentField => $"{_field}.ToPay";

        public ServiceViewModel(string Field, Service Service)
        {
            _field = Field;
            this.Service = Service;
        }

    }
}
