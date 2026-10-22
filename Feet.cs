using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CharacterCustomizer
{
    public class Feet : CostumePiece
    {
        private bool _isBarefoot;
        


        public Feet(string name, string description, int cost, string slot, string rarity, bool isBarefoot)
            : base(name, description, cost, slot, rarity)
        {
            if (slot != "Shoes")
            {
                throw new InvalidItemException("Never in my days have I seen someone try that!");
            }

            _isBarefoot = isBarefoot;
        }

        public override string GetBonusText()
        {
            if (_isBarefoot)
            {
                return "Hang ten!";
            }
            else return "How fitting!";
        }

        public override string GetCategory()
        {
            return "Footwear";
        }

        public override string Describe()
        {
            return base.Describe() + $" {GetBonusText()}";
        }
    }
}
