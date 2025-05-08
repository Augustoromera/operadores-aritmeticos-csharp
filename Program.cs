using System;

namespace OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("=== MENÚ: DEMOSTRACIÓN DE OPERADORES ARITMÉTICOS EN C# ===");
                Console.WriteLine("Por: [Tu Nombre] - Para la clase de Programación\n");

                Console.WriteLine("Menú de Opciones:");
                Console.WriteLine("1. Operadores Aritméticos Básicos");
                Console.WriteLine("2. Tipos de Datos y Operadores");
                Console.WriteLine("3. División Entera vs Decimal");
                Console.WriteLine("4. Operador Módulo (%)");
                Console.WriteLine("5. Precedencia de Operadores");
                Console.WriteLine("6. Asociatividad");
                Console.WriteLine("7. Operadores de Incremento/Decremento");
                Console.WriteLine("8. Casos Especiales");
                Console.WriteLine("0. Salir del Programa");
                Console.WriteLine("\nSeleccione una opción (0-8):");

                string input = Console.ReadLine();

                if (!int.TryParse(input, out opcion))
                {
                    Console.WriteLine("Entrada inválida. Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        MostrarSeccion("1. Operadores Aritméticos Básicos");
                        OperadoresBasicos();
                        break;
                    case 2:
                        Console.Clear();
                        MostrarSeccion("2. Tipos de Datos y Operadores");
                        TiposYOperadores();
                        break;
                    case 3:
                        Console.Clear();
                        MostrarSeccion("3. División Entera vs Decimal");
                        DivisionEnteraVsDecimal();
                        break;
                    case 4:
                        Console.Clear();
                        MostrarSeccion("4. Operador Módulo (%)");
                        OperadorModulo();
                        break;
                    case 5:
                        Console.Clear();
                        MostrarSeccion("5. Precedencia de Operadores");
                        PrecedenciaOperadores();
                        break;
                    case 6:
                        Console.Clear();
                        MostrarSeccion("6. Asociatividad");
                        Asociatividad();
                        break;
                    case 7:
                        Console.Clear();
                        MostrarSeccion("7. Operadores de Incremento/Decremento");
                        IncrementoDecremento();
                        break;
                    case 8:
                        Console.Clear();
                        MostrarSeccion("8. Casos Especiales");
                        CasosEspeciales();
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("=== FIN DEL PROGRAMA ===");
                        Console.WriteLine("Gracias por utilizar este programa.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 0);
        }

        static void MostrarSeccion(string titulo)
        {
            Console.WriteLine($"\n{titulo}");
            Console.WriteLine(new string('-', titulo.Length));
        }

        // 1. Operadores Básicos
        static void OperadoresBasicos()
        {
            int a = 10;
            int b = 3;
            int resultado;

            Console.WriteLine("Operadores básicos:");

            // Suma
            resultado = a + b;
            Console.WriteLine($"{a} + {b} = {resultado}");

            // Resta
            resultado = a - b;
            Console.WriteLine($"{a} - {b} = {resultado}");

            // Multiplicación
            resultado = a * b;
            Console.WriteLine($"{a} * {b} = {resultado}");

            // División
            try
            {
                resultado = a / b;
                Console.WriteLine($"{a} / {b} = {resultado}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Error: No se puede dividir entre cero ({a} / {b})");
            }

            // Módulo
            resultado = a % b;
            Console.WriteLine($"{a} % {b} = {resultado}");
        }

        // 2. Tipos y Operadores
        static void TiposYOperadores()
        {
            int entero = 5;
            double doble = 2.5;
            char caracter = 'C';
            string cadena1 = "43";
            string cadena2 = "1";

            double resultadoDouble;
            int resultadoInt;

            Console.WriteLine("Operaciones con distintos tipos:");

            // int + double
            resultadoDouble = entero + doble;
            Console.WriteLine($"{entero} + {doble} = {resultadoDouble}");

            // char + int (tratado como Unicode)
            resultadoInt = caracter + 1;
            char resultadoNuevoChar = (char)resultadoInt;
            Console.WriteLine($"'C' + 1 = {resultadoNuevoChar} (Unicode: {resultadoInt})");

            // Concatenación de strings
            Console.WriteLine($"\"{cadena1}\" + \"{cadena2}\" = \"{cadena1 + cadena2}\" (concatenación)");
        }

        // 3. División entera vs decimal
        static void DivisionEnteraVsDecimal()
        {
            int a = 5;
            int b = 2;
            int resultadoEntero;
            double resultadoDouble;

            Console.WriteLine("División entera vs división decimal:");

            // División entre enteros
            try
            {
                resultadoEntero = a / b;
                Console.WriteLine($"{a} / {b} = {resultadoEntero} (división entera)");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Error: No se puede dividir entre cero ({a} / {b})");
            }

            // Conversión a double
            resultadoDouble = (double)a / (double)b;
            Console.WriteLine($"{a} / {b} = {resultadoDouble} (conversión a double)");
        }

        // 4. Operador módulo (%)
        static void OperadorModulo()
        {
            int a = 10;
            int b = 3;
            int resultado;

            Console.WriteLine("Operador módulo (resto de división):");

            resultado = a % b;
            Console.WriteLine($"{a} % {b} = {resultado}");

            double x = 7.5;
            double y = 2.4;
            double resultadoDouble = x % y;
            Console.WriteLine($"{x} % {y} = {resultadoDouble}");
        }

        // 5. Precedencia de operadores
        static void PrecedenciaOperadores()
        {
            int a = 2;
            int b = 3;
            int c = 4;
            int resultado1, resultado2;

            Console.WriteLine("Precedencia de operadores:");

            // Sin paréntesis
            resultado1 = a + b * c;
            Console.WriteLine($"{a} + {b} * {c} = {resultado1}");

            // Con paréntesis
            resultado2 = (a + b) * c;
            Console.WriteLine($"({a} + {b}) * {c} = {resultado2}");
            // Con la misma operacion se evalua de izquierda a derecha
            resultado2 = a * b * c;
            Console.WriteLine($"{a} * {b} * {c} = {resultado2}");
        }

        // 6. Asociatividad
        static void Asociatividad()
        {
            int a = 4;
            int b = 2;
            int c = 6;
            int resultado;

            Console.WriteLine("Asociatividad (evaluación izquierda-derecha):");

            resultado = a / b * c;
            Console.WriteLine($"{a} / {b} * {c} = {resultado}");

            int x, y, z;
            x = y = z = 10; // Asociatividad derecha-izquierda
            Console.WriteLine("\nAsociatividad del operador de asignación (=):");
            Console.WriteLine($"x = y = z = 10 => x={x}, y={y}, z={z}");
        }

        // 7. Incremento y decremento
        static void IncrementoDecremento()
        {
            int contador = 5;
            int a = 5, b = 5;

            Console.WriteLine("Operadores ++ y --:");

            Console.WriteLine("Contador inicial: 5");

            contador++;
            Console.WriteLine($"contador++ => {contador}");

            --contador;
            Console.WriteLine($"contador-- => {contador}");

       
        }

        // 8. Casos especiales
        static void CasosEspeciales()
        {
            Console.WriteLine("8. Casos Especiales");
            Console.WriteLine("-------------------");

            Console.WriteLine("\n0.0 / 0.0:");
            double nan = 0.0 / 0.0;
            Console.WriteLine($"0.0 / 0.0 = {nan} (NaN - Not a Number)");

          
        }
    }
}