using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nCantante,nDisco;
            bool salida=false;
            int option;

            List<Cantante> cantantesFamosos = new List<Cantante>();
            Cantante c1 = new Cantante();
            c1.SetNombre(" Paquita Disco ");
            c1.SetDiscoMasVendido(" Greatest hits ");

            Cantante c2 = new Cantante();
            c2.SetNombre(" La cuca ");
            c2.SetDiscoMasVendido(" Cuca Madre ");
            cantantesFamosos.Add(c1);
            cantantesFamosos.Add(c2);

            Console.WriteLine("ingresa un cantante");
            nCantante = Console.ReadLine();
            Console.WriteLine("ingresa disco mas vendido");
            nDisco = Console.ReadLine();
            Console.WriteLine();

            Cantante c3 = new Cantante();
            c3.SetNombre(nCantante);
            c3.SetDiscoMasVendido(nDisco);
            cantantesFamosos.Add(c3);

            do {

                foreach (Cantante x in cantantesFamosos)
                {
                    Console.WriteLine(x.GetNombre());
                    Console.WriteLine(x. GetDiscoMasVendido() + "\n");
                }

                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Ingresa :\n 1) si quieres escribir un nuevo artista \n 2) para salir.");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:

                        Console.WriteLine("ingresa un cantante");
                        nCantante = Console.ReadLine();
                        Console.WriteLine("ingresa disco mas vendido");
                        nDisco = Console.ReadLine();
                        Console.WriteLine();

                        cantantesFamosos.Add(new Cantante(nCantante, nDisco));

                        foreach (Cantante x in cantantesFamosos)
                        {
                            Console.WriteLine(x.GetNombre());
                            Console.WriteLine(x.GetDiscoMasVendido() + "\n");
                        }
                        break;

                    case 2:
                        salida = true;
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;
                }
            } while (salida == false);

            Console.ReadLine();
        }
    }
}
