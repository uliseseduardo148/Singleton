using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SingleSpooler
    {
        static void Main(string[] args)
        {
            Spooler pr1, pr2;
            //Se crea una instancia de la clase Spooler, esto siempre será exitoso
            Console.WriteLine("Abriendo cola de impresión");
            try
            {
                pr1 = new Spooler();
            }
            catch (SingletonException e)
            {
                Console.WriteLine(e.Message);
            }
            //Se intenta crear otra instancia de la clase Spooler, esto fallará puesto que ya existe una instancia
            Console.WriteLine("Abriendo otra cola de impresión");
            try
            {
                pr2 = new Spooler();
            }
            catch (SingletonException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
