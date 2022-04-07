using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_IMC.Clases
{
    public class ClsIMC
    {
        private const double KG = 2.2046;
        public int edad { get; set; }
        public string nombre { get; set; }
        public int altura { get; set; }
        public int peso { get; set; }
        public string sexo { get; set; }
        public double Imc { get; set; }
        public string Prueba()
        {
            Console.WriteLine("Ingrese su Edad");
            this.edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su Nombre");
            this.nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su Altura");
            this.altura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su peso");
            this.peso = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su sexo");
            this.sexo = Console.ReadLine();

            double pesoKG = this.peso / KG;
            double alturamts = (double)this.altura / 100;
            double Altura = Math.Pow(alturamts, 2);
            this.Imc = pesoKG / Altura;
            if (this.Imc < 18.5)
            {
                Console.WriteLine("Tu peso esta demasiado bajo, come mas!!!");
            }
            if (this.Imc > 18.5 & this.Imc <= 24.9)
            {
                Console.WriteLine("Tu peso es normal Felicitaciones seguí asi !!");
            }

            if (this.Imc >= 25 & this.Imc <= 26.9)
            {
                Console.WriteLine("Tenes sobrepeso de grado I, cuidado te estas poniendo gordito!!");
            }
            if (this.Imc >= 27 & this.Imc <= 29.9)
            {
                Console.WriteLine("Alerta tienes sobrepeso tipo II, ve al gym y come saludable!!");
            }
            if (this.Imc >= 30 & this.Imc <= 34.9)
            {
                Console.WriteLine("Alerta tienes obesidad tipo I, te aconsejamos que empieces ir al gym!!");
            }
            if (this.Imc >= 35 & this.Imc <= 39.9)
            {
                Console.WriteLine("Alerta tienes obesidad tipo II, ve con un nutricionista!!");
            }
            if (this.Imc >= 40 & this.Imc <= 49.9)
            {
                Console.WriteLine("Alerta tienes obesidad tipo III (Morbida), seria bueno que solicites con expertos!!");
            }
            if (this.Imc > 50)
            {
                Console.WriteLine("Alerta tienes obesidad tipo IV (Extrema), ACTUA RAPIDO ESTAS MUY OBESO!!");
            }
            Console.WriteLine("Su Indice de masa corporal es:");
            return Imc.ToString();
        }


    }
}
    