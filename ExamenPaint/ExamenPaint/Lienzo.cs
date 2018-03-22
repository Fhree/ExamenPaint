﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ExamenPaint
{
    /// <summary>
    /// Controlador
    /// </summary>
    public class Lienzo : ILienzo
    {
        /* TODO 
         * subscribirse evento del TOOLBAR 
        */

        private static Lienzo instance;
        public IList<IFigura> FigurasDibujadas { get; set; }
        public IOutput Output { get; set; }
        
        public static Lienzo Instance
        {
            get
            {
                if (instance == null)
                    instance = new Lienzo();

                return instance;
            }
        }

        private Lienzo(){
            Output = new Output();
        }

        public void DrawFigura(IFigura figura)
        {
            FigurasDibujadas.Add(figura);
        }

        public void ColorearFigura(int index, Color color)
        {
            FigurasDibujadas[index].BackgroundColor = color;
        }

        public void ColorearBordeFigura(int index, Color color)
        {
            FigurasDibujadas[index].BorderColor = color;
        }
    }
}
