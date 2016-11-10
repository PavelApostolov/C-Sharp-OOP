using Societies.Core.Infrastructure.Enumeration.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Societies.Core.Contracts
{
    public interface IConsumable
    {
        BeverageType Type { get; set; }

        decimal TotalPrice { get; set; }
    }
}
