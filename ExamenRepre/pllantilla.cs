using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ExamenRepre
{
    internal class pllantilla


    {

        private int vuelto { get; set; }
        int cantidad1;
        int dinero1;
        int x;
        int precio1;

        int[] y = new int[4];
        private int dinero { get; set; }    
        private string[] productos = new string[4] { "chiveria", "gaseosa", "agua", "chibles" };
        private int[] cantidad = new int[4] {5, 5, 5, 5 };
        private int[] precio = new int[4] { 40, 30, 20, 10 };
        int[] datos1 = new int[4];
        public pllantilla()
        {

        }
       
        
        public void datos()
        {
            
            Console.WriteLine("------- BIENVENIDO A LA DISPENSADORA -------");
            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine("   PRODUCTO   " + "   |" + productos[i] + "   |" + "   PRECIO   " + "   |$" + precio[i] + "   CODIGO  # " + (i + 1) +"\n --------------------------------------");
            }
            

        }
        public void cambio()
        {
            int[] datos = new int[4];
            
            Console.WriteLine(" seleccione el codigo del producto a comprar");
             cantidad1 = int.Parse(Console.ReadLine());
            
          
            switch (cantidad1)
            {
                case 1: precio1 = 40;
                    Console.WriteLine(" de cuanto es el billete de tu compra");
                    dinero1 = int.Parse(Console.ReadLine());
                    if (dinero1 >= precio1)
                    {
                        datos1[0] = dinero1 - precio1;
                        Console.WriteLine("Cuantas unnidades desea comprar");
                     x = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine(" la cantidad de dinero que ingresastes esd menos que le precio del producto");
                        Console.WriteLine("--- PORFAVOR INGRESE UN BILLETE MAYOR AL PRECIO DEL PRODUCTO --- ") ;

                    }
                    break;
                case 2:
                    precio1 = 30;
                    Console.WriteLine(" de cuanto es el billete de tu compra");
                    dinero1 = int.Parse(Console.ReadLine());
                    if (dinero1 >= precio1)
                    {
                        datos1[1] = dinero1 - precio1;
                        Console.WriteLine("Cuantas unnidades desea comprar");
                        x = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine(" la cantidad de dinero que ingresastes esd menos que le precio del producto");
                    }
                    break;
                case 3:
                    precio1 = 20;
                    Console.WriteLine(" de cuanto es el billete de tu compra");
                    dinero1 = int.Parse(Console.ReadLine());
                    if (dinero1 >= precio1)
                    {
                        datos1[2] = dinero1 - precio1;
                        Console.WriteLine("Cuantas unnidades desea comprar");
                        x = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine(" la cantidad de dinero que ingresastes esd menos que le precio del producto");
                    }
                    break;
                case 4:
                    precio1 = 10;
                    Console.WriteLine(" de cuanto es el billete de tu compra");
                    dinero1 = int.Parse(Console.ReadLine());
                    if (dinero1 >= precio1)
                    {
                        datos1[3] = dinero1 - precio1;
                        Console.WriteLine("Cuantas unnidades desea comprar");
                        x = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine(" la cantidad de dinero que ingresastes esd menos que le precio del producto");
                    }
                    break;
                    default:
                    Console.WriteLine(" la opcion marcada no existe -- VUELVE A SELECCIONAR UNA OPCION VALIDA");
                    break;


            }
            

            
        }
        public void CantidadDeUnidades()
        {
           
            switch (cantidad1)
            {
                case 1:
                    if (x <= cantidad[0])
                    {
                      y[0] =  cantidad[0] - x;
                       
                    }
                    else
                    {
                        Console.WriteLine(" ya no hay unidades de ese producto");
                        Console.WriteLine("---- PORFAVOR COMPRE OTRO PRODUCTO");

                    }
                    break;
                case 2:
                    if (x <= cantidad[1])
                    {

                        y[1] = cantidad[1] - x;



                    }
                    else
                    {
                        Console.WriteLine(" ya no hay unidades de producto");
                        Console.WriteLine("---- PORFAVOR COMPRE OTRO PRODUCTO");
                    }
                    break;
                case 3:
                    if (x <= cantidad[2])
                    {
                        y[2] = cantidad[2] - x;
                    }
                    else
                    {
                        Console.WriteLine(" ya no hay unidades de producto");
                        Console.WriteLine("---- PORFAVOR COMPRE OTRO PRODUCTO");
                    }
                    break;
                case 4:
                    if (x <= cantidad[3])
                    {
                        y[3] = cantidad[3] - x; 
                       
                    }
                    else
                    {
                        Console.WriteLine(" ya no hay unidades de producto");
                        Console.WriteLine("---- PORFAVOR COMPRE OTRO PRODUCTO");
                    }
                    break;

            }
        }
       public void imprimir()
        {
            switch (cantidad1)
            {

                case 1:
                    if (dinero1 >= precio1 && x <= cantidad[0])
                    {
                        Console.WriteLine("--------------- TU COMPRA ESTA SIENDO PROCESADA -----------------");
                        Thread.Sleep(3000);
                        Console.WriteLine("------- TU COMPRA A SIDO EXITOSA ---------");
                        Console.WriteLine("\n INFORMACION DE TU COMPRA");
                        Console.WriteLine("PRODUCTO " + productos[0] + " PRECIO " + precio[0] + " CODIGO " + 1 + " VUELTO " + datos1[0] + " unidades Compradas " + x);
                        Console.WriteLine("UNIDADES RESTANTES " + y[0]);
                        Console.WriteLine("\n ...GRACIAS POR SU COMPRA.... VUELVA PRONTO");
                        
                    }else
                    {
                        Console.WriteLine("no se puede comprar porque no hay unidades de ese producto");
                    }
                    break;
                case 2:
                    if (dinero1 >= precio1 && x <= cantidad[1])
                    {
                        Console.WriteLine("--------------- TU COMPRA ESTA SIENDO PROCESADA -----------------");
                        Thread.Sleep(3000);
                        Console.WriteLine("------- TU COMPRA A SIDO EXITOSA ---------");
                        Console.WriteLine("\n INFORMACION DE TU COMPRA");
                        Console.WriteLine("PRODUCTO " + productos[1] + " PRECIO " + precio[1] + " CODIGO " + 2 + " VUELTO " + datos1[1] + " unidades Compradas " + x);
                        Console.WriteLine("UNIDADES RESTANTES " + y[1]);
                        Console.WriteLine("\n ...GRACIAS POR SU COMPRA.... VUELVA PRONTO");
                    }
                    else
                    {
                        Console.WriteLine("no se puede comprar porque no hay unidades de ese producto");
                    }
                    break;
                case 3:
                    if (dinero1 >= precio1 && x <= cantidad[2])
                    {
                        Console.WriteLine("--------------- TU COMPRA ESTA SIENDO PROCESADA -----------------");
                        Thread.Sleep(3000);
                        Console.WriteLine("------- TU COMPRA A SIDO EXITOSA ---------");
                        Console.WriteLine("\n INFORMACION DE TU COMPRA");
                        Console.WriteLine("PRODUCTO " + productos[2] + " PRECIO " + precio[2] + " CODIGO " + 3 + " VUELTO " + datos1[2] + " unidades Compradas " + x);
                        Console.WriteLine("UNIDADES RESTANTES " + y[2]);
                        Console.WriteLine("\n ...GRACIAS POR SU COMPRA.... VUELVA PRONTO");
                    }
                    else
                    {
                        Console.WriteLine("no se puede comprar porque no hay unidades de ese producto");
                    }
                    break;
                case 4:
                    if (dinero1 >= precio1 && x <= cantidad[3])
                    {
                        Console.WriteLine("--------------- TU COMPRA ESTA SIENDO PROCESADA -----------------");
                        Thread.Sleep(3000);
                        Console.WriteLine("------- TU COMPRA A SIDO EXITOSA ---------");
                        Console.WriteLine("\n INFORMACION DE TU COMPRA");
                        Console.WriteLine("PRODUCTO " + productos[3] + " PRECIO " + precio[3] + " CODIGO " + 4 + " VUELTO " + datos1[3] + " unidades Compradas " + x);
                        Console.WriteLine("UNIDADES RESTANTES " + y[3]);
                        Console.WriteLine("\n ...GRACIAS POR SU COMPRA.... VUELVA PRONTO");
                    }
                    else
                    {
                        Console.WriteLine("no se puede comprar porque no hay unidades de ese producto");
                    }
                    break;


            }

        }








    }
}
