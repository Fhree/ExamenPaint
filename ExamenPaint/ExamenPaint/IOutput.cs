using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPaint
{
    /// <summary>
    /// Interfaz representante del Output (nuestra vista).
    /// </summary>
    public interface IOutput
    {
        void Write(String cadena);
        String Read();
        void ReadKey();
    }
}
