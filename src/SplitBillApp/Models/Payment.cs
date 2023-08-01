namespace SplitBillApp.Models
{
    public class Payment
    {
        public string Icon { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Date { get; set; }
        public int Persons { get; set; }
    }
}
