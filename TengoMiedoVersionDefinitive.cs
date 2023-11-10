using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRecuperacion_SLE
{
    public class TengoMiedoVersionDefinitive
    {
        public void PrimerEjercicio()
        {
            //PRIMER EJERCICIO DE LAS TABLAS
            int[,] numeros =
            {
            {500,3000,100,400 },
            {1000,150,200,500 },
            {250,1800,2900,300 },
            {400,130,90,2400 },
            {60,20,4000,3600 },
        };

            for (int vendedores = 0; vendedores < 4; vendedores++)
            {
                int gananciaVendedor = 0;
                for (int producto = 0; producto < 5; producto++)
                {
                    gananciaVendedor += numeros[producto,vendedores];
                }

                Console.WriteLine($"El vendedor {vendedores+1} obtuvo una ganancia final de {gananciaVendedor}");
            }

            for (int producto = 0; producto < 5; producto++)
            {
                int gananciaProducto = 0;
                for (int vendedores = 0; vendedores < 4; vendedores++)
                {
                    gananciaProducto += numeros[producto, vendedores];
                }

                Console.WriteLine($"El producto {producto+1} se vendio en total {gananciaProducto}");
            }




            //STRING FECHA = TRY.PARSE Y NO SE QUE MAS


        }


        public void SegundoEjercicio()
        {
            string[] curp = new string[18];


            for (int i = 0; i < curp.Length; i++)
            {
                Console.WriteLine("Ingresa tu curp, OJO: LETRA POR LETRA");
                curp[i] = Console.ReadLine();
            }


            if (curp[10] == "h" || curp[10] == "H")
            {
                Console.WriteLine("Su sexo es masculino");
            }
            else if (curp[10] == "m" || curp[10] == "M")
            {
                Console.WriteLine("Su sexo es femenino");
            }
            else
            {
                Console.WriteLine("NO EXISTE ESE GENERO :D!");
            }

            string aber1 = curp[4];
            string aber2 = curp[5];
            string aber3 = curp[6];
            string aber4 = curp[7];
            string aber5 = curp[8];
            string aber6 = curp[9];

            string aio = curp[4] + curp[5];

            
            Console.WriteLine(aio);
            

            //PEDIENTE LA FECHA 



        }




        public void TercerEjercicio()
        {
            int[] numeros= new int[100];
            Random aleatorio= new Random();

            //AÑADIENDO VALORES ALEATORIOS

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = aleatorio.Next(0,100);
            }

            //IMPRIMIR MATRIZ DESORNEDADA
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Matriz hecho un demaiz " + numeros[i]);
            }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");


            //FORMA DESCEDENTE 

            /*
             * LE DOY DE LAS 2 MANERAS POR QUE EN ESTE MOMENTO DE HACER EL EXAMEN MI CEREBRO SE BUGIO
             * Y NO SABE IDENTIFICAR CUAL ES EL ASCEDENTE Y CUAL NO D:
            for (int i = 0; i < numeros.Length-1; i++)
            {
                for (int j = i+1; j < numeros.Length; j++)
                {
                    if (numeros[i] > numeros[j])
                    {
                        int temporal= numeros[i];
                        numeros[i]= numeros[j];
                        numeros[j]= temporal;




                    }




                }
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("matriz ordenada" + numeros[i]);
            }
            */
            //FORMA DESCENDENTE 
            
            for (int i = 0; i < numeros.Length - 1; i++)
            {
                for (int j = i + 1; j < numeros.Length; j++)
                {
                    if (numeros[i] < numeros[j])
                    {
                        int temporal = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = temporal;




                    }




                }
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("matriz ordenada version1  " + numeros[i]);
            }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
            //BUSQUEDA LINEAL ESPECIFICAMENTE BUSCANDO EL NUMERO 75
            int buscarNumero = 75;
            bool noai=false;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == buscarNumero)
                {
                    Console.WriteLine("El numero esta en la posicion " + i);
                    noai = true;
                }
                
                
            }
            
            if (noai == false)
            {
                Console.WriteLine("El numero no se encontro karnal ");
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");

            //DEJANDO AL USUARIO AÑADIR EL NUMERO A BUSCAR
            Console.WriteLine("Ingresa el numero que quieres buscar ");
            int buscarUsuario= Convert.ToInt32(Console.ReadLine());
            bool noai2 = false;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == buscarUsuario)
                {
                    Console.WriteLine("El numero esta en la posicion " + i);
                    noai2 = true;
                }


            }

            if (noai2 == false)
            {
                Console.WriteLine("El numero no se encontro karnal ");
            }
        }





    }
}
