namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
                char opcion;
                Console.WriteLine("a. Sumar");
                Console.WriteLine("b. Restar");
                Console.WriteLine("c. Salir");
                opcion = char.Parse(Console.ReadLine());

                if (opcion == 'a')
                {
                    Console.WriteLine("Has escogido SUMAR");
                }
                else if (opcion == 'b')
                {
                    Console.WriteLine("Has escogido RESTAR");
                }
                else
                {
                    Console.WriteLine("SALIR");
                }

            }
        }
    };
       