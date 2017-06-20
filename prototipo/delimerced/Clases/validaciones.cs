using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delimerced.Clases
{
    class validaciones
    {

        public bool notempty(string texto)
        {
            if (texto == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool separator(string texto)
        {
            bool result = texto.All(Char.IsSeparator);
            if (result == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool onlynumbers(string texto)
        {
            bool result = texto.All(Char.IsNumber);
            if (result == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool onlyletters(string texto)
        {
            bool result = texto.All(Char.IsLetter);
            if (result == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
