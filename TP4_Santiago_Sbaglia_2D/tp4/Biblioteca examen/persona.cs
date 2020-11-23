using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sbaglia_Santiago_1D_tp4
{
    public abstract class Persona
    {
        protected string nombre; // es privado para clases externas a la relacion de herencia
        protected string apellido;
        protected int dni;

        public string Nombre
        {
            get
            {
                if (this.nombre == string.Empty)
                {
                    return "nombre no registrado";
                }

                return this.nombre;
            }


            set
            {
                this.nombre = value;
            }
        
        
        }

        public string Apellido
        {

            get
            {
                if (this.apellido == string.Empty)
                {
                    return "Apellido no registrado";
                }

                return this.apellido;
            }


            set
            {
                this.apellido = value;
            }



        }

        public int Dni
        {
            get
            {
                return dni;
            }

            set
            {
                this.dni = value;
            }

        }



        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }


       



    }
}

