using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    public class EjerciciosBasicos
    {
        #region Basico01
        public void eje1()
        {
            Console.SetCursorPosition(10, 6); Console.WriteLine("1.Crea 3 variables numericas con el valor que tu quieras y en otra variable númerica");

            Console.SetCursorPosition(10, 7); Console.WriteLine("   guarda el valor de la suma de las 3 anteriores.\n");

            int num1 = 18, num2 = 10, num3 = 8, resultado;
            resultado = num1 + num2 + num3;
            Console.SetCursorPosition(20, 9); Console.WriteLine("Primer numero: " + num1 + " Segundo numero: " + num2 + " Tercer numero: " + num3);
            Console.SetCursorPosition(20, 11); Console.WriteLine("La Suma de todos los numeros es: " + resultado);
        }
        public void eje2()
        {
            Console.SetCursorPosition(10, 6); Console.WriteLine("2.Se pide por consola el nombre de la persona y el nombre");
            Console.SetCursorPosition(10, 7); Console.WriteLine("de una ciudad y muestra por pantalla, el siguiente mensaje");

            string name, city;

            Console.SetCursorPosition(10, 10); Console.Write("Estimado usuario, ingrese su nombre por favor : ");
            name = Console.ReadLine();

            Console.SetCursorPosition(10, 12); Console.Write("Ahora ingrese la ciudad en donde reside : ");
            city = Console.ReadLine();

            Console.SetCursorPosition(10, 14); Console.WriteLine("Hola " + name + " Bienvenido a " + city);
 
        }
        public void eje3()
        {
        Console.SetCursorPosition(10,6); Console.WriteLine("3.Pide el nombre y la edad al usuario y los imprime por pantalla");
        Console.SetCursorPosition(10, 8);Console.Write("Cual es tu nombre: ");
            string name = Console.ReadLine();
        Console.SetCursorPosition(10, 10); Console.Write("Cual es tu edad: ");
            int years = int.Parse(Console.ReadLine());
        Console.SetCursorPosition(10, 12); Console.WriteLine($"Te llamas {name} y tienes {years} años");
        
        }
        public void eje4()
        {
            Console.SetCursorPosition(10, 6); Console.WriteLine("4.Pide el nombre de la semana al usuario y dice si es fin de semana o no");
            Console.SetCursorPosition(10, 7); Console.WriteLine ("y en caso de error lo indica");
            Console.SetCursorPosition(10, 9); Console.Write("Escribe un dia de la semana: ");
            string dia = Console.ReadLine();

            if (dia == "sabado" || dia == "domingo")
            {
                Console.SetCursorPosition(10, 11); Console.WriteLine("Es fin de semana");
            }

            else
            {
                Console.SetCursorPosition(10, 11); Console.WriteLine(" el dia " + dia + " no es fin de semana");
            }
       
       
        }
        public void eje5()
        {
            Console.SetCursorPosition(10, 6); Console.WriteLine("5.Recorre los numeros del 1 al 100");
            int i = 1;
            Console.SetCursorPosition(10, 8); Console.WriteLine("los numeros del 1 al 100");
            while (i <= 100)
            {
                Console.Write(i + "  ");
                i++;
            }

            
        }
        #endregion

       
        public void mostrar01()
        {
            Menu menu = new Menu();
            int OP;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(25, 6); Console.Write("1. Ejercicio 01");
                Console.SetCursorPosition(25, 7); Console.Write("2. Ejercicio 02");
                Console.SetCursorPosition(25, 8); Console.Write("3. Ejercicio 03");
                Console.SetCursorPosition(25, 9); Console.Write("4. Ejercicio 04");
                Console.SetCursorPosition(25, 10);Console.Write("5. Ejercicio 05");
                Console.SetCursorPosition(25, 11);Console.Write("6. Ir a inicio");
                Console.SetCursorPosition(25, 18);Console.Write("Digite opcion:(   )");
                Console.SetCursorPosition(41, 18); OP = int.Parse(Console.ReadLine());
                switch (OP)
                {
                    case 1:
                        Console.Clear();
                        Console.SetCursorPosition(20, 4); Console.Write("EJERCICIO 01");
                        eje1();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.SetCursorPosition(20, 4); Console.Write("EJERCICIOS 02");
                        eje2();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.SetCursorPosition(20, 4); Console.Write("EJERCICIOS 03");
                        eje3();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.SetCursorPosition(20, 4); Console.Write("EJERCICIOS 04");
                        eje4(); 
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.SetCursorPosition(20, 4); Console.Write("EJERCICIOS 05");
                        eje5();
                        Console.ReadKey();
                        break;
                    case 6:
                        menu.dibujar();
                        Console.ReadKey();
                        break;
                    default:
                        Console.SetCursorPosition(50, 18); Console.Write("No se reconoce la opcion tecleada");
                        Console.ReadKey();
                        break;

                }

            } while (OP != 6);
        }

    }
}