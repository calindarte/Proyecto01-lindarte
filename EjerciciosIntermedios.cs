using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    public class EjerciciosIntermedios
    {
        #region intermedios
        public void eje01()
        {
            Console.SetCursorPosition(10, 6); Console.WriteLine("1.Pide dos numeros por teclado y dice cual es el mayor");
            Console.SetCursorPosition(10,8); Console.Write("Digite el primer numero:");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(10,10); Console.Write("Digite el segundo numero:");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            if (Num1 == Num2)
            {
                Console.SetCursorPosition(10, 12); Console.WriteLine("Los numeros son iguales");
            }
            else
            {
                if (Num1 > Num2)
                {
                    Console.SetCursorPosition(10,13); Console.WriteLine("El numero mayor es el " + Num1);
                }
                else
                {
                    Console.SetCursorPosition(10,13); Console.WriteLine("El numero mayor es el " + Num2);
                }
            }

         }
        public void eje02()
        {
            Console.SetCursorPosition(10, 6); Console.WriteLine("Pide al usuario el precio de un producto(valor positivo) y la forma de pago(efectivo o tarjeta");
            Console.SetCursorPosition(10, 7); Console.WriteLine("si la forma de pago es mediante tarjeta, pide el numero de cuenta(inventado)");
       

            Console.SetCursorPosition(10, 9); Console.Write("Escribe el precio del producto: $");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.SetCursorPosition(10, 11); Console.Write("Elige la forma de pago (tarjeta o efectivo): ");
            string forma = (Console.ReadLine()).ToLower();

            if (forma.Equals("tarjeta"))
            {
                Console.SetCursorPosition(10, 13); Console.Write("Introduce el numero de tarjeta: ");
                int numero_cuenta = Convert.ToInt32(Console.ReadLine());
                Console.SetCursorPosition(10, 15); Console.Write("El producto con precio $" + precio + " se ha pagado " + "con el numero de tarjeta " + numero_cuenta);

            }
            else if (forma.Equals("efectivo"))
            {
                Console.SetCursorPosition(10, 13); Console.Write("El producto con precio $" + precio + " se ha pagado");
            }
            else
            {
                Console.SetCursorPosition(10, 14); Console.Write("La forma de pago no es correcta");
            }
        }
        public void eje03()
        {
            int numero;
            bool hay_negativos = false;
            int Fila = 8;
            Console.SetCursorPosition(10, 6); Console.WriteLine("3. Pide 10 numeros al usuario e indica si hay algun negativo");
            for (int i = 1; i <= 10; i++)
            {
            Console.SetCursorPosition(10, Fila); Console.Write(i+"."+"Digite un numero: ");
                numero = int.Parse(Console.ReadLine());
                if (numero < 0)
                {
                  hay_negativos = true;
                }
                Fila++;

            }
            if (hay_negativos == true)
            {
                Console.SetCursorPosition(10, 20); Console.WriteLine("si existe al menos un numero negativo");
            }
            else
            {
                Console.SetCursorPosition(10, 20); Console.WriteLine("No existe ningun numero negativo");
            }
        }
        public void eje04()
        {
            int numero;
            Console.SetCursorPosition(10, 6); Console.WriteLine("4.Determina si un numero es multiplo de 10");
            Console.SetCursorPosition(10, 8); Console.Write("Digite un numero: ");
            numero = int.Parse(Console.ReadLine());
            if (numero % 10 == 0)
            {
                Console.SetCursorPosition(10, 10); Console.WriteLine("El numero " + numero + " es multiplo de 10");

            }
            else
            {
                Console.SetCursorPosition(10, 10); Console.WriteLine("El numero no es multiplo de 10");
            }
        }
        public void eje05()
        {
            Console.SetCursorPosition(10, 6); Console.WriteLine("recorre los numeros de dos en dos");
            int Fila = 10;

            for (int i = 1; i <= 100; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.SetCursorPosition(10, Fila); Console.Write(i + "  ");
                    Fila++;
                }
            }
        }

        #endregion
        public void mostrar02()
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
                Console.SetCursorPosition(25, 10); Console.Write("5. Ejercicio 05");
                Console.SetCursorPosition(25, 11); Console.Write("6. Ir a inicio");
                Console.SetCursorPosition(25, 18); Console.Write("Digite opcion:(   )");
                Console.SetCursorPosition(41, 18); OP = int.Parse(Console.ReadLine());
                switch (OP)
                {
                    case 1:
                        Console.Clear();
                        Console.SetCursorPosition(20, 4); Console.Write("EJERCICIO 01");
                        eje01();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.SetCursorPosition(20, 4); Console.Write("EJERCICIOS 02");
                        eje02();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.SetCursorPosition(20, 4); Console.Write("EJERCICIOS 03");
                        eje03();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.SetCursorPosition(20, 4); Console.Write("EJERCICIOS 04");
                        eje04();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.SetCursorPosition(20, 4); Console.Write("EJERCICIOS 05");
                        eje05();
                        Console.ReadKey();
                        break;
                    case 6:
                        menu.dibujar();
                        Console.ReadKey();
                        break;
                    default:
                        Console.SetCursorPosition(20, 10); Console.Write("No se reconoce la opcion tecleada");
                        break;

                }

            } while (OP != 6);
        }

    }
}
