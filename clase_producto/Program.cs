using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_producto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            carnico producto1 = new carnico();
            producto1.Nombre = "chuleta";
            producto1.Codigo = "LE123";
            producto1.Precio = 1.5;
            producto1.FechaDeCaducidad = "2023-10-15";
            producto1.TemperaturaRecomendada = 4.7;
            producto1.tipoDeCarme = "cerdo";
            producto1.procedencia = "España";
            producto1.MostrarInformacionGeneral();
            producto1.MostraCondicionesdeAlmacenamiento();
            producto1.MostrarInformacionNutricional();
        }
        class carnico : productoPredecible
        {
            public string tipoDeCarme;
            public string procedencia;
            public void MostrarInformacionNutricional()
            {
                Console.WriteLine("el tipo de carne es: " + tipoDeCarme);
                Console.WriteLine("la procedencia es: " + procedencia);
            }
        }
        class lacteo : productoPredecible
        {
            public double contenidoGraso;
            public string tipoDeLacteo;
            public void MostrarInformacionLacteo()
            {
                Console.WriteLine("el contenidoGraso: " + contenidoGraso);   
                Console.WriteLine("el tipo lacteo es: " + tipoDeLacteo + "°C");
            }
        }
        class productoPredecible : producto
        {
            public string  FechaDeCaducidad;
            public double TemperaturaRecomendada;
                public void MostraCondicionesdeAlmacenamiento()
            {
                Console.WriteLine("Fecha de caducidad: " + FechaDeCaducidad);
                Console.WriteLine("Temperatura recomendada: " + TemperaturaRecomendada + "°C");
            }
        }
        class producto
        {
            public string Nombre;
            public string Codigo;
            public double Precio;
            public void MostrarInformacionGeneral()
            {
                Console.WriteLine("Nombre: " + Nombre);
                Console.WriteLine("Código: " + Codigo);
                Console.WriteLine("Precio: " + Precio);
            }
        }
    }
}
