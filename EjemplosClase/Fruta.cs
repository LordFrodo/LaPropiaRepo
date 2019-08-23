using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Fruta
    {
        //Miembros dato
        private string nombre;
        private int cantidad;
        private string tipo_fruta;
        private double volumen;
        private int[] vitaminas;
        private bool madura;
        private float peso;
        private int precio;
        private string color;


        //Constructores
        public Fruta()
        {
            Console.WriteLine("Creando objeto, a la verga soy dios :V");
            nombre = "Banano";
        }
        public Fruta(bool madura)
        {
            if (madura == true)
            {
                color = "amarillo";
            }
            else
            {
                color = "Verde";
            }
        }
        public Fruta(float peso)
        {
            Peso = peso;
        }
        public Fruta(float peso, bool madura)
        {
            if (peso > 100 && madura == true)
            {
                precio = 1000;
            }
            else
            {
                precio = 500;
            }
        }
        public Fruta()
        {

        }

        //Setters y getters

        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Tipo_fruta { get => tipo_fruta; set => tipo_fruta = value; }
        
        public int[] Vitaminas { get => vitaminas; set => vitaminas = value; }
        public bool Madura { get => madura; set => madura = value; }
        public double Volumen { get => volumen; set => volumen = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float Peso { get => peso; set => peso = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Color { get => color; set => color = value; }
    }
   
}
