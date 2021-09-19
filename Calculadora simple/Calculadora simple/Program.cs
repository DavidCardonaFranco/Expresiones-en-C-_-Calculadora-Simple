using System;


namespace ConsoleApplication15
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            Console.Title = "Mini Calculadora"; //Sirve para agregarle un título a la ventana
            string resp = "";
            do
            {
                double valor1 = 0; //Aquí se almacenará el primer valor ingresado.
                double valor2 = 0; //Aquí se almacenará el segundo valor ingresado.
                double R = 0; //Aquí se almacenará el resultado de la operación.

                const double pi = 3.14159265359;
                int[] fibonacci = new int[10] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };

                //Aquí mostraremos los mensajes que aparecerán en nuestra consola igual que el menú de selección.
                Console.WriteLine("Presione el símbolo para realizar la operación.");
                Console.WriteLine("1) para sumar.");
                Console.WriteLine("2) para restar.");
                Console.WriteLine("3) para multiplicar.");
                Console.WriteLine("4) para dividir.");
                Console.WriteLine("5) consultar valor de Pi.");
                Console.WriteLine("6) consultar la Sucesión de Fibonacci.");
                Console.Write("-> Elija Una Opción: "); //Aquí es donde indicaremos qué operación vamos a realizar
                resp = Console.ReadLine();
                string elección = Convert.ToString(resp);
                //Aquí se agregaran los mensajes para poder ingresar los datos.
                if ((elección != "5") && (elección != "6"))
                {
                    Console.WriteLine("Ingrese sus dos números.");
                    Console.Write("Valor1: ");
                    valor1 = double.Parse(Console.ReadLine());
                    Console.Write("Valor2: ");
                    valor2 = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                }

                switch (elección)
                {
                    case "1":
                        Console.WriteLine("El resultado de la suma es:");
                        R = valor1 + valor2;
                        Console.WriteLine("{0} + {1} = {2}", valor1, valor2, R);
                        break;
                    case "2":
                        Console.WriteLine("El resultado de la resta es:");
                        R = valor1 - valor2;
                        Console.WriteLine("{0} - {1} = {2}", valor1, valor2, R);
                        break;
                    case "3":
                        Console.WriteLine("El resultado de la multiplicación es:");
                        R = valor1 * valor2;
                        Console.WriteLine("{0} * {1} = {2}", valor1, valor2, R);
                        break;
                    case "4":
                        Console.WriteLine("El resultado de la división es:");
                        R = valor1 / valor2;
                        Console.WriteLine("{0} / {1} = {2}", valor1, valor2, R);
                        break;
                    case "5":
                        Console.WriteLine("Consulta del valor de pi:");
                        Console.WriteLine("π  = {0}", pi);
                        break;
                    case "6":
                        Console.WriteLine("Sucesión de Fibonacci:");
                        for (int i = 0; i < fibonacci.Length; i++)
                        {
                            Console.Write("|{0}|", fibonacci[i]);
                        }
                        Console.WriteLine("");
                        break;
                }
                Console.Write("¿Desea Continuar? S/N: "); //Sí para realizarlo de nuevo y no para salir.
                resp = Console.ReadLine();

            }
            while (resp == "s" || resp == "S");
        }
    }
}


