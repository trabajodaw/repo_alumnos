using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    /// <summary>
    /// <para>Clase que representa boletin de notas de un alumno.</para>
    /// <para>Se puede ver lo siguiente en el boletin: 
    /// <list type="bullet">
    ///     <item>
    ///         <description>Ver nombre de alumno</description>
    ///     </item>
    ///     <item>
    ///         <description>Ver nota de alumno</description>
    ///     </item>
    ///     <item>
    ///         <description>Ver si esta aprobado</description>
    ///     </item>
    /// </list>
    /// </para>
    /// </summary>
    class Alumno
    {
        /// <summary>
        /// Nombre del alumno, almacenado en un string.
        /// </summary>
        private string nombre;

        /// <summary>
        /// Nota que tendra el usuario, expresado en entero.
        /// </summary>
        private int nota;

        /// <summary>
        /// Devuelve el nombre que tendra el alumno.
        /// </summary>
        /// <value>Nombre del alumno</value>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /// <summary>
        /// Devuelve la nota si esta entre 0 y 10.
        /// </summary>
        /// <remarks>Recordad que la nota debe estar entre 0 y 10</remarks>
        /// <value>Nota del alumno</value>
        public int Nota
        {
            get { return nota; }
            set
            {
                if (value >= 0 && value <= 10)
                    nota = value;
            }
        }

        /// <summary>
        /// Devuelve true o false si el alumno esta aprobado con un 5 o mas.
        /// </summary>
        /// <remarks>La nota debe ser 5 o mayor para que este aprobado</remarks>
        /// <returns>Devuelve True o False dependiendo de la nota.</returns>
        public Boolean Aprobado
        {
            get
            {
                if (nota >= 5)
                    return true;
                else
                    return false;
            }
        }
    }
}
