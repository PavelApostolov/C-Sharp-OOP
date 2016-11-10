using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class EffextableSupplement : Supplement
    {
        protected bool hasEffect = false;

        public EffextableSupplement(int powerEffect, int healthEffect, int agressionEffect)
            : base (powerEffect, healthEffect, agressionEffect)
        {

        }

        public override int AggressionEffect
        {
            get
            {
                if (!this.hasEffect)
                {
                    return 0;
                }
                else
                {
                    return base.AggressionEffect;
                }
            }

            protected set
            {
                base.AggressionEffect = value;
            }
        }

        public override int HealthEffect
        {
            get
            {
                if (!this.hasEffect)
                {
                    return 0;
                }
                else
                {
                    return base.HealthEffect;
                }
            }

            protected set
            {
                base.HealthEffect = value;
            }
        }

        public override int PowerEffect
        {
            get
            {
                if (!this.hasEffect)
                {
                    return 0;
                }
                else
                {
                    return base.HealthEffect;
                }
            }

            protected set
            {
                base.PowerEffect = value;
            }
        }
    }
}
