using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ExamenPaint
{
    public class Toolbar : IToolbar
    {
        //TODO implementar EVENTOS
        public IList<Type> CatalogoFiguras { get ; set ; }
        public IList<Color> CatalogoColores { get ; set ; }
        private static Toolbar instance;

        public static Toolbar Instance
        {
            get
            {
                if (instance == null)
                    instance = new Toolbar();

                return instance;
            }
        }

        private Toolbar()
        {
        }
    }
}
