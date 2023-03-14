using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {

            // Una compañía de turismo aventura registró los paquetes vendidos durante la
            // última temporada vacacional. Para cada venta se ingresó:
            // • Número de paquete (4 dígitos no correlativos).
            // • Cantidad de personas incluidas.
            // • Precio por persona.
            // • Horas totales de actividades.
            // • Tipo de aventura (“M”, Montaña. “T”, Trekking. “R”, Rafting. “B”, Bicicleta.
            // “C”, Canopy. “E”, Escalar. “K”, Sky. “S”, Snowboard. “J”, Jumping. “P”,
            // Parapente).
            // El lote se encuentra no ordenado y agrupado por tipo de aventura y corta con
            // número de paquete cero. En el lote no se ingresan registros cuyo tipo de aventura
            // no se haya vendido.
            // A partir de dichos datos, se solicita informar:s
            // a. La cantidad de paquetes vendidos de cada tipo de aventura..
            // b. La cantidad total de personas que disfrutaron de las aventuras durante la
            // temporada.
            // c. El total recaudado por cada venta.
            // d. La venta con mayor importe de cada tipo de aventura.
            // e. El paquete con menos horas incurridlas y en qué tipo de actividad fue.

            int numPaquete, CantidadPerson, CantidadPaquetes,CantPersonTotales = 0, minimoPaquete;
            int mayorPaquete; // para la venta con mayor importe de cada tipo de aventura.
            float precioPersona, hrstotales, precioVenta, mayorVenta, minimaHora;
            char aventura, aventuraActual, minimoAventura;

            Console.WriteLine("INGRESE EL NUMERO DE PAQUETE(4 DIGITOS) O CERO PARA TERMINAR EL PROGRAMA: ");
            numPaquete = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE LA CANTIDAD DE PERSONAS INCLUIDAS: ");
            CantidadPerson = int.Parse(Console.ReadLine());

            Console.WriteLine("PRECIO POR PERSONA: ");
            precioPersona = float.Parse(Console.ReadLine());

            Console.WriteLine("HORAS TOTALES DE ACCTIVIDAD: ");
            hrstotales = float.Parse(Console.ReadLine());

            Console.WriteLine("Tipo de aventura (“M”, Montaña. “T”, Trekking. “R”, Rafting. “B”, Bicicleta.)");
            Console.WriteLine("“C”, Canopy. “E”, Escalar. “K”, Sky. “S”, Snowboard. “J”, Jumping. “P”, Parapente)");
            aventura = char.Parse(Console.ReadLine());

            minimaHora = hrstotales;
            minimoPaquete = numPaquete;
            minimoAventura = aventura;


            while(numPaquete != 0){

                CantidadPaquetes = 0;  // para cada tipo de aventura
                mayorVenta = 0;
                mayorPaquete = 0;
                
                aventuraActual = aventura;
                while(aventura == aventuraActual && numPaquete != 0){
                    CantidadPaquetes++;
                    CantPersonTotales += CantidadPerson;

                    precioVenta = CantidadPerson * precioPersona;

                    Console.WriteLine("POR ESTA VENTA SE RECAUDO EL VALOR DE: " + precioVenta);
                    //LA VENTA CON MAYOR IMPORTE 
                    if(precioVenta > mayorVenta){
                        mayorVenta = precioVenta;
                        mayorPaquete = numPaquete;
                    }
                    //PAQUETE CON MENOS HORAS
                    if(hrstotales < minimaHora){
                        minimaHora = hrstotales;
                        minimoAventura = aventura;
                        minimoPaquete = numPaquete;
                    }

                    Console.WriteLine("INGRESE EL NUMERO DE PAQUETE(4 DIGITOS) O CERO PARA TERMINAR EL PROGRAMA: ");
                    numPaquete = int.Parse(Console.ReadLine());

                    Console.WriteLine("INGRESE LA CANTIDAD DE PERSONAS INCLUIDAS: ");
                    CantidadPerson = int.Parse(Console.ReadLine());

                    Console.WriteLine("PRECIO POR PERSONA: ");
                    precioPersona = float.Parse(Console.ReadLine());

                    Console.WriteLine("HORAS TOTALES DE ACTIVIDAD: ");
                    hrstotales = float.Parse(Console.ReadLine());

                    Console.WriteLine("Tipo de aventura (“M”, Montaña. “T”, Trekking. “R”, Rafting. “B”, Bicicleta.)");
                    Console.WriteLine("“C”, Canopy. “E”, Escalar. “K”, Sky. “S”, Snowboard. “J”, Jumping. “P”, Parapente)");
                    aventura = char.Parse(Console.ReadLine());
                    
                }
                Console.WriteLine("LA CANTIDAD DE PAQUETES VENDIDOS PARA LA VENTURA SELECCIONADA ES : " + CantidadPaquetes);

                Console.WriteLine("EL PAQUETE "+ mayorPaquete +" FUE LA VENTA MAYOR DE ESTA AVENTURA Y FUE DE: " + mayorVenta);

            }
            Console.WriteLine("LA CANTIDAD DE PERSONA QUE VIAJARON ESTA TEMPORADA: " +  CantPersonTotales);

            Console.WriteLine("EL PAQUE CON MENOS HORAS ES : " + minimoPaquete + " Y EL TIPO DE AVENTURA ES: " + minimoAventura);

        }




        void funcionTipoDeAventura(char tipodeaventura){
            switch (tipodeaventura)
            {
                case 'M':
                    Console.WriteLine("Montaña");
                    break;
                case 'T':
                    Console.WriteLine("Trekking");
                    break;
                case 'R':
                    Console.WriteLine("Rafting");
                    break;
                case 'B':
                    Console.WriteLine("Bicicleta");
                    break;
                case 'C':
                    Console.WriteLine("Canopy");
                    break;
                case 'E':
                    Console.WriteLine("Escalar");
                    break;
                case 'K':
                    Console.WriteLine("Sky");
                    break;
                case 'S':
                    Console.WriteLine("Snowboard");
                    break;
                case 'J':
                    Console.WriteLine("Jumplig");
                    break;
                case 'P':
                    Console.WriteLine("Parapente");
                    break;
                default:
                    Console.WriteLine("NO EXISTE ESA AVENTURA: ");
                    break;

            }



        }
    }
}
