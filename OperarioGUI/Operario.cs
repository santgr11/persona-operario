using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperarioGUI
{
    class Operario : Persona
    {
        private bool categoria;
        private int horasTrabajadas;
        private double precioHora;

        public bool pCategoria {
            set { categoria = value;}
            get { return categoria;}
        }
        public int pHorasTrabajadas 
        {   set { horasTrabajadas = value;}
            get { return horasTrabajadas;}
        }
        public double pPrecioHora{
            set { precioHora = value; }
            get { return precioHora; }
        }

        public Operario() : base()
        {
            categoria = true;
            horasTrabajadas = 0;
            precioHora = 0;
        }
        public Operario(bool cat, int ht, double ph, int documento, bool sexo, string nombre, DateTime fechaNacimiento) 
            : base(documento, sexo, nombre, fechaNacimiento) {

            categoria = cat;
            horasTrabajadas = ht;
            precioHora = ph;
        }

        public string toString()
        {
            return base.toStringPersona() +
                "\nCategoria: " + categoriaString() +
                "\nHoras Trabajadas: " + horasTrabajadas +
                "\nPrecio Hora: " + precioHora;
        }

        public string categoriaString()
        {
            if(categoria)
            {
                return "Capataz";
            }

            return "Oficial";
        }

        public double calcularSueldo()
        {
            return horasTrabajadas * precioHora;
        }

    }
}
