using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ExamenPaint
{
    /// <summary>
    /// Factoria de construcción de los herederos de la clase figura.
    /// </summary>
    public class FiguraFactory
    {
        public static Circulo createCirculo(Color backgroundColor, Color borderColor)
        {
            return new Circulo(backgroundColor,borderColor);
        }
        public static Estrella createEstrella(Color backgroundColor, Color borderColor)
        {
            return new Estrella(backgroundColor, borderColor);
        }
        public static Corazon createCorazon(Color backgroundColor, Color borderColor)
        {
            return new Corazon(backgroundColor, borderColor);
        }
        public static Cuadrado createCuadrado(Color backgroundColor, Color borderColor)
        {
            return new Cuadrado(backgroundColor, borderColor);
        }
        public static Rayo createRayo(Color backgroundColor, Color borderColor)
        {
            return new Rayo(backgroundColor, borderColor);
        }
    }
}
