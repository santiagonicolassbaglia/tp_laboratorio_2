using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Clases_Instanciables;
using EntidadesAbstractas;

namespace PruebaUnitariaSS
{
    [TestClass]
    public class UnitTest1
    {
        // Prueba que comprueba que el metodo NacionalidadInvalidaException funcione correctamente

        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void TestMetodo1()
        {
            Alumno alumno;
            alumno = new Alumno(1, "Santiago", "Sbaglia", "40009286", Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio);
        }



        /// <summary>
        /// Prueba que se lanze la excepcion DniInvalidoException
        /// valida que el numero ingresado en el DNI sea un numero y no una cadena de caracteres 
        /// o una mezcla de numeros y letras
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void TestMetodo2DniInvalidoException()
        {
            Alumno alumno;
            alumno = new Alumno(2, "pablo", "martinez", "410fgh75", Persona.ENacionalidad.Argentino, Universidad.EClases.SPD);
        }




        /// <summary>
        /// prueba que se lanze la excepcion SinProfesorException cuando no hay un profesor
        /// dentro de una universidad que pueda dar una materia seleccionada
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(SinProfesorException))]
        public void TestMetodo3SinProfesorException()
        {
            Universidad universidad = new Universidad();
            Profesor profesor = universidad == Universidad.EClases.SPD;
        }



        /// <summary>
        /// Prueba que compueba que las listas de la universidad no sean null
        /// </summary>
        [TestMethod]
        public void TestMetodo4NoNulos()
        {
            Universidad universidad = new Universidad();

            Assert.IsNotNull(universidad.Instructores);
            Assert.IsNotNull(universidad.Alumnos);
            Assert.IsNotNull(universidad.Jornadas);
        }



    }
}
