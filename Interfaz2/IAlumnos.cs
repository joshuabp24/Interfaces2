using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz2
{
    //Creacion de la interface donde se dan los atributos que posteriormente se heredaran a la Clase Alumno
    interface IAlumnos
    {
        string Nombre { get; set; }
        int NoControl { get; set; }
        string Semestre { get; set; }
        string Turno { get; set; }
        double Quimica { get; set; }
        double Español { get; set; }
        double Historia { get; set; }
    }
}
