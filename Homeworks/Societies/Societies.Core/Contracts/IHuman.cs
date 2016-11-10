
using Societies.Core.Infrastructure.Enumeration.Human;
using Societies.Core.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Societies.Core.Contracts
{
    public interface IHuman
    {
        string Name { get; }
        int Age { get; }
        int Id { get; }
        GenderType Gender { get; }
        ReligionType Religion { get; }      
        RaceType Race { get; }
        HairColorType HairColor { get; }
        FaceShapeType FaceShape { get; }
        EyesColorType EyesColor { get; }
        decimal MoneyInEuro { get; }
        int StarvationLevel { get; }
        int ThirstLevel { get; }
        int VitalityLevel { get; }

        void Eat(ICollection<IFood> food);
        void Drink(ICollection<IBeverage> beverage);
        void Work(int hours);
        void Rest(int minutes);
        void Sleep(int hours);

        decimal Pay(decimal amountToBePaid);
    }
}
