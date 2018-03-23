using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ExamenPaint
{
    /// <summary>
    /// Clase representante de una barra de herramientas.
    /// </summary>
    public class Toolbar : IToolbar
    {
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
            FillCatalogoFiguras();
        }
        
        private void FillCatalogoFiguras()
        {
            CatalogoFiguras = new List<Type>()
            {
                { new Circulo(Color.White,Color.Black).GetType()},
                { new Corazon(Color.White,Color.Black).GetType()},
                { new Cuadrado(Color.White,Color.Black).GetType()},
                { new Rayo(Color.White,Color.Black).GetType()},
                { new Estrella(Color.White,Color.Black).GetType()}
            };
        }

        private void FillCatalogoColores()
        {
            CatalogoColores = new List<Color>
            {
                { Color.White},
                { Color.Black},
                { Color.Red},
                { Color.Yellow}
            };
        }


    }
}
