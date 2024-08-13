using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Asignatura : Alumno, IAsignatura
    {
        public int Nota1;
        public int Nota2;
        public int Nota3;
        public string NombreAsignatura {  get; set; }   
        public string Horario {  get; set; }
        public string NombreDocente {  get; set; }

        public double CalcularNotaFinal()
        {
            return Nota1+Nota2+Nota3;
        }

        public double CalcularNotaFinal(int N1, int N2, int N3)
        {
            return N1 + N2 + N3;
        }

        public void Imprimir()
        {
           
            Console.WriteLine("\n");
            Console.WriteLine("#Datos del Estudiante:");
            Console.WriteLine("\n");
            Console.WriteLine($"Nombre: {NombreAlumno}");
            Console.WriteLine($"Numero de Cuenta: {NumeroCuenta}");
            Console.WriteLine($"Correco Electronico: {Email}");
            Console.WriteLine("\n");
            Console.WriteLine("#Datos de la Aiganatura:");
            Console.WriteLine($"Nombre Asigantura: {NombreAsignatura}");
            Console.WriteLine($"Nombre Docente: {NombreDocente}");
            Console.WriteLine($"Horario: {Horario}");
            Console.WriteLine($"Nota Final: {CalcularNotaFinal()}");
            Console.WriteLine($"Nota Final SM: {CalcularNotaFinal(Nota1, Nota2, Nota3)}");
            Console.WriteLine($"Nota Final SM: {MensajeNotaFinal(CalcularNotaFinal())}");
            Console.WriteLine("\n");
        }

        public string MensajeNotaFinal(double notaFinal)
        {
            string estado;
            estado = "";
            if ((notaFinal >= 0) && (notaFinal <= 59))
            {
                estado = "Bueno";
            } else if ((notaFinal >= 60) && (notaFinal <= 79))
            {
                estado = "Muy Bueno";
            }else if ((notaFinal >= 90) && (notaFinal <= 100))
            {
                estado = "Sobresaliente";
            }
            return estado;
        }
    }
}
