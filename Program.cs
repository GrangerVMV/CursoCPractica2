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
            MensajeEnPantalla(); //Llamada al Primer método: Imprime un mensaje en pantalla
            Console.WriteLine("Mensaje desde el Main");
            MensajeEnPantalla();// Para entender el flujo del programa método-Console.WriteLine-metodo-metodo
            MensajeEnPantalla();

            SumaNumerosVal(7, 9); //Llamada al Segundo método: Suma números por valor

            Console.WriteLine($"El resultado de la suma con return es {sumaNumeros(5, 4)}"); // Llamada al Tercer método: suma números y devuelve un valor

            Console.WriteLine($"El resultado de la división con return es {divideNumeros(8,6)}"); // Llamada al Cuarto método: divide números con return

            Console.WriteLine($"El resultado de la multiplicación con operador flecha es {multiplicaNumeros(7,3)}");// Llamada al Quinto método: Multiplica números con operador flecha en vez de return

            Console.WriteLine($"El resultado de la suma con sobrecargas es {Suma(1, 2, 4, 8)}"); // Llamada a Octavo método: Crea varios métodos con elmismo nombre (sobrecargas)
        }

        // ****************** Métodos ******************


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

        // Sexto y Séptimo método: Utiliza variables de ambito global (campos de clase)    
        void sumaCampoClase()
        {
            Console.WriteLine($"La suma de los campos de clase es {campoClase1 + campoClase2}"); // Si no se definen a nivel de clase (global) las mismas variables no se pueden usar en sistintos métodos
        }
        void restaCampoClase()
        {
            Console.WriteLine($"La resta de los campos de clase es {campoClase1 - campoClase2}"); // Si no se definen a nivel de clase (global) las mismas variables no se pueden usar en sistintos métodos
        }

        // Octavo método: Crea varios métodos con elmismo nombre (sobrecargas)
        //Para crear varios métodos con distinto nombre deben tener distinto número o distinto tipo de parámetros

        static int Suma(int sumando1, int sumando2) => sumando1 + sumando2;
        static int Suma(int numero1, int numero2, int numero3, int numero4) => numero1 + numero2 + numero3 + numero4;
        static int Suma(int numero1, double numero2) => numero1;
        

     int campoClase1 = 10; // Las variables globales (campos de clase) se pueden usar primero y definir después -> no sigue el flujo de ejecucuón
     int campoClase2 = 4;



    }
}
