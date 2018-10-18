using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troya
{
    class Troyano
    {
        private string nTroyano;
        private int edad, fuerza;
        private bool herido = false;
        private bool muerto = false;
        private bool retirarse = false;
        private bool cEdad = false;
        private bool cFuerza = false;

        public Troyano()
        {

        }
        public Troyano(string nTroyano, int edad, int fuerza, bool herido, bool muerto)
        {
            this.nTroyano = nTroyano;
            this.edad = edad;
            this.fuerza = fuerza;
            this.herido = herido;
            this.muerto = muerto;
        }
        public Troyano(string nTroyano, int edad, int fuerza)
        {
             this.nTroyano = nTroyano;
            if (ComprobarFuerza(fuerza))
            {
                this.edad = edad;
                this.fuerza = fuerza;
                //hacerse
            }
            else
            {
                this.nTroyano = nTroyano;
                this.edad = 25;
                this.fuerza = 5;
                // asignarse 25
            }
            if(ComprobarEdad(edad))
            {
                this.edad = edad;
            }
            else
            {
                this.edad = 25;
            }
        }

        public string GetNombre()
        {
            return nTroyano;
        }

        public int GetEdad()
        {
            return edad;
        }

        public int GetFuerza()
        {
            return fuerza;
        }

        public bool GetHerido()
        {
            return herido;
        }

        public bool GetMuerto()
        {
            return muerto;
        }

        public void SetNombre(string nTroyano)
        {
            this.nTroyano = nTroyano;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public void SetFuerza(int fuerza)
        {
            this.fuerza = fuerza;
        }

        public void SetHerido(bool herido)
        {
            this.herido = herido;
        }

        public void SetMuerto(bool muerto)
        {
            this.muerto = muerto;
        }

        public bool Retirarse(bool retirarse)
        {
            return retirarse;
        }
        // metodos

        public bool ComprobarEdad(int edad)
        {
            if (edad >= 15 && edad <= 60)
            {
                cEdad = true;
            }
            return cEdad;
        }

        public bool ComprobarFuerza(int fuerza)
        {
            if (fuerza >= 1 && fuerza <= 10)
            {
                cFuerza = true;
            }
            return cFuerza;
        }
        public void MostrarDatos()
        {
            Console.WriteLine("El nombre es : " + GetNombre() + "\n La edad es : " + GetEdad() + "     La fuerza :" + GetFuerza()  );
            NoRetirarse();
        }
        public void NoRetirarse()
        {
            if (herido)
            {
                Console.WriteLine("Los troyanos nunnca se retiran ");
            }
        }
        public void Troyanos(string nTroyano, int edad, int fuerza)
        {
            if (ComprobarFuerza(fuerza) && ComprobarEdad(edad))
            {
                this.nTroyano = nTroyano;
                this.edad = edad;
                this.fuerza = fuerza;
                //hacerse
            }
            else
            {
                this.nTroyano = nTroyano;
                this.edad = 25;
                this.fuerza = 5;
                // asignarse 25
            }
           

        }


    }


}

