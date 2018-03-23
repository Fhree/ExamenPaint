using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace ExamenPaint
{
    /// <summary>
    /// Representación de la figura Cuadrado, heredero de Figura.
    /// </summary>
    public class Cuadrado : Figura
    {
        public Cuadrado(Color back, Color border) : base(back, border)
        {

        }
        public override string ToString()
        {
            return GetType().Name + base.ToString();
        }
    }
}
