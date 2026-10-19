using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCustomizer
{
    public class CharacterManager
    {
        private List<CostumePiece> _costumeList;
        

        public List<CostumePiece> CostumeList { get { return _costumeList; } }
        public void Add(CostumePiece costumePiece)
        {
            if (costumePiece == null)
            {
                throw new InvalidItemException("No costumes available");
            }
            _costumeList.Add(costumePiece);
        }

        public CharacterManager()
        {
            _costumeList = new List<CostumePiece>();

        }

    }
}
