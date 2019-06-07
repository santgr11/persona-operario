using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperarioGUI
{
    class Persona
    {
        private int documento;
        private bool sexo;
        private string nombre;
        private DateTime fechaNacimiento;

        public Persona(){
        
            this.documento = 0;
            this.nombre = "";
            this.sexo = false;
            this.fechaNacimiento = DateTime.Today;
        }
        public Persona(int documento,bool sexo,string nombre, DateTime fechaNacimiento)
        {
            this.documento = documento;
            this.sexo = sexo;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }


        public DateTime pFechaNacimiento { 
            get{ return fechaNacimiento;} 
            set{fechaNacimiento=value;} 
        }

        public string pNombre {
            get { return nombre; }
            set { nombre = value; }
        }
        public int pDocumento
        {
            set { documento = value; }
            get{ return documento; }
        }
        public bool pSexo
        {
            set { sexo = value; }
            get { return sexo; }
        }
 
        public string sexoString()
        {
            if (sexo)
            {
                return "Hombre";
            }

            return "Mujer";
        }
       
        public string toStringPersona()
        {
            return  "Documento: " + documento + "\n" +
                    "Sexo: " + sexoString() + "\n" +
                    "Nombre: " + nombre + "\n" + 
                    "Fecha de nacimiento: " + fechaNacimiento.ToShortDateString();
        }

    }
}
