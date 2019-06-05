using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_en_c
{
    class Program
    {
        static void Main(string[] args)
        {
            // ejercicio1 imprima los numeros del 0 al 100
            Console.WriteLine("los numeros del 0 al 100");
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // ejercicio2 imprima los numeros del 100 al 0 de forma decreciente
            Console.WriteLine("los numeros del 100 al 0 de forma decreciente");
            for (int n = 100; n >= 0; n--)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();

            //ejercicio3 imprima la suma de los 100 primeros numeros enteros
            Console.WriteLine("la suma de los 100 primeros numeros enteros");
            int suma = 0;

            for (int i = 1; i <= 100; i++)
            {
                suma = i * (i + 1) / 2;
            }
            Console.WriteLine("la suma de los numeros del 1 al 100 es: " + suma);
            Console.WriteLine();

            //ejercicio4 imprima los numeros pares del 1 al 100
            Console.WriteLine("los numero pares del 1 al 100 son: ");
            for (int i = 2; i <= 100; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //ejercicio5 imprima los numeros impares hasta el 100 y que imprima cuantos impares hay
            Console.WriteLine("lo numeros impares hasta el 100 son: ");
            int impar = 0;
            for (int i = 0; i <= 100; i++)
            {

                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    impar++;
                }
            }
            Console.WriteLine();

            //ejercicio6 imprima los numeros impares desde el 100 hasta la unidad y que calcule su suma
            Console.WriteLine("los numeros impares desde el 100 hasta la unidad");
            int IMPAR = 0;
            for (int i = 100; i >= 1; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    IMPAR--;
                }
            }
            Console.WriteLine();

            //ejercicio7 los numeros naturales que hay desde la unidad hasta un numero introducido por teclado
            Console.WriteLine("los numeros naturales que hay desde la unidad hasta un numero introducido por teclado");
            int numerolimite = 0;
            Console.WriteLine("ingrese un numero limite");
            numerolimite = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int n = 1; n <= numerolimite; n++)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();

            //ejercicio8 imprima y cuente los multiplos de 3 que hay entre 0 y 100
            Console.WriteLine("los multiplos de 3 que hay entre 0 y 100");
            for (int z = 0; z <= 100; z++)
            {
                if (z % 3 == 0)
                {
                    Console.WriteLine(z);
                }
            }
            Console.WriteLine();

            //ejercicio9 calcule la suma de los numeros impares comprendidos entre el 0 y el 100
            Console.WriteLine("la suma de los numeros impares entre el 0 al 100");
            int SUMA = 0, impar2 = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    impar2++;
                    Console.WriteLine();
                    SUMA = SUMA + impar2;
                    Console.WriteLine("suma " + SUMA);
                }

            }
            Console.WriteLine();

            //ejercicio10 imprima los multiplos de 5 que hay entre el 1 y el 500
            Console.WriteLine("los multiplos de 5 que hay entre el 1 y el 500: ");
            for (int m5 = 0; m5 <= 500; m5 = m5 + 5)
            {
                Console.WriteLine(m5);
            }
            Console.WriteLine();

            //ejercicio11 imprimir y sumar los multiplos de 2 hasta un numero que introducimos por teclado
            Console.WriteLine("ejercicio 11");
            int suma1 = 0, nlimite;
            Console.WriteLine("ingrese un numero limite");
            nlimite = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i <= nlimite; i = i + 2)
            {
                Console.WriteLine(i);
                Console.WriteLine();
                suma1 = suma1 + i;
                Console.WriteLine("suma " + suma1);
            }
            Console.WriteLine();

            //ejercicio12 imprimir y sumar los multiplos de 10 hasta un numero que introducimos por teclado
            Console.WriteLine("ejercicio 12");
            int suma2 = 0, numlimite;
            Console.WriteLine("ingrese un numero limite");
            numlimite = Convert.ToInt16(Console.ReadLine());
            for (int m10 = 0; m10 <= numlimite; m10 = m10 + 10)
            {
                Console.WriteLine(m10);
                Console.WriteLine();
                suma2 = suma2 + m10;
                Console.WriteLine("suma " + suma2);
            }
            Console.WriteLine();

            //ejercicio13 introducir un numero por teclado menor que 500.
            //imprimir y sumar los numeros que estan separados entre si 8 posiciones, desde es numero al 500
            Console.WriteLine("ejercicio 13");
            int num, suma3 = 0;
            Console.WriteLine("introdusca un numero menor que 500");
            num = Convert.ToInt16(Console.ReadLine());
            for (int v1 = num; v1 <= 500; v1 = v1 + 8)
            {
                Console.WriteLine(v1);
                Console.WriteLine();
                suma3 = suma3 + v1;
                Console.WriteLine("suma " + suma3);
            }
            Console.WriteLine();

            //ejercicio14 calcular la suma de los cuadrados de los numeros pare entre el 0 y 100
            Console.WriteLine("ejercicio 14");
            Console.WriteLine();

            //ejercicio16 introducir un numero por teclado y que nos diga si es positivo o negativo
            Console.WriteLine("ejercicio 16");
            int numero;
            Console.WriteLine("ingrese un numero");
            numero = Convert.ToInt16(Console.ReadLine());
            if (numero > 0)
            {
                Console.WriteLine("es positivo");
            }
            else
            {
                Console.WriteLine("es negativo");
            }
            Console.WriteLine();

            //ejercicio17 introducir un numero por teclado que nos diga si es par o impar
            Console.WriteLine("ejercicio 17");
            int b;
            Console.WriteLine("ingrese un numero");
            b = Convert.ToInt16(Console.ReadLine());
            if (b % 2 == 0)
            {
                Console.WriteLine("es par");
            }
            else
            {
                Console.WriteLine("es impar");
            }
            Console.WriteLine();

            //ejercicio18 imprimir los multiplos de 3 desde la unidad hasta un numero que introducimos por teclado
            Console.WriteLine("ejercicio 18");
            int Nu;
            Console.WriteLine("ingrese un numero");
            Nu = Convert.ToInt16(Console.ReadLine());
            for (int m = 0; m <= Nu; m = m + 3)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();

            //ejercicio19 imprima los numeros del 1  al 100
            //calcule la suma de todos los numeros pares por un lado y por otro la de todos los impares 
            Console.WriteLine("ejercicio 19");
            int imparm = 0, sp = 0, simp = 0;
            Console.WriteLine("numeros pares");
            for (int h = 0; h <= 100; h = h + 2)
            {
                Console.WriteLine(h);
                Console.WriteLine();
                sp = sp + h;
                Console.WriteLine("suma " + sp);
            }
            Console.WriteLine("numero impare");
            for (int imp = 0; imp <= 100; imp++)
            {
                if (imp % 2 != 0)
                {
                    Console.WriteLine(imp);
                    imparm++;
                    simp = simp + imparm;
                    Console.WriteLine("suma " + imparm);
                }
            }
            Console.WriteLine();

            //ejercicio20 imprimir los numeros que son multiplos de 2 o 3 que hay del 1 al 100
            Console.WriteLine("ejercicio 20");
            Console.WriteLine("los multiplos de 2");
            for (int y = 0; y <= 100; y = y + 2)
            {
                Console.WriteLine(y);
            }
            Console.WriteLine("los multiplos de 3");
            for (int s = 0; s <= 100; s = s + 3)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            //ejercicio22 imprima el mayor y el menor de una serie de 5 numeros que vamos introduciendo por teclado
            Console.WriteLine("ejercicio 22");
            int numm, max = 0, min = 0;
            for (int coun = 0; coun <= 5; coun++)
            {
                Console.WriteLine("escriba un numero");
                numm = Convert.ToInt16(Console.ReadLine());
                if (coun == 0)
                {
                    max = numm;
                    min = numm;
                }
                else if (coun != 0)
                {
                    if (numm < min)
                    {
                        min = numm;
                    }
                    if (numm > max)
                    {
                        max = numm;
                    }

                }

            }
            Console.WriteLine("el mayo es " + max);
            Console.WriteLine("el menor es " + min);
            Console.WriteLine();

            //ejercicio23 
        }
    }
}
