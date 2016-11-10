using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Societies.Core.Contracts
{
    public interface IRestaurantOrder
    {
        ICollection<IFood> Foods { get; set; }
        ICollection<IBeverage> Beverage { get; set; }

        decimal TotalOrderPrice { get; set; }
    }
}
