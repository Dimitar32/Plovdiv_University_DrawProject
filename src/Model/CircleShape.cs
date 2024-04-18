using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    [Serializable]
    public class CircleShape : Shape
    {


        #region Constructor

        public CircleShape(RectangleF rect) : base(rect)
        {
        }

        public CircleShape(EllipseShape circle) : base(circle)
        {
        }

        #endregion

        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
            {
                float a = Width / 2;
                float b = Height / 2;
                float X1 = Location.X + a;
                float Y1 = Location.Y + b;
                return (Math.Pow((point.X - X1) / a, 2) + Math.Pow((point.Y - Y1) / b, 2) - 1) <= 0;
            }
            else
            {
                return false;
            }
        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            grfx.FillEllipse(new SolidBrush(FillColor), new RectangleF(Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Width));
            grfx.DrawEllipse(new Pen(BorderColor, BorderWidth), new RectangleF(Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Width));
        }
    }
}
