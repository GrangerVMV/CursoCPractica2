using System;

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




    }
}
