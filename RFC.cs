using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejer11
{
    public class RFC
    {
        public DateTime FechaDeNacimiento { get; set; }
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }

        public RFC(DateTime date, string name, string lastName1, string lastName2) 
        {
            FechaDeNacimiento = date;
            Nombre = name;
            ApPaterno = lastName1;
            ApMaterno = lastName2;
        }

        public RFC() 
        {

        }
        /// <summary>
        /// Normas generales para la construcción del RFC
        ///  La letra inicial y la primera vocal interna del primer apellido, 
        ///  la letra inicial del segundo apellido y 
        /// la primera letra del nombre. 
        /// En el caso de las mujeres casadas, se deberán usar los apellidos de soltera. 
        /// La fecha de nacimiento en el orden de año mes y día.
        /// </summary>
        /// <returns></returns>
        public string ObtenerRFC()
        {
            return ApPaterno.ToUpper().Substring(0, 1)
                + (ObtenerPrimeraVocal(ApPaterno.ToUpper())) 
                + ApMaterno.ToUpper().Substring(0, 1) 
                + Nombre.ToUpper().Substring(0, 1) 
                + FechaDeNacimiento.Year.ToString("d").Substring(2,2)
                + (FechaDeNacimiento.Month < 10 
                    ? "0" + FechaDeNacimiento.Month.ToString("d") 
                    : FechaDeNacimiento.Month.ToString("d"))
                + FechaDeNacimiento.Date.ToString("dd");
        }
        private string ObtenerPrimeraVocal(string v)
        {
            var resultado = "";
            for (var i = 1; i < v.Length; i++)
            {
                if (v.Substring(i, 1) == "A"
                || v.Substring(i, 1) == "E"
                || v.Substring(i, 1) == "I"
                || v.Substring(i, 1) == "O"
                || v.Substring(i, 1) == "U") {
                    resultado = v.Substring(i, 1);
                    break;
                }

            }
            return resultado;
        }
    }
}