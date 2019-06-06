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
            Console.WriteLine("ejericicio 23");
            //Introducir dos números por teclado.Imprimir los números naturales que hay entre ambos números empezando
            //por el más pequeño, contar cuantos hay y cuantos de ellos son pares. Calcular la suma de los impares.
            int num1, num2, cantNurales, cantpares, sumImpares;
            cantNurales = 0;
            cantpares = 0;
            sumImpares = 0;
            Console.Write("Ingrese un de Inicio: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese un de Inicio: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            for (int x = num1; x <= num2; x++)
            {
                Console.WriteLine(x);
                cantNurales = cantNurales + 1;
                if (x % 2 == 0)
                {
                    cantpares = cantpares + 1;
                }
                else
                {
                    sumImpares = sumImpares + x;
                }
            }
            Console.WriteLine("Cantidad de numeros Naturales" + cantNurales);
            Console.WriteLine("Cantidad Numero Pares:" + cantpares);
            Console.WriteLine("Suma de Numeros Impares:" + sumImpares);
            Console.ReadKey();
            Console.WriteLine("ejericicio 24");
            // Introducir una serie de números. Decir si esos números son mayores o menores de 10.
            int numerof = 0;
            string mayores, menores;
            mayores = "";
            menores = "";
            for (int qw = 1; qw < 10; qw++)
            {
                Console.Write("Ingrese un Numero: ");
                numerof = Convert.ToInt32(Console.ReadLine());
                if (numerof > 10)
                {
                    mayores = mayores + "" + numerof + ",";
                }
                else
                {
                    menores = menores + "" + numerof + ",";
                }
            }
            Console.WriteLine("Los numeros: " + mayores + " " + "Son mayores que 10");
            Console.WriteLine("Los numeros: " + menores + " " + "Son Menores que 10");
            Console.ReadKey();
            Console.WriteLine("ejericicio 25");
            //Introducir tantos números que hay entre el 1 al 100.excepto los múltiplos de 2.
            int nume = 0;
            for (int we = 1; we < 15; we++)
            {
                Console.Write("Ingrese un numero entre el 1 al 100, excepto los Multiplos de 2:");
                nume = Convert.ToInt32(Console.ReadLine());
                if (nume < 0 || nume > 100)
                {
                    Console.WriteLine("El numero ingresado no esta entre el rango de 1 - 100");
                    Console.ReadKey();
                    return;
                }
                if (nume % 2 == 0)
                {
                    Console.WriteLine("El numero ingresado es multiplo de dos");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("ejericicio 26");
                //Imprimir y sumar los números desde el cero hasta un numero determinado, excepto los múltiplos
                //de 5 imprimir el valor de la suma de los múltiplos de 5.
                int numer, sumaNumeros, sumaMultiplos;
                sumaMultiplos = 0;
                sumaNumeros = 0;
                Console.Write("Ingrese un numero donde desea finalizar: ");
                numer = Convert.ToInt32(Console.ReadLine());
                for (int er = 0; er <= numer; er++)
                {
                    if (er % 5 == 0)
                    {
                        sumaMultiplos = sumaMultiplos + er;
                    }
                    else
                    {
                        Console.WriteLine(er);
                        sumaNumeros = sumaNumeros + er;
                    }
                }
                Console.WriteLine("Suma de numeros Excepto los multiplos de 5: {0}", sumaNumeros);
                Console.WriteLine("Valor de la suma de los multiplos de 5: {0}", sumaMultiplos);
                Console.ReadKey();
                Console.WriteLine("ejericicio 27");
                //Imprimir y contar los números, que son a la vez múltiplos de 2 y 3, que
                //hay entre la unidad y el determinado número.
                int nmero, cantNumeros;
                nmero = 0;
                cantNumeros = 0;
                Console.Write("Ingrese un Numero donde desea finalizar el conteo: ");
                nmero = Convert.ToInt32(Console.ReadLine());
                for (int rt = 1; rt <= nmero; rt++)
                {
                    if (rt % 2 == 0 && rt % 3 == 0)
                    {
                        Console.WriteLine(rt);
                        cantNumeros = cantNumeros + 1;
                    }
                }
                Console.WriteLine("Cantidad de numeros Multiplos de 2 y 3:" + cantNumeros);
                Console.ReadKey();
                Console.WriteLine("ejericicio 28");
                //Introducir una serie de números. Sumar los múltiplos de 5. Cual es el mayor y cuantos números
                //se han introducido. SEPARADO EN 7 UNIDADES, SUMAR LOS IMPARES
                int numeo, sumaMultiplo, mayor, sumaImpares;
                sumaMultiplo = 0;
                mayor = 0;
                sumaImpares = 0;
                for (int ty = 1; ty <= 10; ty++)
                {
                    Console.Write("Ingrese un numero: ");
                    numeo = int.Parse(Console.ReadLine());
                    if (numeo % 5 == 0)
                    {
                        sumaMultiplo = sumaMultiplo + numeo;
                    }
                    if (numeo > mayor)
                    {
                        mayor = numeo;
                    }
                    if (numero % 2 == 0)
                    {
                        sumaImpares = sumaImpares + numero;
                    }
                }
                Console.WriteLine("Suma de los Multiplos de 5: {0}", sumaMultiplo);
                Console.WriteLine("El mayor de los Numeros Ingresado: {0}", mayor);
                Console.WriteLine("Suma de los numeros impares: {0}", sumaImpares);
                Console.ReadKey();
                Console.WriteLine("ejericicio 29");
                // Introducir dos números por teclado de tal forma que el segundo sea mayor que el primero.
                //A partir del primero. Imprimir los números separados. Entre si 7 unidades, contarlos.
                //Cuantos de estos son pares y cuanto vale la suma de los impares.
                int numero1, numero2, cantPares, sumImpres;
                cantPares = 0;
                sumImpres = 0;
                Console.Write("Ingrese un Numero: ");
                numero1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese otro numero Mayor que el anterior: ");
                numero2 = int.Parse(Console.ReadLine());
                if (numero2 > numero1)
                {
                    for (int yu = numero1; yu < numero2; yu = yu + 7)
                    {
                        Console.WriteLine(yu);
                        if (yu % 2 == 0)
                        {
                            cantPares = cantPares + 1;
                        }
                        else
                        {
                            sumImpres = sumImpres + yu;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("El segundo numero no es mayor al primero.....");

                }
                Console.WriteLine("Numeros pares encontrados:" + cantPares);
                Console.WriteLine("Suma de Numeros Impares:" + sumImpares);
                Console.ReadKey();
                Console.WriteLine("ejericicio 30");
                //Introducir una cantidad por teclado.Si es menor que 500, sumarle el 50 por ciento;
                //si es mayor o igual a 500 pero menor que 1000, sumarle el 7 por ciento;
                //si es mayor que 1000 y menor o igual a 5000, restarle el 5 por ciento.
                int cantidad;
                Console.Write("Ingrese una Cantidad: ");
                cantidad = int.Parse(Console.ReadLine());
                if (cantidad < 500)
                {
                    Console.WriteLine("\n ========================");
                    Console.WriteLine("El numero que ingreso es:" + cantidad);
                    cantidad = cantidad + (cantidad * 50 / 100);
                    Console.WriteLine("Total mas 50%:" + cantidad);

                }
                else if (cantidad >= 500 && cantidad < 1000)
                {
                    Console.WriteLine("\n ========================");
                    Console.WriteLine("El numero que ingreso es:" + cantidad);
                    cantidad = cantidad + (cantidad * 7 / 100);
                    Console.WriteLine("Total mas 7%:" + cantidad);
                }
                else if (cantidad > 1000 && cantidad <= 5000)
                {
                    Console.WriteLine("\n ========================");
                    Console.WriteLine("El numero que ingreso es: {0}", cantidad);
                    cantidad = cantidad - (cantidad * 5 / 100);
                    Console.WriteLine("Total menos 5%: {0}", cantidad);
                }
                Console.ReadKey();
                Console.WriteLine("ejericicio 31");
                //Imprimir diez veces la serie de números del 1 al 10
                for (int ui = 1; ui <= 10; ui++)
                {
                    Console.WriteLine("==========Serie {0}==========", ui);
                    for (int io = 1; io <= 10; io++)
                    {
                        Console.WriteLine(io);
                    }

                }
                Console.ReadKey();
                Console.WriteLine("ejericicio 32");
                //Imprimir, contar y sumar los múltiplos de 2 que hay entre una serie de número,
                //tal que el segundo sea mayor o igual que el primero
                int n1 = 1, n2 = 0, op = 0, cp = 0, sph = 0;
                while (n1 > n2)
                {
                    Console.Write("Ingrese un valor entero positivo: ");
                    n1 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el otro valor mayor al anterior: ");
                    n2 = int.Parse(Console.ReadLine());
                    if (n1 > n2)
                    {
                        Console.Write("Error debe ingresar el Segundo valor mayor o igual al primero");
                    }
                }
                op = n1;
                while (op <= n2)
                {
                    if (op % 2 == 0)
                    {
                        Console.WriteLine(cp);
                        cp++;
                        sph = sph+ op;
                    }
                    cp++;
                }
                Console.WriteLine("Multiplos de 2 encontrados: " + cp);
                Console.WriteLine("La suma de los multiplos de 2: " + sp);
                Console.ReadKey();
                Console.WriteLine("ejericicio 33");
                //Calcular e imprimar la factorial de un número ingresado vía teclado.
                int nuro = 0, fact = 1;
                Console.Write("Ingrese un numero a calcular el Factorial: ");
                nuro = Convert.ToInt32(Console.ReadLine());
                for (int sa = 1; sa <= nuro; sa++)
                {
                    fact = fact * sa;
                }
                Console.WriteLine("El Factorial del numero ingresado es:" + fact);
                Console.ReadKey();
                Console.WriteLine("ejericicio 34");
                //Hacer un programa que obtenga el producto de dos números enteros positivos mediante restas sucesivas
                int n3 = 0, n4 = 0, sd = 0, multi = 0;
                Console.Write("Ingrese el primer número entero: ");
                n3 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el segundo número entero: ");
                n4 = Convert.ToInt32(Console.ReadLine());
                while (sd < n4)
                {
                    multi = multi - n3;
                    sd++;
                }
                Console.WriteLine("La multiplicación por sumas sucesivas es: " + multi * -1);
                Console.ReadKey();
                Console.WriteLine("ejericicio 35");
                //Obtener el cociente y el resto de dos números enteros positivos mediante restas sucesivas
                int m1 = 0, m2 = 1, fg = 0, gh = 0;
                while (n2 > n1)
                {
                    Console.Write("Ingrese un valor entero positivo: ");
                    m1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese el otro valor menor al anterior: ");
                    m2 = Convert.ToInt32(Console.ReadLine());
                }
                fg = n1;
                while (fg >= m2)
                {
                    fg = fg - m2;
                    gh++;
                }
                Console.WriteLine("El cociente por restas sucesivas es: " + gh);
                Console.WriteLine("El resto de la divisón por restas sucesivas es: " + fg);
                Console.ReadKey();
                Console.WriteLine("ejericicio 36");
                //Hacer un algoritmo que calcule las raíces de una ecuación de segundo grado
                //Repetir el proceso tantas veces como se desee.
                Console.ReadKey();
                Console.WriteLine("ejericicio 37");
                //Hacer un programa que determine cuantas cifras posee un número
                //entero positivo introducido por teclado.repetir el proceso
                int nu = 0, cant = 0;
                Console.Write("Ingrese un numero entero positivo: ");
                nu = Convert.ToInt32(Console.ReadLine());

                while (nu >= 10)
                {
                    cant++;
                    nu = nu / 10;
                }
                Console.WriteLine("El número tiene: " + (cant + 1) + " dígitos");
                Console.ReadKey();

                Console.WriteLine("ejericicio 40");
                //Calcular el menor numero primo de un numero que introducimos vía teclado.

                int cv = 0, aux = 0, cc = 0, numro = 0;
                Console.Write("Ingrese un valor: ");
                numro = Convert.ToInt32(Console.ReadLine());
                while (cv < numro)
                {
                    cv++;
                    while (aux < cv)
                    {
                        aux++;
                        if (cv % aux == 0)
                        {
                            cc++;
                        }
                    }
                    if (cc == 2)
                    {
                        Console.WriteLine(" " + cc);

                    }
                    cc = 0;
                    aux = 0;
                }
                Console.WriteLine("El menor numero primos es: 2");
                Console.ReadKey();
                Console.WriteLine("ejericicio 41");
                // Introducir un número entero, imprimir el valor equivalente en binario
                int nuo = 0, x = 0;
                Console.Write("Ingrese un numero ENTERO para Convertir a BINARIO: ");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n===============");
                Console.Write("BINARIO: ");
                while ((nuo) != 0)
                {
                    x = nuo % 2;
                    Console.Write("" + x);
                    nuo = nuo / 2;
                }
                Console.ReadKey();
                Console.WriteLine("ejericicio 42");
                //Implementar un método en java que reciba como parámetro un vector de 20 elementos
                int[] Vector1 = new int[19];
                int conteo = 0;

                for (int nn = 0; nn < Vector1.Length; nn++)
                {
                    conteo = nn;
                }
                if (conteo == 20)
                {
                    Vector(Vector1);
                }

            }
        }
        public static void Vector(int[] intArray)
        {
            Console.WriteLine("fin :v ");
        }
    
    }
}
