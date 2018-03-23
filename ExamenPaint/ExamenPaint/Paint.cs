using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPaint
{
    /// <summary>
    /// Clase padre de toda la aplicación. Todas las acciones pasan por ser ejecutadas desde aqui.
    /// </summary>
    public class Paint
    {
        public IToolbar Toolbar { get; set; }
        public ILienzo Lienzo { get; set; }
        public IOutput Output { get; set; }
        public IMenu Menu { get; set; }
       
        public Paint(IToolbar toolbar, ILienzo lienzo, IOutput output,IMenu  menu)
        {
            if (null == toolbar)
                throw new ArgumentNullException("toolbar");
            if (null == lienzo)
                throw new ArgumentNullException("lienzo");
            if (null == output)
                throw new ArgumentNullException("output");
            if (null == menu)
                throw new ArgumentNullException("output");

            Menu = menu;
            Toolbar = toolbar;
            Lienzo = lienzo;
            Output = output;
        }

        public void Init()
        {
            int aux;
            do
            {
                Menu.MainMenu();
                aux = int.Parse(Output.Read());
                if (5 >= aux || 0 <= aux)
                {
                    Output.Write("Valor incorrecto, vuelva a introducir un caracter válido");
                }
                else if (1 == aux)
                    Menu.writeDrawMenu();
                else if (2 == aux)
                    Menu.writeFillMenu();
                else if (3 == aux)
                    Menu.writeBorderFillMenu();
            } while (4!=aux);
            Close();
        }

        private void Close()
        {
            Output.Write("Pulse cualquier tecla para cerrar la aplicación");
            Output.ReadKey();

        }
    }
}
