using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCustomizer
{
    public class Character
    {
        private string _name;
        private int _points;
        private CharacterStyle _style;
        private List<CostumePiece> _wearing;

        public string Name { get { return _name; } }
        public int Points { get { return _points; } }
        public CharacterStyle Style { get { return _style; } }
        public List<CostumePiece> Wearing { get { return _wearing; } }

        public Character(string name, int points)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new InvalidItemException("Have to have a name!");
            }
            if (points < 0 || points > 100)
            {
                throw new InvalidItemException("No valid point range");
            }
            _style = new CharacterStyle("Burlap", "Blue", "Lashes");

            _name = name;
            _points = points;
            
            _wearing = new List<CostumePiece>();
        }

        public void Equip(string slot, CostumePiece piece)
        {
            if (piece == null)
            {
                throw new InvalidItemException("Nothing to wear given");
            }
            if (slot != piece.Slot)
            {
                throw new InvalidItemException("Wrong piece");
            }

            for (int i = _wearing.Count - 1; i >= 0; i--)
            {
                if (_wearing[i].Slot == slot)
                {
                    _wearing.RemoveAt(i);
                }
            }
            _wearing.Add(piece);
        }

    }
}
