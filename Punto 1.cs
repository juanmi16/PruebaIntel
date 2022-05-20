using System;
using System.Collections.Generic;
using System.Text;

namespace pruebaIntel
{
    public class Punto_1
    {
        public void multiplos()
        {
            Boolean seguir = false;
            
            do
            {
                Console.WriteLine("Please enter one value between 1 and 1000");
                try
                {
                    int numero = Int32.Parse(Console.ReadLine()); 

                    if(numero>=1 && numero <= 1000)
                    {
                        comopararMultiplos(numero);
                        seguir = true;
                        

                    }
                    else
                    {

                    }


                }catch (Exception e)
                {
                    Console.WriteLine("You are not typing a rigth type of  number for the operation" +e);

                }


            } while (seguir==false);



            //Console.WriteLine(90%3);

            
        }



        //Se realiza un metodo privado para que no pueda ser accedido desde la instancia 
        //del objeto en la clase principal. 
        private void comopararMultiplos(int numero)
        {

            //Cilo for en el cual se realiza un recorrido hats el nuemero que nos indica el 
            //El usuario
            for (int i = 0; i < numero+1; i++)
            {
                //Es tanto multiplo de 5 y de 3
                if(i %5==0 && i%3==0)
                {
                    Console.WriteLine("-----*****-----");
                    Console.WriteLine("foo bar");

                } //Es multiplo unicamente de 3
                else if(i %3==0)
                {
                    Console.WriteLine("-----*****-----");
                    Console.WriteLine("Bar");
                }//Es multiplo unicamente de 5
                else if (i% 5==0)
                {
                    Console.WriteLine("-----*****-----");
                    Console.WriteLine("Foo");


                }
                else //No Es multiplo de ninguno de los dos numeros 
                {
                    Console.WriteLine("-----*****-----");
                    Console.WriteLine(i);

                }


            }

        }


        
    }
}
