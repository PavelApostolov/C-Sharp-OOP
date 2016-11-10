using Societies.Core.Contracts;
using Societies.Core.Infrastructure.Enumeration.Human;
using Societies.Core.Infrastructure.Utils;
using Societies.Core.Models.Humans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Societies
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IHuman human = new Waiter(
                DataGenerator.GenerateMaleName(),
                DataGenerator.GenerateAge(),
                HairColorType.Black,
                EyesColorType.Brown,
                FaceShapeType.Diamond,
                RaceType.European,
                GenderType.Male,
                ReligionType.Agnosticism
                );
            Console.WriteLine(human);
        }
    }
}
