using OnlineApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp.NewFolder
{
   public class ElectronicServices
    {
        private readonly static IEnumerable<Electronics> _electronics = new
          List<Electronics>()
        {
            new Electronics
            {
                Name = "Mobiles",
                Image = "phones.jpg",
                Price = 5.1
            },
            new Electronics
            {
                Name = "Televisions",
                Image = "tv.jpg",
                Price = 2.5
            },
            new Electronics
            {
                Name = "Watches",
                Image = "watches.jpg",
                Price = 9.5
            },
            new Electronics
            {
                Name = "Laptops",
                Image = "laptop.jpg",
                Price = 1.45
            }
        };
        public IEnumerable<Electronics> GetallPizzas() => _electronics;
        public IEnumerable<Electronics> GetPopularPizzas(int count = 6) => _electronics.OrderBy(p => Guid.NewGuid())
            .Take(count);

        public IEnumerable<Electronics> SearchPizzas(string searchTerm) =>
            string.IsNullOrWhiteSpace(searchTerm)
            ? _electronics
            : _electronics.Where(p => p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));




    }
}
    

