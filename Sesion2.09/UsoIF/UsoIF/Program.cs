using UsoIF.Models;

namespace UsoIF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Decir si es niño, joven o adulto
            /*
             * Niño: 0 - 12
             * Joven: 13 - 25
             * Adulto: 26 a mas
             */
            int edad = 0;
            Evaluate evaluate = new Evaluate();
            Console.WriteLine("Evaluar edad");
            Console.WriteLine("Ingresa tu edad: ");

            try
            {
                edad = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine(evaluate.EvalAge(edad));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
