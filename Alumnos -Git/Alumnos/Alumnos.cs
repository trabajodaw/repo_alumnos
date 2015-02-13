using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Alumnos
{
    /// <summary>
    /// <para>Clase que representa una lista de alumnos para sacar la media.</para>
    /// </summary>
    class Alumnos
    {
        /// <summary>
        /// Lista donde se añadiran los alumnos.
        /// </summary>
       private ArrayList lista = new ArrayList();

        /// <summary>
        /// Devuelve la lista donde estaran los alumnos.
        /// </summary>
        /// <value>Lista de alumnos</value>
        public ArrayList listaAlumnos
        {
            get { return lista; }
        }


        /// <summary>
        /// Añade a la lista los alumnos.
        /// </summary>
        /// <param name="alumn">Parametro de la clase Alumno</param>
        public void AgregarAlumno(Alumno alumn)
        {
            lista.Add(alumn);
        }

        /// <summary>
        ///<para>Recorre la lista añadiendo a la variable media las notas de los alumnos y dependiendo si la lista esta vacia o no
        /// hace la media dividiendo la suma de las notas por la cantidad de alumnos que hay en la lista.</para> 
        /// </summary>
        /// <returns>Devuelve la media de la lista</returns>
        public double MediaNotas()
        {
            Alumno alumno;
            double media = 0;
            int i;


            for (i = 0; i < lista.Count; i++)
            {
                alumno = (Alumno)lista[i];
                media = media + alumno.Nota;

            }


            if (lista.Count == 0)
            {
                media = 0;
            }

            else
            {
                media = media / lista.Count;
            }


            return media;
        }
        public int contador()
        {
            int res = 0;

            res = lista.Count;


            return res;
        }
    }
}
