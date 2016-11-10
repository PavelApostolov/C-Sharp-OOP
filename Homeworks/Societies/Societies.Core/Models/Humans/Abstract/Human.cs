using Societies.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Societies.Core.Infrastructure.Enumeration.Human;
using Societies.Core.Models.Common;
using Societies.Core.Infrastructure.Utils;
using Societies.Core.Infrastructure.Constants;

namespace Societies.Core.Models.Humans.Abstract
{
    public abstract class Human : IHuman
    {
        private readonly string name;
        private readonly int age;
        private readonly int id;
        private readonly HairColorType hairColor;
        private readonly EyesColorType eyesColor;
        private readonly FaceShapeType faceShape;
        private readonly ReligionType religion;
        private readonly GenderType gender;
        private readonly RaceType race;
        private int vitalityLevel;
        private int starvationLevel;
        private int thirstLevel;
        private decimal moneyInEuro;

        private Human()
        {
            this.vitalityLevel = ValidationConstants.VitalityLevelMaxValue;
            this.thirstLevel = ValidationConstants.ThirstLevelMaxValue;
            this.starvationLevel = ValidationConstants.StarvationLevelMaxValue;
            this.moneyInEuro = ValidationConstants.MoneyInEuroMinValue;
        }

        public Human(
            string name,
            int age,
            HairColorType hairColor,
            EyesColorType eyesColor,
            FaceShapeType faceShape,
            RaceType race,
            GenderType gender,
            ReligionType religion
            ) : this()
        {
            this.id = DataGenerator.GenerateUniqueId();
            this.name = name;
            this.age = age;
            this.hairColor = hairColor;
            this.eyesColor = eyesColor;
            this.faceShape = faceShape;
            this.race = race;
            this.religion = religion;
            this.gender = gender;

        }

        public int Age
        {
            get { return this.age; }
        }

        public EyesColorType EyesColor { get; }


        public FaceShapeType FaceShape { get; }


        public GenderType Gender { get; }

        public HairColorType HairColor { get; }

        public int Id
        {
            get { return this.id; }
        }

        public decimal MoneyInEuro
        {
            get { return this.moneyInEuro; }
            private set
            {
                if (value < ValidationConstants.MoneyInEuroMinValue)
                {
                    throw new ArgumentOutOfRangeException("Insufficent money!");
                }
            }
        }
        public string Name
        {
            get { return this.name; }
        }

        public RaceType Race { get; }
        public ReligionType Religion { get; }

        public int StarvationLevel
        {
            get { return this.starvationLevel; }
        }
        public int ThirstLevel
        {
            get { return this.thirstLevel; }
        }
        public int VitalityLevel
        {
            get { return this.vitalityLevel; }
            private set
            {
                if (value < ValidationConstants.VitalityLevelMinValue)
                {
                    this.vitalityLevel = ValidationConstants.VitalityLevelMinValue;
                }
            }
        }

        public void Drink(ICollection<IBeverage> beverage)
        {
            throw new NotImplementedException();
        }

        public void Eat(ICollection<IFood> food)
        {
            throw new NotImplementedException();
        }

        public void Rest(int minutes)
        {
            throw new NotImplementedException();
        }

        public void Sleep(int hours)
        {
            throw new NotImplementedException();
        }

        public void Work(int hours)
        {
            throw new NotImplementedException();
        }

        public virtual decimal Pay(decimal amountToBePaid)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            var builder = new StringBuilder(500);
            builder.AppendLine(new string('=', 60));
            builder.AppendLine($"Id: {this.Id}");
            builder.AppendLine($"Name: {this.name}");
            builder.AppendLine($"Age: {this.age}");
            builder.AppendLine($"Vitality: {this.vitalityLevel}/{ValidationConstants.VitalityLevelMaxValue}");
            builder.AppendLine($"Starvation level: {this.starvationLevel}/{ValidationConstants.StarvationLevelMaxValue}");
            builder.AppendLine($"Thirat level: {this.thirstLevel}/{ValidationConstants.ThirstLevelMaxValue}");
            builder.AppendLine($"Race: {this.gender}");
            builder.AppendLine($"Gender: {this.race}");
            builder.AppendLine($"Religion: {this.religion}");
            builder.AppendLine($"Face shape: {this.faceShape}");
            builder.AppendLine($"Eyes color: {this.eyesColor}");
            builder.AppendLine($"Hair color: {this.hairColor}");
            builder.AppendLine($"Money in euro: {this.moneyInEuro}");
            builder.AppendLine(new string('=', 60));


            return builder.ToString();
        }

        public override int GetHashCode()
        {
            return this.id.GetHashCode();
        }
    }
}
