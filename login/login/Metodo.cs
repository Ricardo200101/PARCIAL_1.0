using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    public class UsodelLogin

    {
      
        
        public static void usuario()
        {
            int opcion, contraseña, confir, contraseña2;
            string usuario, sn = "s", usuario2;
       

                Console.Clear();
                Console.WriteLine("\n*****************************************************************************");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\t\t\tREGISTRAR USUARIO.");
                Console.ResetColor();
                Console.WriteLine("\n*****************************************************************************");
                Console.Write("\nUSUARIO: ");
                usuario = Console.ReadLine();


                Console.Write("\nCONTRASEÑA: ");
                Console.ForegroundColor = ConsoleColor.Black;
                contraseña = Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();
                Console.WriteLine("\n*****************************************************************************");
                Console.Write("\nCONFIRMAR CONTRASEÑA: ");
                Console.ForegroundColor = ConsoleColor.Black;
                confir = Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();


                if (contraseña != confir)
                {
                    do
                    {
                        Console.WriteLine("\n*****************************************************************************");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nLA CONTRASEÑA NO COINCIDE.");
                        Console.WriteLine("POR FAVOR VUELVA INGRESAR LA CONTRASEÑA.. ");
                        Console.ResetColor();
                        Console.WriteLine("\n*****************************************************************************");
                        Console.Write("\nCONTRASEÑA: ");
                        Console.ForegroundColor = ConsoleColor.Black;
                        contraseña = Convert.ToInt32(Console.ReadLine());
                        Console.ResetColor();
                        Console.WriteLine("\n*****************************************************************************");
                        Console.Write("CONFIRMAR CONTRASEÑA: ");
                        Console.ForegroundColor = ConsoleColor.Black;
                        confir = Convert.ToInt32(Console.ReadLine());
                        Console.ResetColor();
                    } while (contraseña != confir);

                    Console.Clear(); 
                    Console.WriteLine("\n*****************************************************************************");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nUSUARIO CREADO CON EXICTO!!!");
                    Console.WriteLine("\nPRESIONE ENTER PARA CONTINUAR....");
                    Console.ReadKey();
                    Console.ResetColor();
                   


                Console.WriteLine("\n*****************************************************************************");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("¿DESEA INICIAR SESION S/N? ");
                sn = Console.ReadLine();
                Console.ResetColor();
                Console.WriteLine("\n*****************************************************************************");

                if (sn == "s")
                {
                    Console.Clear(); 
                    Console.WriteLine("*****************************************************************************");
                    Console.Write("\nUSUARIO: ");
                    usuario2 = Console.ReadLine();
                    Console.Write("\nCONTRASEÑA: ");
                    Console.ForegroundColor = ConsoleColor.Black;
                    contraseña2 = Convert.ToInt32(Console.ReadLine());
                    Console.ResetColor(); 
                    Console.WriteLine("*****************************************************************************");

                    if (usuario2 == usuario && contraseña2 == contraseña)
                    {
                        Console.Clear();
                        Console.WriteLine("*****************************************************************************");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\tBIENVENID/@ {0}", usuario);
                        Console.ResetColor();
                        Console.WriteLine("*****************************************************************************");

                    }
                    else
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\n*****************************************************************************");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\tUSUARIO Y/O CONTRASEÑA SON INCORRECTAS");
                            Console.WriteLine("\n\t\tPOR FAVOR VUELVA INTENTARLO...");
                            Console.ResetColor();
                            Console.WriteLine("\n*****************************************************************************");
                            Console.Write("\nUSUARIO: ");
                            usuario2 = Console.ReadLine();
                            Console.Write("\nCONTRASEÑA: ");
                            Console.ForegroundColor = ConsoleColor.Black; 
                            contraseña2 = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor(); 
                            Console.WriteLine("*****************************************************************************");

                        } while (usuario != usuario2 && contraseña != contraseña2); 


                    }
                    Console.Clear();
                    Console.WriteLine("*****************************************************************************");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t\t\tBIENVENID/@ {0}", usuario);
                    Console.ResetColor();
                    Console.WriteLine("*****************************************************************************");

                }


            }
            else
                {
                    Console.WriteLine("\n*****************************************************************************");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nUSUARIO CREADO CON EXICTO!!!");
                    Console.WriteLine("\nPRESIONE ENTER PARA CONTINUAR....");
                    Console.ReadKey(); 
                    Console.ResetColor();


                Console.WriteLine("\n*****************************************************************************");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("¿DESEA INICIAR SESION S/N? ");
                sn = Console.ReadLine();
                Console.WriteLine("\n*****************************************************************************");
                Console.ResetColor();

                if (sn == "s")
                {
                    Console.Clear();
                    Console.WriteLine("*****************************************************************************");
                    Console.Write("\nUSUARIO: ");
                    usuario2 = Console.ReadLine();
                    Console.Write("\nCONTRASEÑA: ");
                    Console.ForegroundColor = ConsoleColor.Black; 
                    contraseña2 = Convert.ToInt32(Console.ReadLine());
                    Console.ResetColor(); 
                    Console.WriteLine("*****************************************************************************");

                    if (usuario2 == usuario && contraseña2 == contraseña)
                    {
                        Console.Clear();
                        Console.WriteLine("*****************************************************************************");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\tBIENVENID/@ {0}", usuario);
                        Console.ResetColor();
                        Console.WriteLine("*****************************************************************************");

                    }
                    else
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\n*****************************************************************************");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\tUSUARIO Y/O CONTRASEÑA SON INCORRECTAS");
                            Console.WriteLine("\n\t\tPOR FAVOR VUELVA INTENTARLO...");
                            Console.ResetColor();
                            Console.WriteLine("\n*****************************************************************************");
                            Console.Write("\nUSUARIO: ");
                            usuario2 = Console.ReadLine();
                            Console.Write("\nCONTRASEÑA: ");
                            Console.ForegroundColor = ConsoleColor.Black; 
                            contraseña2 = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor(); 
                            Console.WriteLine("*****************************************************************************");

                        } while (usuario2 != usuario && contraseña2 != contraseña);

                        Console.Clear();
                        Console.WriteLine("*****************************************************************************");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\tBIENVENID/@ {0}", usuario);
                        Console.ResetColor();
                        Console.WriteLine("*****************************************************************************");

                    }



                }

                }

      

            Console.ReadKey();
        }

        public static void C_archivos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine("\nSE HA CREADO EL ARCHIVO CON EXICTO!!!");
            Console.ResetColor(); 
        }

        public static void L_archivo()
        {
            Console.WriteLine("HOLA");
        }
     

    }
}
