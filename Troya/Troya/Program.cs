using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troya
{
    class Program
    {
        static void Main(string[] args)
        {
            Troyano t1 = new Troyano();
            Troyano t2 = new Troyano("TroyanoX",25,5);
            t1.SetNombre("Bongo");
            t1.SetEdad(19);
            t1.SetFuerza(5);
            t1.SetHerido(true);

            t1.MostrarDatos();
            Console.WriteLine(" ");
            t2.MostrarDatos();
            Console.WriteLine(" ");
            Griego g1 = new Griego();
            Griego g2 = new Griego("GriegoX", 20, 8 );
            g1.SetNombre("Moncho");
            g1.SetEdad(19);
            g1.SetFuerza(5);
            g1.SetHerido(true);



            g1.MostrarDatos();
            Console.WriteLine(" ");
            g2.MostrarDatos();

            Console.ReadLine();
        }
    }
}
