using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Cantante
    {
        private string nombre;
        private string discoMasVendido;

        public Cantante()
        {

        }
        public Cantante(string nombre , string discoMasVendido)
        {
            this.nombre = nombre;
            this.discoMasVendido = discoMasVendido;

        }
        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetDiscoMasVendido()
        {
            return discoMasVendido;
        }
        public void SetDiscoMasVendido(string discoMasVendido)
        {
            this.discoMasVendido = discoMasVendido;
        }
    }
}
