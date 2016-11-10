using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Pilot : IPilot
    {
        private string name;
        private ICollection<IMachine> machines;

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null");
                }

                this.name = value;
            }
        }

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }

        public void AddMachine(IMachine machine)
        {
            if (machine == null)
            {
                throw new NullReferenceException("Null machine cannot be added to pilot");
            }

            this.machines.Add(machine);
        }

        public string Report()
        {
            var sortedMachines = this.machines.OrderBy(m => m.HealthPoints).ThenBy(m => m.Name);

            var noMachines = this.machines.Count > 0 ? this.machines.Count.ToString() : "no";

            var pluralMaybe = this.machines.Count == 1
                ? "machine"
                : "machines";

            var result = new StringBuilder();
            result.AppendLine(string.Format("{0} - {1} {2}", this.Name, noMachines, pluralMaybe));

            foreach (var machine in sortedMachines)
            {
                result.AppendLine(machine.ToString());
            }
            return result.ToString();
        }
    }
}
