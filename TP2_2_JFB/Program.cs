using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_2_JFB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Mauricio Giudicce", 17, 46789123,'H', 90, 171);
            Persona persona2 = new Persona("Edgar Gomez", 21, 45123456, 'H', 80, 170);
            Persona persona3 = new Persona("Ignacio Rodriguez", 20, 45456789, 'H', 70, 175);

            persona1.ToString();
            persona2.MayordeEdad();
            string prueba = persona2.ToString();
            Console.WriteLine(prueba);

            int peso = persona3.IMC();

            if (peso > 0) 
            {
                Console.WriteLine("La persona tiene sobrepeso");
            }
            else if (peso < 0)
            {
                Console.WriteLine("La persona esta por debajo de su peso ideal");
            }
            else 
            {
                Console.WriteLine("La persona esta en su peso ideal");
            }

            Console.ReadKey();
        }
    }
}
