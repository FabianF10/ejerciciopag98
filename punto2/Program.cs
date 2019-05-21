using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    class Program
    {
        //CARGE ENTORNO DE DESAROLLO INTEGRADO EL PROGRAMA......... Y MODIFIQUE LA SENTENCIA "RETURN 9F/5F*GRADOS + 32; 

        const int limInferior = -30;
        const int limSuperior = 100;
        const int inCremento = 3;

        public static float obtenerFahrengeit(float gradosC)
        {
         
            return 9/5 * gradosC + 32;  //MODIFICAMOS LA SENTENCIA ""RETURN 9F/5F*GRADOS + 32;"" Y PROPORSIONALMENTE EL RESULTADO NO CAMBIO CAMBIO 
        }
        static void Main(string[] args)
        {

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
