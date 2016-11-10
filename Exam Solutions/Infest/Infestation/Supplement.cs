using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public abstract class Supplement : ISupplement
    {
        public Supplement()
        {

        }

        public Supplement(int powerEffect, int healthEffect, int agressionEffect)
        {
            this.PowerEffect = powerEffect;
            this.HealthEffect = healthEffect;
            this.AggressionEffect = agressionEffect;
        }

        public virtual int AggressionEffect { get; protected set; }

        public virtual int HealthEffect { get; protected set; }

        public virtual int PowerEffect { get; protected set; }

        public void ReactTo(ISupplement otherSupplement)
        {
            
        }
    }
}
