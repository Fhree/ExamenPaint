using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPaint
{
    public class Rayo : Figura
    {
        public Rayo(Color back, Color border) : base(back, border)
        {

        }
        public override string ToString()
        {
            return GetType().Name + base.ToString();
        }
    }
}
