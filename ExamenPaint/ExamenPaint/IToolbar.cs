using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPaint
{
    /// <summary>
    /// Interfaz representante de la barra de herramientas.
    /// </summary>
    public interface IToolbar
    {
        IList<Type> CatalogoFiguras { get; set; }
        IList<Color> CatalogoColores { get; set; }
    }
}
