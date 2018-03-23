using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace ExamenPaint
{
    /// <summary>
    /// Representación de la figura Estrella, heredero de Figura.
    /// </summary>
    public class Estrella : Figura
    {
        public Estrella(Color back, Color border) : base(back, border)
        {

        }
        public override string ToString()
        {
            return GetType().Name + base.ToString();
        }
    }
}
