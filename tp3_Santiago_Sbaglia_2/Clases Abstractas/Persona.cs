using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Excepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        #region atributos
        private string nombre;
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        #endregion

        #region construtores
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public Persona()
        {

        }

        /// <summary>
        /// Constructor con algunos parametros
        /// </summary>
        /// <param name="nombre"> va a pasar por una propiedad y si es correcto se cargara en el atributo</param>
        /// <param name="apellido">va a pasar por una propiedad y si es correcto se cargara en el atributo</param>
        /// <param name="nacionalidad">va a pasar por una propiedad y si es correcto se cargara en el atributo</param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad) : this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        /// <summary>
        /// Constructor con parametros llama a otro constructor
        /// </summary>
        /// <param name="nombre">va a pasar por una propiedad y si es correcto se cargara en el atributo</param>
        /// <param name="apellido">va a pasar por una propiedad y si es correcto se cargara en el atributo</param>
        /// <param name="dni">va a pasar por una propiedad y si es correcto se cargara en el atributo</param>
        /// <param name="nacionalidad">va a pasar por una propiedad y si es correcto se cargara en el atributo</param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }

        /// <summary>
        /// Constructor con parametros llama a otro constructor
        /// </summary>
        /// <param name="nombre">va a pasar por una propiedad y si es correcto se cargara en el atributo</param>
        /// <param name="apellido">va a pasar por una propiedad y si es correcto se cargara en el atributo</param>
        /// <param name="dni">va a pasar por una propiedad y si es correcto se cargara en el atributo</param>
        /// <param name="nacionalidad">va a pasar por una propiedad y si es correcto se cargara en el atributo</param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }

        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad que valida la entrada de un apellido, debe ser solo letras pueden ser mayus o min y permite espacios
        /// para aquellas persona con doble apellido como ejem 'Palmieri Alvarez' 
        /// tambien no permite ingresar apellidos mayores a 100 caracteres
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = this.ValidarNombreApellido(value);
            }
        }


        /// <summary>
        /// Propiedad que valida la entrada de un nombre, debe ser solo letras pueden ser mayus o min y permite espacios
        /// para aquellos nombre compuesto o personas con 2 nombres
        /// como ejem 'Juan Carlos Alberto' tambien no permite ingresar Nombres mayores a 100 caracteres
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = this.ValidarNombreApellido(value);
            }
        }

        /// <summary>
        /// Propiedades que permite obtener o colocar un DNI
        /// </summary>
        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.StringToDNI = value.ToString();
            }
        }
        /// <summary>
        /// Propiedad solo setter de un DNI utiliza un metodo que valida el DNI
        /// </summary>
        public string StringToDNI
        {
            set
            {
                this.dni = this.ValidarDni(this.Nacionalidad, value);
            }
        }

        /// <summary>
        /// Propiedad getter y setter que te permite obtener o settear la nacionalidad de una Persona
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// ToString retornará los datos de la Persona.
        /// </summary>
        /// <returns> string con los datos de la persona</returns>
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("NOMBRE COMPLETO: {0}, {1}", this.Apellido, this.Nombre);
            sb.AppendFormat("\nNACIONALIDAD: {0}", this.Nacionalidad);

            return sb.ToString();
        }

        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            try
            {
                int dni = int.Parse(dato);
                return ValidarDni(nacionalidad, dni);
            }
            catch (FormatException)
            {
                throw new DniInvalidoException("ERROR! Dni incorrecto ! ");
            }
        }


        /// <summary>
        /// Valida que el dato pasado sea un numero tambien valida la cantidad de caracteres permitidos un dni puede tener 7 o 8 caracteres
        /// Este metodo puede lanzar un error del tipo "DniInvalidoException"
        /// </summary>
        /// <param name="nacionalidad">Campo a ser llamado para otra funcion</param>
        /// <param name="dato">Dato a validar que sea numerico y su cant de caracteres</param>
        /// <returns> el DNI ya validado o no</returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (dato >= 1 && dato <= 89999999)
            {
                if (nacionalidad == ENacionalidad.Argentino)
                {
                    return dato;
                }

                throw new NacionalidadInvalidaException();
            }
            else if (dato >= 90000000 && dato <= 99999999)
            {
                if (nacionalidad == ENacionalidad.Extranjero)
                {
                    return dato;
                }

                throw new NacionalidadInvalidaException();
            }
            else
            {
                throw new NacionalidadInvalidaException("¡¡Error!");
            }
        }

      
        private string ValidarNombreApellido(string dato)
        {
            string nombreValidado = "";
            Regex regex = new Regex("^[a-z-A-Z- :\\S]+$");
            Match match = regex.Match(dato);
            if (match.Success && dato.Count() <= 100)
            {
                nombreValidado = dato;
            }
            return nombreValidado;
        }
        #endregion

        #region enumerado

        public enum ENacionalidad
        {
            Argentino, Extranjero
        }
        #endregion
    }
}
