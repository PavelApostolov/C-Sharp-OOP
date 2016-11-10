using Societies.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Societies.Core.Models.Common
{
    public class RestaurantOrder : IRestaurantOrder
    {
        public ICollection<IBeverage> Beverage { get; set; }

        public ICollection<IFood> Foods { get; set; }

        public decimal TotalOrderPrice { get; set; }
    }
}
