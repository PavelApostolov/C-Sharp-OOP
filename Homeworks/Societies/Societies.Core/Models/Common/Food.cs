using Societies.Core.Contracts;
using Societies.Core.Infrastructure.Enumeration.Common;
using Societies.Core.Models.Common.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Societies.Core.Models.Common
{
    public class Food : Consumable, IFood
    {
        public int PortionSizeInGrams { get; set; }              
    }
}
