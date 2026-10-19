using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCustomizer
{
    public class ItemByCostComparer : IComparer<CostumePiece>
    {
        public int Compare(CostumePiece x, CostumePiece y)
        { 
            return x.Cost.CompareTo(y.Cost); 
        }
    }
}
