using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SingletonException:Exception
    {
        //Se obtiene una excepción, la cual recibe un mensaje que luego se imprime en consola
        public SingletonException(string s) : base(s)
        {
        }    }
}
