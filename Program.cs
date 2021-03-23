using System;

namespace DebuggingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Menu();
        }
        // Leer un número y calcularle el factorial a todos los enteros comprendidos entre 1 y el número leído.

        public static void Menu()
        {
            int number = 0;
            var parsingWasSuccessful = false;
            do
            {
                Console.WriteLine("Digite un numero");
                var numberString = Console.ReadLine();

                // Int32.Parse()
                // number = Convert.ToInt32(numberString);
                parsingWasSuccessful = Int32.TryParse(numberString, out number);
                if (parsingWasSuccessful)
                {
                    if (NumberIsInvalid(number))
                        Console.WriteLine("Númbero Inválido. Debe ser un número mayor que 0 y menor que 100");
                }
                else
                    Console.WriteLine("Debe insertar un número");

            } while (!parsingWasSuccessful || NumberIsInvalid(number));
            var average = Factorial(number);
            Console.WriteLine("The average is: " + average);
        }

        private static bool NumberIsInvalid(int number)
        {
            return number < 0 || number > 100;
        }

        public static int Factorial(int number)
        {
            int counter = 0;
            int acumulator = 0;
            while (counter <= number)
            {
                Console.WriteLine("Ciclo While: " + counter);
                int factorial = 1;
                // calcular factorial
                for (var i = 1; i <= counter; i++)
                {
                    // Console.WriteLine("==============");
                    // Console.WriteLine("Dentro del for");
                    factorial *= i;
                    // Console.WriteLine($"Para i = {i}, factorial = {factorial}");
                    // Console.WriteLine("==============");

                }
                Console.WriteLine($"Factorial para {counter}: {factorial}");
                acumulator += factorial;
                Console.WriteLine($"Acumulado: {acumulator}");
                Console.WriteLine("*****************************");

                counter++;
            }
            Console.WriteLine($"Final Acumulado {acumulator}");
            Console.WriteLine($"Dividido entre {counter}");
            int factorialAverage = acumulator / counter;
            return factorialAverage;
        }
    }
}
