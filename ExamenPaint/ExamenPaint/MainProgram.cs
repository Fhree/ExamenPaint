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
              var paint = new Paint(toolbar, lienzo);
              paint.Init();
          }
      }
}

