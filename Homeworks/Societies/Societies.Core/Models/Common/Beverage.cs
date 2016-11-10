
using Societies.Core.Contracts;
using Societies.Core.Models.Common.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Societies.Core.Models.Common
{
    public class Beverage : Consumable, IBeverage
    {
        public int PortionSizeInMililiters { get; set; }

        public int SizeOfPortionInGrams { get; set; }
    }
}
