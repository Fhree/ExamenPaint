using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPaint
{
    /// <summary>
    /// Representación de la sálida.
    /// </summary>
    public class Output : IOutput
    {
        public String Read()
        {
            return Console.ReadLine(); 
        }

        public void Write(String cadena)
        {
            Console.WriteLine(cadena);
        }

        public void ReadKey() {
            Console.ReadKey();
        }

    }
}
