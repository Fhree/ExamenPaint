using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPaint
{
    /// <summary>
    /// Clase donde se almacenan los menus de la aplicación.
    /// </summary>
    public class Menu : IMenu
    {
        private Dictionary<int, String> MainMenu;
        private Dictionary<int, String> DrawMenu;
        private Dictionary<int, String> FillMenu;
        private Dictionary<int, String> BorderFillMenu;
        public IToolbar Toolbar { get; set; }
        public IOutput Output { get; set; }
        

        public Menu(Toolbar toolbar,Output output)
        {
            if (null == toolbar)
                throw new ArgumentNullException("toolbar");
            if (null == output)
                throw new ArgumentNullException("output");
            Output = output;
            Toolbar = toolbar;
            createMainMenu();
            createFillAndBorderFillMenu();
            createDrawMenu();

        }

        private void createMainMenu()
        {
            MainMenu = new Dictionary<int, string>()
            {
                { 1,"1 - Dibujar una figura"},
                { 2,"2 - Cambiar color del fondo de una figura"},
                { 3,"3 - Cambiar color del borde de una figura"},
                { 4,"4 - Salir"},
            };

        }

        private void createDrawMenu() {
            DrawMenu = new Dictionary<int, string>();
            var catFig = Toolbar.CatalogoFiguras;
            for (int i = 0; i < catFig.Count;i++)
            {
                var sb = new StringBuilder().Append(i + 1).Append(" - ").Append(catFig[i].Name);
                DrawMenu.Add((i + 1), sb.ToString());
            }
            
        }
        private void createFillAndBorderFillMenu() {
            DrawMenu = new Dictionary<int, string>();
            var catCol = Toolbar.CatalogoColores;
            for (int i = 0; i < catCol.Count; i++)
            {
                var sb = new StringBuilder().Append(i + 1).Append(" - ").Append(catCol[i].Name);
                FillMenu.Add(i + 1, sb.ToString());
                BorderFillMenu.Add(i + 1, sb.ToString());
            }
        }
          
        public void writeMainMenu() {
            foreach (var item in MainMenu)
            {
                Output.Write(item.Value);
            }
        }

        public void writeDrawMenu()
        {
            foreach (var item in DrawMenu)
            {
                Output.Write(item.Value);
            }
        }

        public void writeFillMenu()
        {
            foreach (var item in MainMenu)
            {
                Output.Write(item.Value);
            }
        }

        public void writeBorderFillMenu()
        {
            foreach (var item in MainMenu)
            {
                Output.Write(item.Value);
            }
        }

        Dictionary<int, string> IMenu.MainMenu()
        {
            throw new NotImplementedException();
        }

        Dictionary<int, string> IMenu.DrawMenu()
        {
            throw new NotImplementedException();
        }

        Dictionary<int, string> IMenu.FillMenu()
        {
            throw new NotImplementedException();
        }

        Dictionary<int, string> IMenu.BorderFillMenu()
        {
            throw new NotImplementedException();
        }
    }
}
