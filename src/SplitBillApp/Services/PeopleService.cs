using SplitBillApp.Models;

namespace SplitBillApp.Services
{
    public class PeopleService
    {
        public IEnumerable<Friend> GetFriends()
        {
            return new List<Friend>
            {
                new Friend { Id = 1, Image = "face01.png" },
                new Friend { Id = 2, Image = "face02.png" },
                new Friend { Id = 3, Image = "face03.png" },
                new Friend { Id = 4, Image =  "face04.png" },
                new Friend { Id = 5, Image = "face05.png" },
                new Friend { Id = 6, Image = "face06.png" }
            };
        }
    }
}
