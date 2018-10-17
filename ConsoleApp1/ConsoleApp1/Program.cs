using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class ProgramListas
    {
        static void Main(string[] args)
        {
            string articulo = "Manzanas";
            List<String> compra = new List<String>();
            CrearLista(compra);
            MostrarLista(compra);
            OrdenarLista(compra);
            BorrarLista(compra, articulo);
            MostrarLista(compra);
            Console.WriteLine(ContarElementos(compra));
            Console.ReadLine();
        }
        public static void CrearLista(List<string> compra)
        {
            compra.Add("Manzanas");
            compra.Add("Carne");

        }
        public static void MostrarLista(List<string> compra)
        {
            foreach (String x in compra)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(" ");
        }
        public static void OrdenarLista(List<string> compra)
        {
            //compra.OrderBy(o => o).ToList();
            compra.Sort();
            foreach (String x in compra)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(" ");
        }

        public static void BorrarLista(List<string> compra, string articulo) //hola
        {
            compra.Remove(articulo);
        }
        public static int ContarElementos(List<string> compra)
        {
            return compra.Count;
            //comentarios
        }
    }
}
