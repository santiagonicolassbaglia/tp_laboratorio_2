using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Sbaglia_Santiago_1D_tp4
{
    [Serializable]
   public class Cliente:Persona
    {


        private string usuario;
        private string contrasenia;




        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                this.usuario = value;
            }

        }








        public string Contrasenia
        {
            get
            {
                return contrasenia;
            }

            set
            {
                this.contrasenia = value;
            }

        }



        public Cliente(string nombre, int dni, string usuario, string contraseña,string apellido) :base(nombre,apellido,dni)
        {
            
            this.usuario = usuario;
            this.contrasenia = contraseña;

            
        }



       



        public static bool operator ==(Cliente usuario, Cliente contraseña)
        {
            return (usuario.Usuario == usuario.Contrasenia);
        }



        public static bool operator !=(Cliente usuario, Cliente contraseña)
        {
            return !(usuario.Usuario == usuario.Contrasenia);
        }


        
        



        public string DatosCompletos()
        {
            return this.nombre + " " + this.apellido;
        }


       

    }
}
