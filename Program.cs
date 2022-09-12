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
            MensajeEnPantalla();// Para entender el flujo del programa método-cw-metodo-metodo
            MensajeEnPantalla();
        }


    }
}