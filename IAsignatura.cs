using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal interface IAsignatura
    {
        public double CalcularNotaFinal();
        public double CalcularNotaFinal(int Nota1, int Nota2, int Nota3);
        public string MensajeNotaFinal(double notaFninal);
        public void Imprimir();
    }
}
