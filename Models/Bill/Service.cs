namespace ASP.Net.Models.Bill
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double ToPay { get; set; }

        public Service(string Name, double ToPay)
        {
            this.Name = Name;
            this.ToPay = ToPay;
        }

        public Service(string Name)
        {
            this.Name = Name;
            this.ToPay = 0.0;
        }
    }
}
