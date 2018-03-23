using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ExamenPaint
{
    /// <summary>
    /// Interface representante de una figura.
    /// </summary>
    public interface IFigura
    {        
        Color BackgroundColor { get; set; }
        Color BorderColor { get; set; }      
    }
}
