using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    public class EjerciciosAvanzado
    {
        #region Avanzado
        public void eje01()
        {
            int[] arreglo = new int[10];
            bool creciente = true;
            int Fila = 11;
            int numero, sitio_num = 0, j = 0;

            do
            {
                Console.Clear();
                Console.SetCursorPosition(10, 6); Console.WriteLine("1.lee 5 elementos numericos de forma creciente, estos se guardan en una tabla tamaño 10.");
                Console.SetCursorPosition(10, 7); Console.WriteLine("luego lee un numero N y lo inserta en el lugar adecuado para que la tabla continue ordenada");
                Console.SetCursorPosition(10, 9); Console.WriteLine("llenar el arreglo");
                for (int i = 0; i < 5; i++)
                {

                    Console.SetCursorPosition(10, Fila); Console.Write((i + 1) + ".Digite un numero: ");
                    arreglo[i] = int.Parse(Console.ReadLine());
                    Fila++;
                }

                for (int i = 0; i < 4; i++)
                {
                    if (arreglo[i] < arreglo[i + 1])
                    {
                        creciente = true;
                    }
                    if (arreglo[i] > arreglo[i + 1])
                    {
                        creciente = false;
                        break;
                    }
                }
                if (creciente == false)
                {
                    Console.SetCursorPosition(10, 18); Console.WriteLine("El arreglo no esta ordenada en forma creciente, vuelva a digitarlo");
                    Console.ReadKey();
                }
            } while (creciente == false);
            Console.SetCursorPosition(10, 18); Console.Write("Digite un elemento a insertar: ");
            numero = int.Parse(Console.ReadLine());

            while (arreglo[j] < numero && j < 5)
            {
                sitio_num++;
                j++;
            }
            for (int i = 4; i >= sitio_num; i--)
            {
                arreglo[i + 1] = arreglo[i];
            }

            arreglo[sitio_num] = numero;
            Console.SetCursorPosition(10, 21); Console.Write("el arreglo queda: ");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(arreglo[i] + " - ");
            }
            Console.WriteLine();
        }
        public void eje02()
        {
           int numero;
            Console.SetCursorPosition(10, 6); Console.WriteLine("2. Muestra numeros Pares e Impares\n");
            Console.SetCursorPosition(10, 8); Console.Write("Digite un numero: ");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {

                if (numero % 2 == 0)
                {
                    Console.SetCursorPosition(10, 10); Console.WriteLine("El numero " + numero + " es PAR");
                    break;

                }
                else
                {
                    Console.SetCursorPosition(10, 10); Console.WriteLine("El numero " + numero + " es IMPAR");
                    break;
                }

            }


        }
        public void eje03()
        {
            int n1, n2, n3;
            Console.SetCursorPosition(10, 6); Console.Write("3.Ordena 3 numeros de mayor a menor");
            Console.SetCursorPosition(10, 8); Console.Write("Digite un numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(10, 10); Console.Write("Digite un numero: ");
            n2 = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(10, 12); Console.Write("Digite un numero: ");
            n3 = int.Parse(Console.ReadLine());

            if ((n1 > n2) && (n2 > n3))
            {
                Console.SetCursorPosition(10, 15); Console.WriteLine("Orden: " + n1 + " - " + n2 + " - " + n3);
            }
            else if ((n1 > n3) && (n3 > n2))
            {
                Console.SetCursorPosition(10, 15); Console.WriteLine("Orden: " + n1 + " - " + n3 + " - " + n2);
            }
            else if ((n2 > n1) && (n1 > n3))
            {
                Console.SetCursorPosition(10, 15); Console.WriteLine("Orden: " + n2 + " - " + n1 + " - " + n3);
            }
            else if ((n2 > n3) && (n3 > n1))
            {
                Console.SetCursorPosition(10, 15); Console.WriteLine("Orden: " + n2 + " - " + n3 + " - " + n1);
            }
            else if ((n3 > n1) && (n1 > n2))
            {
                Console.SetCursorPosition(10, 15); Console.WriteLine("Orden: " + n3 + " - " + n1 + " - " + n2);
            }
            else
            {
                Console.SetCursorPosition(10, 15); Console.WriteLine("Orden: " + n3 + " - " + n2 + " - " + n1);
            }
        }
        public void eje04()
        {
            int nFilas, nCol, sumaFilas, sumaCol;
            Console.SetCursorPosition(10, 6);Console.WriteLine("4.Suma de cada fila y columna de una matriz");
            Console.Write("\nDigite el numero de Filas: ");
            nFilas = int.Parse(Console.ReadLine());
            Console.Write("\nDigite el numero de Columnas: ");
            nCol = int.Parse(Console.ReadLine());
            int[,] matriz = new int[nFilas, nCol];
            Console.WriteLine("\nDigite la matriz: ");
            for (int i = 0; i < nFilas; i++)
            {
                for (int j = 0; j < nCol; j++)
                {
                    Console.Write("\nmatriz[" + i + "][" + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nLa matriz es: ");
            for (int i = 0; i < nFilas; i++)
            {
                for (int j = 0; j < nCol; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            for (int i = 0; i < nFilas; i++)
            {
                sumaFilas = 0;
                for (int j = 0; j < nCol; j++)
                {
                    sumaFilas += matriz[i, j];
                }
                Console.WriteLine("\nla suma de la fila[" + i + "] es : " + sumaFilas);
            }
            Console.WriteLine("");
            for (int j = 0; j < nCol; j++)
            {
                sumaCol = 0;
                for (int i = 0; i < nFilas; i++)
                {
                    sumaCol += matriz[i, j];
                }
                Console.WriteLine("\nLa suma de la columna [" + j + "] es :" + sumaCol);
            }
            Console.WriteLine("");
        }
        public void eje05()
        {
            float saldo_inicial = 500000f;
            int opcion;
            float ingreso, saldoActual, retiro;
            Console.WriteLine("5. Cajero Automatico con SALDO INICIAL de $500.000");
            Console.WriteLine("\nBienvenido a su cajero automatico\n"
                + "1. ingresar dinero a la cuenta\n"
                + "2. retirar dinero de la cuenta\n"
                + "3. salir.");
            Console.WriteLine("Elija una opcion: ");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.Write("Digite la cantidad que desea ingresar en la cuenta: $");
                    ingreso = float.Parse(Console.ReadLine());
                    saldoActual = (saldo_inicial + ingreso);
                    Console.Write("dinero en la cuenta: $" + saldoActual);
                    break;
                case 2:
                    Console.Write("Digite la cantidad que desea retirar: $");
                    retiro = float.Parse(Console.ReadLine());
                    if (retiro > saldo_inicial)
                    {
                        Console.WriteLine("No cuenta con el saldo sufiente");
                    }
                    else
                    {
                        saldoActual = saldo_inicial - retiro;
                        Console.WriteLine("Dinero en la cuenta: $" + saldoActual);
                    }
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Se equivo de opcion del menu");
                    break;
            }
        }

        #endregion
        public void mostrar03()
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
                Console.SetCursorPosition(25, 11); Console.Write("6. Salir");
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
