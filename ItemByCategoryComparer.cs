using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCustomizer
{
    internal class ItemByCategoryComparer : IComparer<CostumePiece>
    {
        public int Compare(CostumePiece x, CostumePiece y)
        {
            return x.GetCategory().CompareTo(y.GetCategory());
        }
    }
}
