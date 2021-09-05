using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using login; 

namespace PARCIAL_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Usuario/Contraseña admin. 
            string usu, usuario = "admin", sn = "s";
            int intento = 3, ingresar = 0, opcion;
            int contra = 123;
            int con;

            Console.WindowWidth = 60;
            Console.WindowHeight = 30;

            Console.WriteLine("*****************************************************************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\tBIENVENID/@");
            Console.ResetColor();
            Console.WriteLine("*****************************************************************************");

            
                do
                {

                    Console.WriteLine(" ");
                    Console.Write("NOMBRE DE USUARIO: ");
                    usu = Console.ReadLine();
                    Console.Write("\nCONTRASEÑA: ");
                    Console.ForegroundColor = ConsoleColor.Black;
                    con = Convert.ToInt32(Console.ReadLine());
                    Console.ResetColor();
                    Console.Clear();



                    if (usu == usuario && con == contra)
                    {
                        ingresar = 1;

                    }
                    else
                    {
                        Console.WriteLine("\n*****************************************************************************");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\tUSUARIO Y/O CONTRASEÑA SON INCORRECTAS");
                        Console.WriteLine("\n\t\t\tINTENTO {0}", intento--);
                        Console.ResetColor();
                        Console.WriteLine("\n*****************************************************************************");



                    }


                    if (intento < 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n*****************************************************************************");
                        Console.WriteLine("\n\t\tHAS SUPERADO EL LIMITE DE INTENTO..");
                        Console.WriteLine("\n*****************************************************************************");
                        Console.ResetColor();
                        break;


                    }


                } while (intento < 3 && ingresar == 0);

            do { 

                if (intento < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t\tNO PUDO INGRESAR EL SISTEMA. ADIOS!!!....");
                    Console.WriteLine("\n*****************************************************************************");
                    break; 
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("*****************************************************************************");
                    Console.WriteLine("\t\t\tBIENVENID/@ ADMIN ");
                    Console.WriteLine("*****************************************************************************");
                    Console.ResetColor();
                    Console.WindowWidth = 60;
                    Console.WindowHeight = 30;
                    Console.WriteLine("\n*****************************************************************************");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\t\tSELECCIONE UNA OPCION.");
                    Console.ResetColor();
                    Console.WriteLine("\n*****************************************************************************");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n1) RESGISTRAR NUEVO USUARIO.");
                    Console.WriteLine("\n2) CREAR ARCHIVO.");
                    Console.WriteLine("\n3) BORRAR ARCHIVO.");
                    Console.WriteLine("\n4) SALIR.");
                    Console.ResetColor();
                    Console.WriteLine("\n*****************************************************************************");
                    Console.Write("INGRESE LA OPCION QUE DESEA REALIZAR: ");
                    opcion = Convert.ToInt32(Console.ReadLine()); 
                    switch (opcion)
                    {
                        case 1:
                            UsodelLogin.usuario();
                            UsodelLogin.L_archivo(); 
                            break;

                        case 2:
                            UsodelLogin.C_archivos(); 
                            break;

                        default:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n*****************************************************************************");
                            Console.WriteLine("\t\tLA OPCION ES ERRONIA!!!");
                            Console.WriteLine("\n*****************************************************************************");
                            Console.ResetColor(); 
                            break; 

                    }
                    
                    Console.WriteLine("\n*****************************************************************************");
                    Console.Write("¿DESEA REGRESAR AL MENU S/N? ");
                    sn = Console.ReadLine(); 
                }
            } while (sn == "s"); 


            Console.ReadKey(); 
        }
    }
}
