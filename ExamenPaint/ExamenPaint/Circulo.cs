using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Reflection;

namespace ExamenPaint
{
    /// <summary>
    /// Representación de la figura Circulo, heredero de Figura.
    /// </summary>
    public class Circulo : Figura
    {

        public Circulo(Color back, Color border) : base(back, border)
        {
            
        }
        public override string ToString()
        {
            return GetType().Name +base.ToString();
        }

    }
}
