using System.ComponentModel.DataAnnotations.Schema;
namespace ASP.Net.Models.Bill
{
    public class Bill
    {
        public Service HotWaterAndHeating { get; private set; }
        public Service Electricity { get; private set; }
        public Service ColdWater { get; private set; }

        [ForeignKey("Service")]
        public int HotWaterAndHeatingId { get; set; }

        [ForeignKey("Service")]
        public int ElectricityId { get; set; }

        [ForeignKey("Service")]
        public int ColdWaterId { get; set; }

        public int Id { get; set; }
        public int Number { get; set; } = new Random().Next(100000, 300000);
        public double Overpayment { get; set; }
        public double TotalToPay => HotWaterAndHeating.ToPay + Electricity.ToPay + ColdWater.ToPay - Overpayment;
        public DateTime CreationDate {  get; set; } = DateTime.Today;

        public Bill()
        {
            HotWaterAndHeating = new Service("Горячая вода и теплоснабжение");
            Electricity = new Service("Электроснабжение");
            ColdWater = new Service("Холодная вода");
        }
    }
}
