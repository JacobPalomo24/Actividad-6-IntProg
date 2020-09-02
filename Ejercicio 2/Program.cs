using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positive_or_negative {
    class Program {
        static void Main(string[] args){
            /*
             * 2.- Realice un algoritmo para determinar si un número es positivo o negativo.
             *     1. Inicio.
             *     2. Leer NÚM
             *     3. Si NÚM >= 0
             *        Entonces
             *          Hacer R = “POSITIVO”
             *        Si no
             *          Hacer R = “NEGATIVO”
             *        Fin de comparación
             *     4. Escribir “el número es”, R
             *     5. Fin
             */

            Console.Write("Ingrese un número: ");
            int n = int.Parse(Console.ReadLine());

            string r;
            if(n >= 0){
                r = "positivo.";
            } else{
                r = "negativo.";
            }

            Console.WriteLine("\nEl número " + n + " es " + r);

            Console.Write("\nPresiona cualquier tecla para salir...");
            Console.ReadKey(true);
        }
    }
}
