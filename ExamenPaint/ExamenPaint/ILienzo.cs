using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ExamenPaint
{
    public interface ILienzo
    {
        IList<IFigura> FigurasDibujadas { get; set; }
        IOutput Output { get; set; }

        void DrawFigura(IFigura figura);
        void ColorearFigura(int index, Color color);
        void ColorearBordeFigura(int index, Color color);
    }
}
