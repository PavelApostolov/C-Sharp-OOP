using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Societies.Core.Infrastructure.Constants
{
    public class ValidationConstants
    {
        public const int MinSizeOfPortionInGramsValue = 0;
        public const int MaxSizeOfPortionInGramsValue = 5000;

        public const int VitalityLevelMaxValue = 100;
        public const int VitalityLevelMinValue = 0;

        public const int StarvationLevelMaxValue = 100;
        public const int StarvationLevelMinValue = 0;

        public const int ThirstLevelMaxValue = 100;
        public const int ThirstLevelMinValue = 0;

        public const decimal MoneyInEuroMaxValue = 999999;
        public const decimal MoneyInEuroMinValue = 0;

    }
}
