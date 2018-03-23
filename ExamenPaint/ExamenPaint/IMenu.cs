using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPaint
{
    /// <summary>
    /// Interfaz representante del Menu
    /// </summary>
    public interface IMenu
    {
         Dictionary<int, String> MainMenu();
         Dictionary<int, String> DrawMenu();
         Dictionary<int, String> FillMenu();
         Dictionary<int, String> BorderFillMenu();
         IToolbar Toolbar { get; set; }
         IOutput Output { get; set; }

        void writeDrawMenu();
        void writeFillMenu();
        void writeBorderFillMenu();


    }
}
