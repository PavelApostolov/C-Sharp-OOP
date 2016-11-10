using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Societies.Core.Contracts
{
    public interface IBeverage : IConsumable
    {
        int PortionSizeInMililiters { get; set; }
    }
}
