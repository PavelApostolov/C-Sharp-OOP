
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Societies.Core.Contracts;
using Societies.Core.Infrastructure.Enumeration.Common;
using Societies.Core.Infrastructure.Exceptions;

namespace Societies.Core.Models.Common.Abstract
{
    public abstract class Consumable : IConsumable
    {
        private decimal totalPrice;

        public decimal TotalPrice
        {
            get
            {
                return this.totalPrice;
            }
            set
            {
                if(value < 0)
                {
                    throw new PriceOutOfRangeException("Price was not in the desired range[0:infinity]", value);
                }
                else if(value > decimal.MaxValue)
                {
                    throw new PriceOutOfRangeException("Price was not in the desired range[0:infinity]", value);
                }

                this.totalPrice = value;
            }
        }

        public BeverageType Type { get; set; }
    }
}
