using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz2
{
    public class Principal
    {
        //Instanciacion de la clase Alumno
        Alumno A = new Alumno();
        public void Bienvenida()
        {
            Console.WriteLine("-----PROGRAMA-----");
            Creacion();
        }
        //Metodo donde creo el objeto
        public void Creacion()
        {
            A.Nombre = "Joshua";
            A.NoControl = 12345678;
            A.Semestre = "Primero";
            A.Turno = "Matutino";
            A.Quimica = 8;
            A.Español = 10;
            A.Historia = 7;
            
            Procedimiento(A);
        }
        public void Procedimiento(Alumno A)
        {
           //En este metodo se mandan a llamar los metodos de la clase Alumno enviandole el objeto
            A.Datos();
            Console.WriteLine();
            A.Promedio();
            Console.ReadKey();
        }
    }
}
