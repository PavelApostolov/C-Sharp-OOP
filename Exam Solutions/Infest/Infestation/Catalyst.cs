﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public abstract class Catalyst : Supplement
    {
        public Catalyst(int powerEffect, int healthEffect, int agressionEffect)
            : base(powerEffect, healthEffect, agressionEffect)
        {

        }
    }
}
