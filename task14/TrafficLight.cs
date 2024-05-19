using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14
{
    internal class TrafficLight
    {
        public Color LightColor { get; set; }
       

        public TrafficLight(Color color)
        {
            LightColor = color;
        }

        internal enum Color
        {
            Red,
            Yellow,
            Green
        }

        public void ChangeColor()
        {
            switch (LightColor)
            {
                case Color.Red:
                    LightColor = Color.Green;
                    break;
                case Color.Green:
                    LightColor = Color.Yellow;
                    break;
                case Color.Yellow:
                    LightColor = Color.Red;
                    break;
            }
        }
        public Color GetCurrentColor()
        {
            return LightColor;
        }
    }
}
