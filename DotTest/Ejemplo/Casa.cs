using System;
using System.Drawing;

namespace ConsoleApplication1
{
    /// <summary> 
    /// Example clase as en example of library usage
    /// </summary>
    
    class Casa
    {
        public Color Color { get; private set; }
        public Casa()
        {
            Color = Color.Black;
        }

        public void Pintar(Color color)
        {
            Color = color;
        }
    }
}
