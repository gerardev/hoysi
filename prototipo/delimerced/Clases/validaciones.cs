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
