using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num_mayor {
    class Program {
        static void Main(string[] args) {
            /*
             * 1.- Se desea implementar un algoritmo para determinar cuál de dos valores proporcionados
             *     es el mayor.
             *      1. Inicio
             *      2. Leer A, B
             *      3. Si A > B
             *         Entonces
             *           Hacer M = A
             *         Si no
             *           Hacer M = B
             *      Fin de comparación
             *      4. Escribir “el mayor es”, M
             *      5. Fin
             */

            Console.Write("Ingresa un número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa otro número: ");
            int n2 = int.Parse(Console.ReadLine());

            int M;
            if(n1 > n2){
                M = n1;
            } else{
                M = n2;
            }

            Console.WriteLine("\nEl mayor es " + M);

            Console.Write("\nPresiona cualquier tecla para salir...");
            Console.ReadKey(true);
        }
    }
}
