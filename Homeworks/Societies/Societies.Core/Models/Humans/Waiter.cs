using Societies.Core.Models.Humans.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Societies.Core.Infrastructure.Enumeration.Human;
using Societies.Core.Contracts;

namespace Societies.Core.Models.Humans
{
    public class Waiter : Human, IWaiter
    {
        private decimal bakshishes;
        private Dictionary<IHuman, IRestaurantOrder> orders;

        public Waiter(
            string name, 
            int age, 
            HairColorType hairColor, 
            EyesColorType eyesColor, 
            FaceShapeType faceShape, 
            RaceType race, 
            GenderType gender, 
            ReligionType religion) 
            : base(name, age, hairColor, eyesColor, faceShape, race, gender, religion)
        {
            this.orders = new Dictionary<IHuman, IRestaurantOrder>();
        }

        public decimal Bakshishes
        {
            get
            {
                return this.bakshishes;
            }

            set
            {
                this.bakshishes = value;
            }
        }

        public void GetOrder(IRestaurantOrder order, IHuman client)
        {
            this.orders.Add(client, order);
        }

        public void RequestPayment(IHuman client)
        {
            throw new NotImplementedException();
        }

        public void ServeOrder(IHuman client)
        {
            var clientOrder = this.orders[client];
            client.Eat(clientOrder.Foods);
        }
    }
}
