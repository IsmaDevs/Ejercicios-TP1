using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPN1Lab_I
{
    class Program
    {
        static void Main(string[] args)
        {
            // Trabajo Práctico N° 1 - Laboratorio I

            //-----------------------------------------------------------

            Console.WriteLine("Ejercicio N° 1:");
            int numero1;
            Console.WriteLine();
            Console.Write("Por favor ingrese un número: ");
            numero1 = int.Parse(Console.ReadLine());

            int numero2;
            Console.WriteLine();
            Console.Write("Ahora ingrese otro número: ");
            numero2 = int.Parse(Console.ReadLine());

            int suma;
            suma = numero1 + numero2;
            Console.WriteLine();
            Console.WriteLine(" La suma de ambos numeros es de " + suma);

            int resultado;
            resultado = suma * 2;
            Console.WriteLine(" y multiplicado por dos el resultado es " + resultado);


            //--------------------------------------------------------------
            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Ejercicio N° 2");

            int sueldo;
            Console.WriteLine();
            Console.Write("Por favor ingrese su sueldo: ");
            sueldo = int.Parse(Console.ReadLine());

            int resultado1;

            resultado = sueldo / 30;

            int horas;
            Console.WriteLine();
            Console.Write("Ahora ingrese la cantidad de horas que trabaja usualmente: ");
            horas = int.Parse(Console.ReadLine());

            int resultadoTotal;

            resultadoTotal = resultado / horas;
            Console.WriteLine();
            Console.WriteLine("Su sueldo por hora es de $" + resultadoTotal + " pesos");


            //--------------------------------------------------------------
            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Ejercicio N° 3");

            double lado;
            Console.WriteLine();
            Console.Write("Por favor ingrese el número de uno de los lados del cuadrado: ");
            lado = double.Parse(Console.ReadLine());

            double perimetro;

            perimetro = lado * 4;
            Console.WriteLine();
            Console.WriteLine("El perimetro del cuadrado es de " + perimetro);

            //--------------------------------------------------------------
            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Ejercicio N° 4");

            double num1;
            Console.WriteLine();
            Console.WriteLine("A continuación se le pedira cuatro numeros para realizar la suma y su promedio");
            Console.WriteLine();
            Console.Write("Ingrese el primer número: ");
            num1 = double.Parse(Console.ReadLine());

            double num2;
            Console.WriteLine();
            Console.Write("Ahora ingrese el segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            double num3;
            Console.WriteLine();
            Console.Write("Ahora ingrese el tercer número: ");
            num3 = double.Parse(Console.ReadLine());

            double num4;
            Console.WriteLine();
            Console.Write("Ahora por ultimo, ingrese el cuarto número: ");
            num4 = double.Parse(Console.ReadLine());

            double sumaNum1234;

            sumaNum1234 = num1 + num2 + num3 + num4;

            Console.WriteLine();
            Console.WriteLine("La suma de los números que ingresaste es " + sumaNum1234);

            double promedio;

            promedio = sumaNum1234 / 4;
            Console.WriteLine("y el promedio es " + promedio);

            //--------------------------------------------------------------
            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Ejercicio N° 5");


            string articulo;
            Console.WriteLine();
            Console.Write("Por favor, ingrese ahora el nombre del articulo que lleva: ");
            articulo = Console.ReadLine();

            int cantidad;
            Console.WriteLine();
            Console.Write($"Ahora ingrese la cantidad de articulo que lleva de {articulo}: ");
            cantidad = int.Parse(Console.ReadLine());

            int abonar;
            abonar = cantidad * 80;

            Console.WriteLine();
            Console.WriteLine($" El total que debe abonar por el articulo {articulo} es de {abonar} pesos");

            //--------------------------------------------------------------
            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Ejercicio N° 6");

            int sueldo1;
            sueldo1 = 0;

            Console.WriteLine();
            Console.Write("Ingrese su sueldo: ");
            sueldo1 = int.Parse(Console.ReadLine());

            if (sueldo1 > 3000)
            {
                Console.WriteLine();
                Console.WriteLine("Debe pagar impuestos");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Usted no debe pagar impuestos");
            }

            //--------------------------------------------------------------
            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Ejercicio N° 7");

            double n1;
            Console.WriteLine();
            Console.Write("Ingrese un numero por favor:");
            n1 = double.Parse(Console.ReadLine());

            double n2;
            Console.WriteLine();
            Console.Write("Ahora ingrese el segundo número: ");
            n2 = double.Parse(Console.ReadLine());

            double suman1n2;
            double diferencia;
            double producto;
            double division;

            if (n1 > n2)
            {
                suman1n2 = n1 + n2;
                diferencia = n1 - n2;
                Console.WriteLine("");
                Console.WriteLine($"La suma de los numeros ingresados es {suman1n2} y la diferencia es de {diferencia}");

            }
            else
            {
                producto = n1 * n2;
                division = n1 / n2;
                Console.WriteLine($"El producto de los numeros ingresados es {producto} y la division dio un total de {division}");

            }

            //--------------------------------------------------------------
            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Ejercicio N° 8");

            string alumno;
            double nota1;
            double nota2;
            double nota3;

            Console.Write("Hola, escribe tu nombre para poder ingresar las notas: ");
            alumno = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Ahora sí, ingresa la primera nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Ahora ingresa tu segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Por ultimo, tu tercera nota:");
            nota3 = double.Parse(Console.ReadLine());

            double notas;

            notas = nota1 + nota2 + nota3 / 3;

            if (notas >= 7)
            {
                Console.WriteLine();
                Console.WriteLine($"{alumno} Alumno Promocionado");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"El Alumno {alumno} no Promociono");
            }

            //--------------------------------------------------------------
            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Ejercicio N° 9");

            int num;

            Console.WriteLine("");
            Console.Write("Por favor ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            if (num >= 0 && num < 10)
            {
                Console.WriteLine("");
                Console.WriteLine("El número tiene solo un digito");
            }
            else if (num >= 10 && num < 100)
            {
                Console.WriteLine("");
                Console.WriteLine("El numero tiene solo dos digitos");
            }
            else if (num >= 100 && num < 1000)
            {
                Console.WriteLine("");
                Console.WriteLine("El numero tiene solo tres digitos");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Error: El numero que ingreso tiene más de tres digitos o es negativo");
            }

            string opcion;
            int numm1;
            int numm2;
            int resultado3;

            opcion = Console.ReadLine();
            numm1 = int.Parse(Console.ReadLine());
            numm2 = int.Parse(Console.ReadLine());

            Console.WriteLine("1");

            switch (opcion)
            {
                case "1":
                    resultado3 = numm1 + numm2;
                    Console.Write($"La suma es {resultado}");
                    break;
            }


            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Ejercicio N° 10");

            int number;

            Console.Write("Por favor ingrese un numero entero: ");

            number = int.Parse(Console.ReadLine());

            if (number == 0) Console.WriteLine("El numero ingresado es nulo");
            if (number < 0) Console.WriteLine("El numero ingresado es negativo");
            if (number > 0) Console.WriteLine("El numero ingresado es positivo");

            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Ejercicio N° 11");

            int number1;
            int number2;

            Console.Write("Ingrese la cantidad de preguntas que realizo (1 - 10): ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese ahora la cantidad de preguntas contestadas bien: ");
            number2 = int.Parse(Console.ReadLine());

            if (number2 >= 0)
            {
                Console.WriteLine("Nivel insuficiente: 50%");
            }
            else if (number2 >= 5 && number2 < 6)
            {
                Console.WriteLine("Nivel regular: 60% - 70%");
            }
            else if (number2 >= 7 && number2 < 10)
            {
                Console.WriteLine("Nivel medio: 80% - 90%");
            }
            else if (number2 >= 10)
            {
                Console.WriteLine("Nivel máximo: 100%");
            }


            Console.ReadKey();
        }
    }
}
