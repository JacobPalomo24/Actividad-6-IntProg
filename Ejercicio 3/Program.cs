using System;

namespace cotizador_precio_lapiz {
    class Program {
        static void Main(string[] args){
            /*
                 3.- Realice un algoritmo para determinar cuánto se debe pagar por equis cantidad de lápices
                     considerando que si son 1000 o más el costo es de 85¢; de lo contrario, el precio es de 90¢.
                        1. Inicio
                        2. Leer X
                        3. Si X >= 1000
                        Entonces
                        Hacer PAG = X * 0.85
                        Si no
                        Hacer PAG = X * 0.90
                        Fin de comparación
                        4. Escribir “el pago es”, PAG
                        5. Fin
             */

            Console.Write("Ingrese la cantidad de lápices: ");
            int l = int.Parse(Console.ReadLine());

            double precio;
            if(l >= 1000){
                precio = l * 0.85;
            } else{
                precio = l * 0.9;
            }

            Console.WriteLine("\nEl total a pagar por " + l + " lápices es de $" + precio + " pesos.");

            Console.Write("\nPresione cualquier tecla para salir...");
            Console.ReadKey(true);
        }
    }
}
