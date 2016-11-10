using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Societies.Core.Contracts
{
    public interface IWaiter
    {
        decimal Bakshishes { get; set; }

        void GetOrder(IRestaurantOrder order, IHuman client);

        void ServeOrder(IHuman client);

        void RequestPayment(IHuman client);
    }
}
