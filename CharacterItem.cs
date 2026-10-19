using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCustomizer
{
    public abstract class CharacterItem : IDescribable
    {
        private string _name;
        private string _description;
        private int _cost;
        public string Name { get { return _name; } }
        public string Description { get { return _description; } }

        public int Cost { get { return _cost; } }



        public CharacterItem(string name, string description, int cost)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new InvalidItemException("No name provided!");
            }
            if (cost < 0)
            {
                throw new InvalidItemException("No price provided!");
            }

            _name = name;
            _description = description;
            _cost = cost;
        }

        public abstract string GetCategory();
        public abstract string GetBonusText();
        public virtual string Describe()
        {
            return $"{Name,4} {Description} {Cost} {GetCategory()} ";
        }
        public override string ToString()
        {
            return Describe();
        }
    }
}
