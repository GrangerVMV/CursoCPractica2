﻿using System;

namespace CursoCPractica2_Metodos
{
    class Program
    {
        //Primer método: Imprime un mensaje en pantalla
        static void MensajeEnPantalla() //Aunque lo pongamos al principio el punto de entrada es el método Main
        {
            Console.WriteLine("Mensaje desde el método MensajeEnPantalla");
        }

        static void Main(string[] args) //Lee primero el método y después el Console.WriteLine
        {
            //Console.WriteLine("Hello World!");
            MensajeEnPantalla();
            Console.WriteLine("Mensaje desde el Main");
            MensajeEnPantalla();// Para entender el flujo del programa método-Console.WriteLine-metodo-metodo
            MensajeEnPantalla();

            SumaNumerosVal(7, 9); //Segundo método: Suma números por valor

            Console.WriteLine($"El resultado de la suma con return es {sumaNumeros(5, 4)}"); // Tercer método: suma números y devuelve un valor

            Console.WriteLine($"El resultado de la división con return es {divideNumeros(8,6)}"); // Cuarto método: divide números con return

            Console.WriteLine($"El resultado de la multiplicación con operador flecha es {multiplicaNumeros(7,3)}");
        }

        //Segundo método: Suma números por valor

        static void SumaNumerosVal(int num1, int num2)
        {
            Console.WriteLine($"El resultado de la suma es {num1+num2}");
                                 
        }

        //Tercer método: Suma números con return
        static int sumaNumeros(int num1, int num2)
        {
            return (num1 + num2);
        }

        //Cuarto método: Divide números con return
        static double divideNumeros(double num1, int num2) 
        {
            return num1 / num2;
        }

        // Quinto método: Multiplica números con operador flecha en vez de return
        static int multiplicaNumeros(int num1, int num2) => num1 * num2;

    }
}
