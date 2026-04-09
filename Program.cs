namespace deegad
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        // delegado
        public delegate int Operacion(int a, int b);

        // metodos
        public static int sumar(int a, int b) => a + b;
        public static int restar(int a, int b) => a - b;
        public static int multiplicar(int a, int b) => a * b;
        public static int dividir(int a, int b) => a / b;

        static void Main(string[] args)
        {
            
            Dictionary<string, Operacion> operaciones = new Dictionary<string, Operacion>()
        {
            { "1", sumar },
            { "2", restar },
            { "3", multiplicar },
            { "4", dividir }
        };

            Console.WriteLine("----CALCULADORA CON DELEGADOS----");
            Console.WriteLine("1. sumar");
            Console.WriteLine("2. restar");
            Console.WriteLine("3. multiplicar");
            Console.WriteLine("4. dividir");

            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            Console.Write("Ingrese el primer número: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int b = int.Parse(Console.ReadLine());

            
            if (operaciones.TryGetValue(opcion, out Operacion operacionselcc))
            {
                int resultado = operacionselcc(a, b);
                Console.WriteLine("Resultado: " + resultado);
            }
            else
            {
                Console.WriteLine("Opción inválida.");
            }
        }
    }
}
