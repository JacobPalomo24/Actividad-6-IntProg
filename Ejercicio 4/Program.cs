using System;

namespace uva {
    class Program {
        static void Main(string[] args){
            /*
                4.- La asociación de vinicultores tiene como política fijar un precio inicial al kilo de uva, la
                    cual se clasifica en tipos A y B, y además en tamaños 1 y 2. Cuando se realiza la venta del
                    producto, ésta es de un solo tipo y tamaño, se requiere determinar cuánto recibirá un
                    productor por la uva que entrega en un embarque, considerando lo siguiente: si es de tipo
                    A, se le cargan 20¢ al precio inicial cuando es de tamaño 1; y 30¢ si es de tamaño 2. Si es de
                    tipo B, se rebajan 30¢ cuando es de tamaño 1, y 50¢ cuando es de tamaño 2. Realice un
                    algoritmo para determinar la ganancia obtenida.

                        1. Inicio
                        2. Leer TI, TA, P, K
                        3. Si TI = “A”
                           Entonces
                                Si TA = 1
                                Entonces
                                    P = P + 0.20
                                Si no
                                    P = P + 0.30
                                Fin compara
                           Si no
                                Si TA = 1
                                Entonces
                                    P = P - 0.30
                                Si no
                                    P = P - 0.50
                                Fin compara
                           Fin compara
                        4. Hacer GA = P * K
                        5. Escribir “La ganancia es”, GA
                        6. Fin
             */

            Console.Write("Ingrese el precio inicial del kilo de uva: ");
            double p = double.Parse(Console.ReadLine());

            Console.Write("Ingrese los kilos de uva a comprar: ");
            double k = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el tipo de uva: ");
            string ti = Console.ReadLine();

            Console.Write("Ingrese el tamaño de uva: ");
            int ta = int.Parse(Console.ReadLine());

            if(ti == "A"){ 
                if(ta == 1){
                    p += .2;
                } else{
                    p += .3;
                }
            } else{ 
                if(ta == 1){
                    p -= .3;
                } else{
                    p -= .5;
                }
            }

            double ga = p * k;

            Console.WriteLine("La ganancia es de $" + ga + " pesos.");

            Console.Write("Presione cualquier tecla para salir...");
            Console.ReadKey(true);
        }
    }
}
