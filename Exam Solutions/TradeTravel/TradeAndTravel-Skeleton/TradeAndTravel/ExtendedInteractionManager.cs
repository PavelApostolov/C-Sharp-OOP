﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    public class ExtendedInteractionManager : InteractionManager
    {
        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "weapon":
                   return new Weapon(itemNameString, itemLocation);
                case "wood":
                    return new Wood(itemNameString, itemLocation);
                case "iron":
                    return new Iron(itemNameString, itemLocation);
            }
            return base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            switch (personTypeString)
            {
                case "merchant":
                    return new Merchant(personNameString, personLocation);
                default:
                    return base.CreatePerson(personTypeString, personNameString, personLocation);
            }
            
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            switch(locationTypeString)
            {
                case "mine":
                    return new Mine(locationName);
                case "forest":
                    return new Forest(locationName);
                default:
                    return base.CreateLocation(locationTypeString, locationName);
            }
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    this.HandleGatherInteraction(actor, commandWords[2]);
                    break;
                case "craft":
                    this.HandleCraftInteraction(actor, commandWords[2], commandWords[3]);
                    break;
                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }
            
        }

        private void HandleCraftInteraction(Person actor, string itemTypeString, string itemName)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    this.HandleWeaponCrafting(actor, itemName);
                    break;
                case "armor":
                    this.HandleArmorCrafting(actor, itemName);
                    break;
            }
        }

        private void HandleWeaponCrafting(Person actor, string itemName)
        {
           var itemsRequired = new List<ItemType> { ItemType.Iron, ItemType.Wood };
            if (itemsRequired.All(i => actor.HasItemInInventory(i)))
            {
                this.AddToPerson(actor, new Weapon(itemName));
            }
            
        }

        private void HandleArmorCrafting(Person actor, string itemName)
        {
            var itemRequired = ItemType.Iron;
            if (actor.HasItemInInventory(itemRequired))
            {
                this.AddToPerson(actor, new Armor(itemName));
            }
        }

        private void HandleGatherInteraction(Person actor, string itemName)
        {
            if (actor.Location is IGatheringLocation)
            {
                var gatheringLocation = actor.Location as IGatheringLocation;
                if (actor.ListInventory().Any(i => i.ItemType == gatheringLocation.RequiredItem))
                {
                    this.AddToPerson(actor, gatheringLocation.ProduceItem(itemName));
                }
            }

            /*if (actor.Location.LocationType == LocationType.Forest &&
                actor.ListInventory().Any(i => i.ItemType == ItemType.Weapon))
            {
                this.AddToPerson(actor, new Wood(itemName));
            }

            if (actor.Location.LocationType == LocationType.Mine &&
            actor.ListInventory().Any(i => i.ItemType == ItemType.Armor))
            {
                this.AddToPerson(actor, new Iron(itemName));
            }*/
        }
    }
}
