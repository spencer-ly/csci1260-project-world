using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCustomizer
{
    public abstract class CostumePiece : CharacterItem
    {
        private string _slot;
        private string _rarity;

        public string Slot { get { return _slot; } }
        public string Rarity { get { return _rarity; } }
        public CostumePiece(string name, string description, int cost, string slot, string rarity)
            :base(name, description, cost)
        {
            
            if (slot != "Head" && slot != "Torso" && slot != "Pants" && slot != "Shoes")
            {
                throw new InvalidItemException("No matching costume area!");
            }
            if (rarity != "Common" && rarity != "Rare" && rarity != "Developer Only")
            {
                throw new InvalidItemException("No matching rarity area!");
            }

            _slot = slot;
            _rarity = rarity;
        }

        public override string Describe()
        {
            return base.Describe() + $" {_slot} ";
        }

    }
}
