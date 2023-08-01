using SplitBillApp.Models;

namespace SplitBillApp.Services
{
    public class RecentPaymentsService
    {
        public IEnumerable<Payment> GetRecentPayments()
        {
            return new List<Payment>
            {
                new Payment { Icon = "burguer.png", Description = "Festive Celebration", Date = "22 Dec' 22", Persons = 4, Price = 100 },
                new Payment { Icon = "mountain.png", Description = "Adventure Trip", Date = "12 Nov' 22", Persons = 2, Price = 1200 },
                new Payment { Icon = "tourguide.png", Description = "Group Tour to Italy", Date = "9 Sep' 22", Persons = 12, Price = 6000 },
                new Payment { Icon = "cocktail.png", Description = "Cocktail Party", Date = "22 May' 22", Persons = 6, Price = 700 },
            };
        }
    }
}