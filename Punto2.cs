using System;
using System.Collections.Generic;
using System.Text;

namespace pruebaIntel
{
    class Punto2
    {
        

        public void analizarCadena()
        {
            Console.WriteLine("Write something that you want to analyze how many vocals it has  ");
            string oracion = Console.ReadLine();
            oracion = oracion.ToLower();
            Console.WriteLine(oracion);

            int a = 0;
            int e = 0;
            int i = 0;
            int o = 0;
            int u = 0;


            for(int y=0; y < oracion.Length; y++)
            {
                
                string variable = oracion[y].ToString();


                switch (variable) {

                    case "a" :
                        a += 1;
                        break;
                    case "e":
                         e+= 1;
                        break;
                    case "i":
                        i += 1;
                        break;
                    case "o":
                        o += 1;
                        break;
                    case "u":
                        u += 1;
                        break;








                }


            }

            DarResultados( a,  e,  i,  o,  u);



        }

        private void DarResultados(int a, int e , int i , int o, int u)
        {

            Console.WriteLine("The results for the vocal  A --> " +a);
            Console.WriteLine("The results for the vocal  E --> " + e);
            Console.WriteLine("The results for the vocal  I --> " + i);
            Console.WriteLine("The results for the vocal  O --> " + o);
            Console.WriteLine("The results for the vocal  U --> " + u);

        }



    }
}
