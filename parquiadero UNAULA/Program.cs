using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parquiadero_UNAULA
{
    class Program
    {
        static void Main(string[] args)
        {
            int respuesta;
            Console.WriteLine("menu de opciones \n" +
                "\n 1 _registrar vehiculo" +
                "\n 2 registrar moto" +
                "\n 3 mostrar lista de vehiculos " +
                "\n 4 listar las celdas disponibles para carros y motos " +
                "\n 5 las ganancias del dia" +
                "\n 6 terminar \n");
            respuesta = int.Parse(Console.ReadLine());


            Parquiadero mono = new Parquiadero();
           
           
            
            
            
            mono.registrarvehiculo(1);
            mono.registrarvehiculo(0);

            mono.listarvehiculos();
            mono.listardisponibles();
            Console.ReadKey();
        }
        
    }
}
