using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCustomizer
{
    public class HeadPiece : CostumePiece
    {
        private bool _isEyesCovered;

        public HeadPiece(string name, string description, int cost, string slot, string rarity, bool isEyesCovered)
            : base(name, description, cost, slot, rarity)
        {
            if (slot != "Head")
            {
                throw new InvalidItemException("This won't fit on your head!");
            }

            _isEyesCovered = isEyesCovered;
        }

        public override string GetCategory()
        {
            return "HeadPiece";
        }
        public override string GetBonusText()
        {
            if (_isEyesCovered)
            {
                return "Get a haircut!";
            }
            else
            {
                return "Nice haircut!";
            }
        }
        public override string Describe()
        {
            return base.Describe() + $" {GetBonusText()}";
        }
    }
}
