using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Centralita c = new Centralita();
                Llamada l = new Provincial("Misiones", Provincial.Franja.Franja_1, 2.5f,"Santa cruz");
                c += l;
                c += l;
            }
            catch (CentralitaException ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
            }

        }
    }
}
