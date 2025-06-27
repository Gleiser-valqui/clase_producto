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
            lacteo producto1 = new lacteo();
            producto1.Nombre = "Leche Entera";
            producto1.Codigo = "LE123";
            producto1.Precio = 1.5;
            producto1.FechaDeCaducidad = "2023-10-15";
            producto1.TemperaturaRecomendada = 4.7;
            producto1.contenidoGraso = 3.5;
            producto1.tipoDeLacteo = "Entera"; 
            producto1.MostrarInformacionGeneral();
            producto1.MostraCondicionesdeAlmacenamiento();
            producto1.MostrarInformacionLacteo();
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
