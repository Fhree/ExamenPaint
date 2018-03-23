using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPaint
{
    /// <summary>
    /// Representación de la figura.
    /// </summary>
    public class Figura : IFigura
    {
        public Color BackgroundColor { get ; set ; }
        public Color BorderColor { get ; set ; }

        public Figura(Color backgroundColor, Color borderColor)
        {
            BackgroundColor = backgroundColor;
            BorderColor = borderColor;
        }

        public override string ToString()
        {
            return " con fondo: " + BackgroundColor.Name + " y borde: " + BorderColor.Name; ;
        }
    }
}
