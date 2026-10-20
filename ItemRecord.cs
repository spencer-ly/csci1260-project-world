using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCustomizer
{
    public class ItemRecord : IEquatable<ItemRecord>
    {
        private string _name;
        private string _category;

        public string Name { get {  return _name; } }
        public string Category { get { return _category; } }

        public ItemRecord(string name, string category)
        {
            if (name == null)
            {
                throw new InvalidItemException("No name provided");
            }
            if (category == null)
            {
                throw new InvalidItemException("No category provided");
            }

            _name = name;
            _category = category;
        }

        public bool Equals(ItemRecord other)
        {
            if (other == null)
            {
                return false;
            }
            if (Name == other.Name && Category == other.Category)
            {
                return true;
            }
            return false;
        }
        public override bool Equals(object? obj)
        {
            return Equals(obj as ItemRecord);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Category);
        }
    }
}
