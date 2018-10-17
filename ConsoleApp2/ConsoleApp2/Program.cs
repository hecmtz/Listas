using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string num;
            double newDouble=0, compara, sumaent = 0, sumadouble = 0;
            int newInt=0;
            int cDouble = 0, cInt = 0;
            List<double> ListaDouble = new List<double>();
            List<int> ListaInt = new List<int>();


            do
            {
                Console.WriteLine("introduce numero : ");
                num = Console.ReadLine();

                //si contieneagregarlista
                if (num.Contains(","))
                {
                    try
                    {
                        newDouble = Convert.ToDouble(num);
                        newDouble = newDouble / 10;
                        ListaDouble.Add(newDouble);
                        cDouble = cDouble + 1;
                    }
                    catch (FormatException ex)
                    {
                        ex.ToString();
                        Console.WriteLine("Error modifica");
                    }
                }
                else if (num.Contains("."))
                {
                    try
                    {
                        newDouble = Convert.ToDouble(num);
                        newDouble = newDouble / 10;
                        ListaDouble.Add(newDouble);
                        cDouble = cDouble + 1;
                    }
                    catch (FormatException ex)
                    {
                        ex.ToString();
                        Console.WriteLine("Error modifica");
                    }
                }
                else if (num.Contains("-"))
                {
                    break;
                }

                else
                {
                    try
                    {
                        newInt = Convert.ToInt32(num);
                        ListaInt.Add(newInt);
                        cInt = cInt + 1;

                    }
                    catch (FormatException ex)
                    {
                        ex.ToString();
                        Console.WriteLine("Error modifica");
                    }
                }

                //try
                //{
                //compara = Convert.ToDouble(num);
                  

                //}
                //catch (FormatException ex)
                //{
                //    ex.ToString();
                //    Console.WriteLine("Error modifica");
                //}

                

            } while (newDouble >= 0 || newInt>=0);

            Console.WriteLine("el total de enteros es" + (cInt));
            Console.WriteLine("el total de doubles es" + cDouble);

            foreach (int x in ListaInt)

            {

                sumaent += x;

            }            Console.WriteLine("la suma de enteros es" + sumaent);
            foreach (double x in ListaDouble)
            {

                sumadouble += x;

            }

            double media = (sumaent + sumadouble) / (cDouble + cInt);


            Console.WriteLine("La media es :" + media);
            Console.ReadLine();
            /*do
            {
                if(num.contain(','))
                {
                    decim.Add(num);
                }
            }
            */


        }

        public static bool RegresarComa(string num)
        {
            string num1 = num;
            char coma = ',';
            bool commanInWord = false;
            bool contiene;
            foreach (char letter in num)
            {
                if (letter == coma)
                {
                    commanInWord = true;
                    break;
                }
            }

            if (commanInWord)
            {
                //decimal
                contiene = true;
            }
            else
            {
                //entero
                contiene = false;
                // newInt = Convert.ToInt32(num);
                //  ListaDouble.Add(newInt);

            }

            return contiene;
        }

        public static void AgregarLista()
        {

        }
    }
}
