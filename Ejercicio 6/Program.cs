using System;

namespace banco {
    class Program {
        static void Main(string[] args){
            /*
                6.- El banco “Pueblo desconocido” ha decidido aumentar el límite de crédito de las tarjetas
                    de crédito de sus clientes, para esto considera que si su cliente tiene tarjeta tipo 1, el
                    aumento será de 25 %; si tiene tipo 2, será de 35 %; si tiene tipo 3, de 40 %, y para cualquier
                    otro tipo, de 50 %. Ahora bien, si la persona cuenta con más de una tarjeta, sólo se
                    considera la de tipo mayor o la que el cliente indique. Realice un algoritmo para determinar
                    el nuevo límite de crédito que tendrá una persona en su tarjeta.

                        1. Inicio
                        2. Leer TT, LA
                           Si NZ Igual a
                                1: Hacer AC = LA * 0.25
                                2: Hacer AC = LA * 0.35
                                3: Hacer AC = LA * 0.40
                           Si no
                                Hacer AC = LA * 0.50
                           Fin de comparación
                        3. Hacer NC = LA + AC
                        4. Escribir “El aumento de crédito”, AC
                        5. Escribir “Nuevo límite de crédito”, NC
                        6. Fin
             */

            Console.Write("Ingrese el tipo de tarjeta: ");
            int tt = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el limite actual de su tarjeta: ");
            double la = double.Parse(Console.ReadLine());

            double ac;
            switch(tt){
                case 1:{
                    ac = la * .25;
                    break;
                }
                case 2:{
                    ac = la * .35;
                    break;
                }
                case 3:{
                    ac = la * .4;
                    break;
                }
                default:{
                    ac = la * .5;
                    break;
                }
            }

            double nc = la + ac;

            Console.WriteLine("\nEl Aumento de Crédito es de $" + ac + " pesos.");
            Console.WriteLine("El nuevo Límite de Crédito es de $" + nc + " pesos.");

            Console.Write("\nPresione cualquier tecla para salir...");
            Console.ReadKey(true);
        }
    }
}
