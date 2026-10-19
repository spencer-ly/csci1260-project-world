using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCustomizer
{
    public class Outfit : CostumePiece
    {
        private string _material;

        public string Material { get { return _material; } }

        public Outfit(string name, string description, int cost, string slot, string rarity, string material)
            : base(name, description, cost, slot, rarity)
        {
            if (slot != "Torso" && slot != "Pants")
            {
                throw new InvalidItemException("Can't go out looking like that!");
            }
            if (material != "Burlap" && material != "Felt" && material != "Cloth")
            {
                throw new InvalidItemException("Not a valid material!");
            }

            _material = material;
        }

        public override string GetCategory()
        {
            return "Outfit";
        }

        public override string GetBonusText()
        {
            string info;

            if (_material == "Burlap")
            {
                info = "Can't go wrong with burlap!";
                return info;
            }
            if (_material == "Felt")
            {
                info = "Nice and fuzzy!";
                return info;
            }
            if (_material == "Cloth")
            {
                info = "Soft as silk!";
                return info;
            }

            else return "Not quite my style...";
        }

        public override string Describe()
        {
            return base.Describe() + $" {GetBonusText()} Material: {Material}";
        }
    }
}
