using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCustomizer
{
    public class CharacterStyle
    {
        private string _skin;
        private string _color;
        private string _eyes;

        public string Skin { get; set; }
        public string Color { get; set; }
        public string Eyes { get; set; }

        public CharacterStyle(string skin, string color, string eyes)
        {
            if (skin == null || color == null || eyes == null)
            {
                throw new InvalidItemException("Cannot exist in this world without these!");
            }

            _skin = skin;
            _color = color;
            _eyes = eyes;
        }


    }
}
