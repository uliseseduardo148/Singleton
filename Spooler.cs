using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Spooler
    {
        /*Al ejecutarse la primera vez,  se crea un objeto de la clase Spooler, por lo que la variable
         * instance_flag toma el valor de true, indicando el proceso exitoso; al intentar hacer 
         * nuevamente una instancia de la clase Spooler, la variable tendra el valor de true por
         * lo que se lanzará la excepción indicando que ya existe una instancia anterior
         */
        static bool instance_flag = false;
        public Spooler()
        {
            if (instance_flag)
            {
                throw new SingletonException("Sólo se permite una cola de impresión, excepción generada");
            }
            else
            {
                instance_flag = true; //set flag
                Console.WriteLine("Impresora abierta");
            }
        }

        //Este método compruebra si existe una instancia, si existe retorna nulo, caso contrario retorna una nueva
        public static Spooler getSpooler()
        {
            if (!instance_flag)
                return new Spooler();
            else
                return null;
        }    }
}
