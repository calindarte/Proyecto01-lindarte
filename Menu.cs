using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    public class Menu
    {

        public void dibujar()
        {
            EjerciciosBasicos basico = new EjerciciosBasicos();
            EjerciciosIntermedios intermedio = new EjerciciosIntermedios();
            EjerciciosAvanzado avanzado = new EjerciciosAvanzado();



            int OP =0;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(22, 4); Console.Write("M E N U   P R I N C I P A L");
                Console.SetCursorPosition(25, 6); Console.Write("1. EJERCICIOS BASICOS");
                Console.SetCursorPosition(25, 8); Console.Write("2. EJERCICIOS INTERMEDIOS");
                Console.SetCursorPosition(25, 10); Console.Write("3. EJERCICIOS AVANZADOS");
                Console.SetCursorPosition(25, 12); Console.Write("4. SALIR...");
                Console.SetCursorPosition(25, 18); Console.Write("Digite opcion:(   )");
                Console.SetCursorPosition(41, 18); OP = int.Parse(Console.ReadLine());
               
                switch (OP)
                {
                    case 1:
                        Console.Clear();
                        Console.SetCursorPosition(20, 4); Console.Write("EJERCICIOS BASICOS");
                        basico.mostrar01();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.SetCursorPosition(20, 4); Console.Write("EJERCICIOS INTERMEDIOS");
                        intermedio.mostrar02();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.SetCursorPosition(20, 4); Console.Write("EJERCICIOS AVANZADOS");
                        avanzado.mostrar03();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.ReadKey();
                        break;
                    default:
                        Console.SetCursorPosition(60,19); Console.Write("No se reconoce la opcion tecleada");
                        Console.ReadKey();
                        break;

                }
               
            } while (OP != 4);
            
        }
       
    }
}

