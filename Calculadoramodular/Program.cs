using System;

namespace Calculadoramodular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaramos variables

            double numero1 = 0;
            double numero2 = 0;
            byte opcion = 0;

            Sumar(numero1, numero2);
            Restar(numero1, numero2);
            Mutiplicar(numero1, numero2);
            Dividir(numero1, numero2);
            Console.WriteLine("=========================================================");
            Console.WriteLine("================ Calculadora con Modulos ================");
            Console.WriteLine("=========================================================");
            Console.WriteLine("============Bienvenido por aqui es un placer ============");
            
            do
            {
                numero1 = Entrada1();
                numero2 = Entrada2();
                Console.WriteLine("=========================================================");
                Console.WriteLine("================ Menu de Operaciones ================");
                Console.WriteLine("1.Sumar ");
                Console.WriteLine("2.Restar ");
                Console.WriteLine("3.Multiplicar ");
                Console.WriteLine("4.Dividir");
                Console.Write("Selecione Una Operacion: ");
                while (!byte.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: No puede ingresar texto");
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Selecione Una Operacion: ");
                    Console.ResetColor();
                }
                Console.WriteLine("=========================================================");
                Console.WriteLine("\n");

                switch (opcion)
                {
                    case 1:
                        // Funcion para sumar
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write($" El Resultado de la Suma es :{Sumar(numero1, numero2)} \n");

                        Console.ResetColor();

                        break;

                    case 2:
                        // Funcion para restar
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write($" El Resultado de la Restar es :{Restar(numero1, numero2)} \n");
                        Console.ResetColor();

                        break;
                    case 3:
                        // Funcion para multiplicar
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write($" El Resultado de la Multiplicar es :{Mutiplicar(numero1, numero2)} \n");
                        Console.ResetColor();

                        break;
                    case 4:
                        // Funcion para dividor con la excepcion no es un numero NaN
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write($" El Resultado de la Division es :{Dividir(numero1, numero2):F2} \n");

                        Console.ResetColor();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opción incorrecta. Seleccione del 1 al 4.");
                        break;
                }
            } while (opcion != 5);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Gracias por usar esta Calculadora");
            Console.ResetColor();

            }
        
        // Clases 

            public static double Entrada1()
            {
                double numero1;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ingrese el primer valor: ");
                while (!double.TryParse(Console.ReadLine(), out numero1))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error por favor ingrese valores numerios no letras Eje: 123");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Intente nuevamente: ");
                    Console.ResetColor();
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correcto");
                Console.ResetColor();
                return numero1;
            }
            public static double Entrada2()
            {
                double numero2;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ingrese el segundo valor: ");
                while (!double.TryParse(Console.ReadLine(), out numero2))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error por favor ingrese valores numerios no letras Eje: 123");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Intente nuevamente: ");
                    Console.ResetColor();
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correcto");
                Console.ResetColor();
                return numero2;
            }

    

        public static double Sumar( double a , double b)
        {           
           return(a + b);
        }

        public static double Restar( double a , double b)
        {           
           return(a - b);
        }

        public static double Mutiplicar( double a , double b)
        {           
           return(a * b);
        }
        public static double Dividir( double a , double b)
        {          
            if (b == 0)
            {
                Console.WriteLine("Error: No Puedo dividir entre el 0");
                return double.NaN;
            }
            return (a / b);
        }
    }
}
