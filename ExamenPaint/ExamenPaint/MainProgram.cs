using System;
using System.Collections.Generic;
using System.Drawing;

namespace ExamenPaint
{
     public class MainProgram { 
     

          static void Main(string[] args)
          {
               var lienzo = Lienzo.Instance;
               var toolbar = Toolbar.Instance;
               var output = new Output();
               var menu = new Menu(toolbar,output);
               var paint = new Paint(toolbar, lienzo, output, menu);
               paint.Init();
          }
      }
}
