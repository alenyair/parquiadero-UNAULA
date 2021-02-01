using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parquiadero_UNAULA
{
    class Parquiadero
    {
        int ganacias;
        celda[] motos = new celda[10];//aqui tya existe el vector de 10 pero no las celdas en si
        celda[] carros = new celda[10];//aqui tya existe el vector de 10 pero no las celdas en si

        public Parquiadero()
        {
            ganacias = 0;
            for(int i=0; i<10; i++)
            {
                motos[i] = new celda();
                carros[i] = new celda();
            }
        }

        public int buscardisponible(int tipo)
        {
            int resultado =-1;
            if (tipo == 0)
            {
                for(int i=0; i < motos.Length; i++)
                {
                    if (motos[i].elestado == "vacia") { resultado = i; break; }
                }
            }
            else
            {
                for (int i = 0; i < carros.Length; i++)
                {
                    if (carros[i].elestado == "vacia") { resultado = i; break; }
                }
            }
            return resultado;
        }

        public void  registrarvehiculo(int tipo)
        {
            int disponibilidad;
            string plaka;
            disponibilidad = buscardisponible(tipo);

            if(disponibilidad== -1)
            {
                
                Console.WriteLine("\n **********************************");
                Console.WriteLine("***********NO HAY CUPO*************");
                Console.WriteLine("**********************************");
            }
            else
            {
                if (tipo == 0)
                {
                    Console.WriteLine("ingresa la placa de la moto");
                    plaka = Console.ReadLine();
                    motos[disponibilidad].ocuparcelda(plaka);
                }
                else
                {
                    Console.WriteLine("ingresa la placa del carro");
                    plaka = Console.ReadLine();
                    carros[disponibilidad].ocuparcelda(plaka);
                }
            }
        }

        public void listarvehiculos()
        {
           
            Console.WriteLine("\n **********LISTADO DE VEHICULOS************************");
            Console.WriteLine("***********MOTOS*************");
            for(int i=0;i<motos.Length;i++)
            {
                if (motos[i].elestado == "ocupada") { Console.WriteLine(motos[i].laplaca); }
            }
            Console.WriteLine("");
            Console.WriteLine("************CARROS**********************");
            for (int i = 0; i < carros.Length; i++)
            {
                if (carros[i].elestado == "ocupada") { Console.WriteLine(motos[i].laplaca); }
            }
            Console.WriteLine("*****************x*****************\n");
        }


        public void listardisponibles()
        {

            Console.WriteLine("\n **********CELDAS DISPINIBLES*****************");
            Console.WriteLine("*******************MOTOS****************");
            for (int i = 0; i < motos.Length; i++)
            {
                if (motos[i].elestado == "vacia") { Console.WriteLine("celda "+(i+1)); }
            }
            Console.WriteLine("");
            Console.WriteLine("************CARROS**********************");
            for (int i = 0; i < carros.Length; i++)
            {
                if (carros[i].elestado == "vacia") { Console.WriteLine("celda " +(i+1)); }
            }
            Console.WriteLine("**********************************\n");
        }





    }
}
