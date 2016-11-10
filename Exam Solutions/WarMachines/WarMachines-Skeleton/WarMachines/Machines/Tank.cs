using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Tank : Machines, ITank, IMachine
    {
        private const int initialHealthPoints = 100;
        private const int attackPointsChange = 40;
        private const int defensePointsChange = 30;

        public Tank(string name, double attackPoints, double defensePoints)
            : base (name, attackPoints, defensePoints, initialHealthPoints)
        {
            this.DefenseMode = true;
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            this.DefenseMode = !this.DefenseMode;
            if (this.DefenseMode)
            {
                this.AttackPoints -= 40;
                this.DefensePoints += 30;
            }
            else
            {
                this.AttackPoints += 40;
                this.DefensePoints -= 30;
            }
        }

        public override string ToString()
        {
            var baseString = base.ToString();
            var result = new StringBuilder();
            result.Append(baseString);
            result.Append(string.Format(" *Defense: {0}", this.DefenseMode ? "ON" : "OFF"));

            return result.ToString();
        }
    }
}
