using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPaint
{/// <summary>
/// TODO DEFINICION DE EVENTOS
/// </summary>
    public interface IToolbar
    {
        IList<Type> CatalogoFiguras { get; set; }
        IList<Color> CatalogoColores { get; set; }
    }
}
