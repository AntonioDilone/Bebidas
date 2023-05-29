using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bebidas
{
    internal class Bebida {
        public string Nombre { get; set; }
        public int PorcentajeAlchol { get; set; }
        public string Tipo { get; set; }

        public string Color { get; set; }

        public double Volumen { get; set; }

        public int cantidad { get; set; }
        
        /*public Bebida(string Nombre, int PorcentajeAlcohol, string Tipo, string Color, double Volumen, int cantidad) {
            Nombre = Nombre;
            Color = Color;
            Tipo = Tipo;
            Volumen = Volumen;
            PorcentajeAlcohol = PorcentajeAlcohol;
            cantidad = cantidad;
        }*/

        public void Descrip()
        {
            Console.WriteLine(Nombre + " es una bebida alcoholica de tipo " + Tipo + " con un porcentaje de alcohol de " 
            + PorcentajeAlchol +"%, un volumen de "+ Volumen+"ml, y es de color "+ Color + ". Actualmente, hay " + cantidad );
        }

        
    }
}
