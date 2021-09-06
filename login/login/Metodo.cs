using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

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
            string path = @"D:\Aprendizajes\Victor_Alvarez.txt";
            string path2 = @"D:\Aprendizajes\Douglas_Perez.txt";
            string path3 = @"D:\Aprendizajes\Saul_Zuniga.txt";
            string path4 = @"D:\Aprendizajes\Carol_Perez.txt";

            Console.WriteLine("\nINGRESA LA OPCION QUE DESEA: ");
            int opcion = Convert.ToInt32(Console.ReadLine()); 
            switch (opcion)
            {
                case 1:
                    UsodelLogin.usuario();
                    Console.WriteLine("\n1)Leer un archivo.");
                    Console.WriteLine("\n2) Salir.");
                    int respuetausuario = int.Parse(Console.ReadLine());
                    switch (respuetausuario)
                    {
                        case 1:
                            using (StreamWriter sw1 = File.AppendText(path))
                            {
                                sw1.WriteLine("Aprendizajes y dificultades");
                                sw1.WriteLine("En mi persona, este primer computo he adquirido mucho aprendizaje, me gusta mucho como la ingeniera trata la manera que todo quede claro y dedica el tiempo para que nosotros como estudiantes, adquiramos los conocimiento necesario para realizar las tarea sin complicaciones de cada semana, tanto la clase teórica y practica van de la mano y es necesario asistir a la dos para resolver cualquier duda en el momento,  en mi caso he tenido profesores de programación y es la primera ingeniera que me gusta como enseña a programa, tiene el don de enseñar y para que nosotros como estudiantes aprendamos.");
                                sw1.Close();
                            }
                            using (StreamWriter sw2 = File.AppendText(path2))
                            {
                                sw2.WriteLine("Aprendizaje y dificultades");
                                sw2.WriteLine("En esta materia se me dificulto un poco hacer las tareas pero buscando en YouTube y repasando las clases pude entender poco a poco como realizar las actividades y con consejos de mis compañeros pude enteder a un mejor ");
                                sw2.Close();
                            }
                            using (StreamWriter sw3 = File.AppendText(path3))
                            {
                                sw3.WriteLine("Aprendizaje y dificultades");
                                sw3.WriteLine("En el computo pude aprender como traspasar la lógica de programación básica, como lo son las variables, los tipos de ciclos, los arreglos y demás, a un nuevo lenguaje de programación como lo es C#. además de eso pude comprender como funciona el ide de Visual Studio y pude conocer algunos elementos que son propios de el lenguaje de programación C#. En el computo en su gran mayoría no se me presentaron dificultades hasta que se estudió el último tema que era el de manejo de archivos; me pareció algo complicado de entender ya que requiere mucha concentración y el haber asimilado y tener la capacidad de poner en practica muchas otras cosas previas. Lo que hice para solucionar esto claro, fue investigar por otra fuente como hacerlo y como poder hacerlo y repasar cosas previas para poder asimilarlo. ");
                                sw3.Close();
                            }
                            Console.WriteLine("Que archivo desea observar ");
                            Console.WriteLine("1. Victor_Alvarez.txt ");
                            Console.WriteLine("2. Douglas_Perez.txt");
                            Console.WriteLine("3. Saul_Zuniga.txt ");
                            Console.WriteLine("4. Carol_Perez");
                            int answestxt = int.Parse(Console.ReadLine());
                            switch (answestxt)
                            {
                                case 1:
                                    string content = File.ReadAllText(path);
                                    Console.WriteLine(content);
                                    break;
                                case 2:
                                    string content2 = File.ReadAllText(path2);
                                    Console.WriteLine(content2);
                                    break;
                                case 3:
                                    string content3 = File.ReadAllText(path3);
                                    Console.WriteLine(content3);
                                    break;
                                case 4:
                                    string content4 = File.ReadAllText(path4);
                                    Console.WriteLine(content4);
                                    break;
                            }
                            break;
                    }

                    break;


                case 2:

                    using (StreamWriter sw1 = File.AppendText(path))
                    {
                        sw1.WriteLine("Aprendizajes y dificultades");
                        sw1.WriteLine("En mi persona, este primer computo he adquirido mucho aprendizaje, me gusta mucho como la ingeniera trata la manera que todo quede claro y dedica el tiempo para que nosotros como estudiantes, adquiramos los conocimiento necesario para realizar las tarea sin complicaciones de cada semana, tanto la clase teórica y practica van de la mano y es necesario asistir a la dos para resolver cualquier duda en el momento,  en mi caso he tenido profesores de programación y es la primera ingeniera que me gusta como enseña a programa, tiene el don de enseñar y para que nosotros como estudiantes aprendamos.");
                        sw1.Close();
                    }
                    using (StreamWriter sw2 = File.AppendText(path2))
                    {
                        sw2.WriteLine("Aprendizaje y dificultades");
                        sw2.WriteLine("En esta materia se me dificulto un poco hacer las tareas pero buscando en YouTube y repasando las clases pude entender poco a poco como realizar las actividades y con consejos de mis compañeros pude enteder a un mejor ");
                        sw2.Close();
                    }
                    using (StreamWriter sw3 = File.AppendText(path3))
                    {
                        sw3.WriteLine("Aprendizaje y dificultades");
                        sw3.WriteLine("En el computo pude aprender como traspasar la lógica de programación básica, como lo son las variables, los tipos de ciclos, los arreglos y demás, a un nuevo lenguaje de programación como lo es C#. además de eso pude comprender como funciona el ide de Visual Studio y pude conocer algunos elementos que son propios de el lenguaje de programación C#. En el computo en su gran mayoría no se me presentaron dificultades hasta que se estudió el último tema que era el de manejo de archivos; me pareció algo complicado de entender ya que requiere mucha concentración y el haber asimilado y tener la capacidad de poner en practica muchas otras cosas previas. Lo que hice para solucionar esto claro, fue investigar por otra fuente como hacerlo y como poder hacerlo y repasar cosas previas para poder asimilarlo. ");
                        sw3.Close();
                    }

                    UsodelLogin.C_archivos();
                    break;
                case 3:
                    Console.WriteLine("Cual archivo desea eliminar");
                    Console.WriteLine("1. Victor_Alvarez.txt");
                    Console.WriteLine("2. Douglas_Perez.txt");
                    Console.WriteLine("3. Saul Zuniga.txt");
                    Console.WriteLine("4. Carol_Perez");
                    int answer9 = int.Parse(Console.ReadLine());
                    switch (1)
                    {
                        case 1:
                            File.Delete(@"D:\Aprendizajes\Victor_Alvarez.txt");
                            break;
                        case 2:
                            File.Delete(@"D:\Aprendizajes\Douglas_Perez.txt");
                            break;
                        case 3:
                            File.Delete(@"D:\Aprendizajes\Saul_Zuniga.txt");
                    }
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
        }
     

    }
}
