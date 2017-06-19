using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "sdahgsdkjaskdjh2asd";
            bool result = text.All(Char.IsLetter);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
