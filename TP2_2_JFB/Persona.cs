using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_2_JFB
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad {  get; set; }
        public int DNI { get; set; }
        public char Sexo { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }


        //construtor 
        public Persona (string nombre, int edad, int dni, char sexo, double peso, double altura)
        {
            Nombre = nombre;
            Edad = edad;    
            DNI = dni;
            Sexo = sexo;
            Peso = peso;
            Altura = altura;
        }

        public Persona() { }

        public Persona(string nombre, int edad, char sexo)
        {
            Nombre = nombre;    
            Edad = edad;
            Sexo = sexo;
        }

        //Metodo para el IMC

        public int IMC()
        {
            double AlturaenMetro = Altura / 100.0;
            double PesoIdeal = Peso / (AlturaenMetro * AlturaenMetro);

            if (PesoIdeal < 20) 
            {
                return -1;
            }
            else if (PesoIdeal >= 20 && PesoIdeal <= 25)
            {
                return 0;
            }
            else 
            {
                return 1;
            }
        }

        //Comprobacion de Edad
        public bool MayordeEdad()
        {
            int mayordeedad = Edad;

            if (mayordeedad > 18)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }

        //Metodo para comprobar el sexo (Predeterminado 'H')
        public char ValidarSexo()
        {
            char sexoValido = Sexo;

            if(sexoValido=='H' || sexoValido=='M' || sexoValido=='N')
            {
                return Sexo;
            }
            else
            {
                Sexo = 'H';
                return Sexo;
            }
        }

        public override string ToString()
        {
            return $"Nombre:{Nombre}, Edad:{Edad}, Sexo:{Sexo}, Peso:{Peso}, Altura:{Altura}";
        }
    }
}
