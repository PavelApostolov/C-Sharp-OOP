using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Societies.Core.Infrastructure.Utils
{
   public static class DataGenerator
    {
        private static int counter;
        private static string[] maleNames;
        private static string[] femaleNames;
        private static Random random;

        static DataGenerator()
        {
            counter = 0;
            maleNames = new string[]
            {
                "Gosho",
                "Pesho",
                "Ivan",
                "Pavel"
            };

            femaleNames = new string[]
            {
                "Pichka",
                "Penka",
                "Gergana",
                "Pavleta"
            };

            random = new Random();
        }

        public static int GenerateUniqueId()
        {
            //lock (new object())
            return Interlocked.Increment(ref counter);
        }

        public static string GenerateMaleName()
        {
            var index = random.Next(0, maleNames.Length);
            return maleNames[index];
        }
        public static string GenerateFemaleName()
        {
            var index = random.Next(0, femaleNames.Length);
            return femaleNames[index];
        }

        public static int GenerateAge()
        {
            return random.Next(15, 40);
        }
    }
}
