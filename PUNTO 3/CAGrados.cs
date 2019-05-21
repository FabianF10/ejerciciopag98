using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciopag94
 {

    class Program
    {// definicion de las constantes
        const int limInferior = -30;
        const int limSuperior = 2;
        const int inCremento = 3;

        public static float obtenerFahrengeit(float gradosC)
        {

            //retornamos los grados fahrengeit equivalente a grados 
            return 9f / 5F * gradosC + 32;
        }
        public static void Main(string[] args)
        {
            // declaramos las variables 

          

            int gradosCent = limInferior;
            float gradosFahr = 0;

            while (gradosCent <= limSuperior) 
            {


                //obtener grados fahrenheit equivalentes a gradoscent
                gradosFahr = obtenerFahrengeit(gradosCent);
                //escribir siguiente linea de tabla 
                System.Console.WriteLine("{0,8:d} c{1,8:f2} f", gradosCent, gradosFahr);


             
                gradosCent += inCremento;
            }

            Console.ReadKey();



            

                

            












        }
    }
 }
