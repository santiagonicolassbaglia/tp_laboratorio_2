using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sbaglia_Santiago_1D_tp4
{
    public class Producto
    {

        private int id; 
        private string descripcion;
        private string nombre;
        private float precio;
        

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

       
        public Producto(int id, string nombre, float precio ,string descripcion)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Descripcion= descripcion;
        }

       

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }



       

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }


       

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }




    }

}









