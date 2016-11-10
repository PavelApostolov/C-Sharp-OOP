﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public abstract class Machines : IMachine
    {
        private string name;
        private IPilot pilot;
        private IList<string> targets;

        protected Machines(string name, double attackPoints, double defensePoints, double healthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;
            this.targets = new List<string>();
        }

        public double AttackPoints { get; protected set; }
        public double DefensePoints { get; protected set; }

        public double HealthPoints { get; set; }
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Whatever");
                }
                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }

            set
            {
                if (pilot == null)
                {
                    throw new ArgumentException("Whatever");
                }
                this.pilot = value;
            }
        }

        public IList<string> Targets
        {
            get
            {
                return new List<string>(this.targets);
            }
        }

        public void Attack(string target)
        {
            this.targets.Add(target);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            var targetsAsString = this.targets.Count > 0 ? string.Join(", ", this.targets) : "None";

            result.AppendLine(string.Format("- {0}", this.Name));
            result.AppendLine(string.Format(" *Type: {0}", this.GetType().Name));
            result.AppendLine(string.Format(" *Targets{0}", targetsAsString));

            return result.ToString();
        }
    }
}
