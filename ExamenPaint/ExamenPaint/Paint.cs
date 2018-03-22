using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPaint
{
    public class Paint
    {
        public IToolbar Toolbar { get; set; }
        public ILienzo Lienzo { get; set; }
        
       
        public Paint(IToolbar toolbar, ILienzo lienzo)
        {
            if (null == toolbar)
                throw new ArgumentNullException("toolbar");
            if (null == lienzo)
                throw new ArgumentNullException("lienzo");
            Toolbar = toolbar;
            Lienzo = lienzo;
        }

        public void Init()
        {
            //TODO REALIZAR SUBSCRIPCIONES A TODOS LOS EVENTOS
            
            do
            {
                //TODO 
            } while (true);
            //todo realizar dispose de todo
        }

        //TODO CONTROLAR EVENTO DE SALIDA
      
    }
}
