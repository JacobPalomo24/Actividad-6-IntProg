using System;

namespace paqueteria {
    class Program {
        static void Main(string[] args){
            /*
                5.- Una compañía de paquetería internacional tiene servicio en algunos países de América
                    del Norte, América Central, América del Sur, Europa y Asia. El costo por el servicio de
                    paquetería se basa en el peso del paquete y la zona a la que va dirigido. Lo anterior se
                    muestra en la tabla:

                                        Zona        Ubicación           Costo/gramo
                                         1      América del Norte          $11.00
                                         2       América Central           $10.00
                                         3       América del Sur           $12.00
                                         4           Europa                $24.00
                                         5            Asia                 $27.00

                    Parte de su política implica que los paquetes con un peso superior a 5 kg no son transportados,
                    esto por cuestiones de logística y de seguridad. Realice un algoritmo para determinar el cobro 
                    por la entrega de un paquete o, en su caso, el rechazo de la entrega.

                    1. Inicio
                    2. Leer NZ, PE
                    3. SI PE > 5000
                        Entonces
                            Escribir “No se puede dar el servicio”
                        Si no
                            SI NZ igual a
                                1: Hacer CO = PE * 11
                                2: Hacer CO = PE * 10
                                3: Hacer CO = PE * 12
                                4: Hacer CO = PE * 24
                            Si no
                                Hacer CO = PE * 27
                            Fin compara
                        Escribir “el costo del servicio es”, CO
                        Fin compara
                    4. Fin
             */

            Console.Write("Ingrese el peso en kg del paquete: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de la zona a la que va dirigido el paquete: ");
            int z = int.Parse(Console.ReadLine());

            double costo;
            if(peso > 5){
                Console.WriteLine("\nEl paquete no puede ser entregado porque exede el limite de peso.");
            } else{
                switch(z){
                    case 1:{
                        costo = peso * 11;
                        break;
                    }
                    case 2:{
                        costo = peso * 10;
                        break;
                    }
                    case 3:{
                        costo = peso * 12;
                        break;
                    }
                    case 4:{
                        costo = peso * 24;
                        break;
                    }
                    default:{
                        costo = peso * 27;
                        break;
                    }
                }
                Console.WriteLine("\nEl costo del servicio es de $" + costo + " pesos.");
            }

            Console.Write("Presione cualquier tecla para salir...");
            Console.ReadKey(true);
        }
    }
}
