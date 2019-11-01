using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz2
{
    //Se heredan las interfaces a la clase alumno
    public class Alumno:IAlumnos, AlumnoOperaciones
    {
        public string Nombre { get ; set ; }
        public int NoControl { get  ; set ; }
        public string Semestre { get ; set ; }
        public string Turno { get ; set; }
        public double Quimica { get ; set ; }
        public double Español { get ; set ; }
        public double Historia { get ; set ; }

        public void Datos()
        {
            Console.WriteLine("Nombre: "+Nombre);
            Console.WriteLine("NoControl: "+NoControl);
            Console.WriteLine("Semestre: "+Semestre);
            Console.WriteLine("Turno: "+Turno);
            Console.WriteLine("Calificacion en quimica: "+ Quimica);
            Console.WriteLine("Calificacion en español: "+Español);
            Console.WriteLine("Calificacion en historia: "+Historia);
        }

        public double Promedio()
        {
            double A = (Quimica + Español + Historia) / 3;
            Console.WriteLine("Calificacion general: "+A);
            return A;
        }
    }
}
