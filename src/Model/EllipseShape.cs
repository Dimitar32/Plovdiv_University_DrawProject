using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw
{
    [Serializable]
    public class EllipseShape : Shape
    {
        #region Constructor

        public EllipseShape(RectangleF rect) : base(rect)
        {
        }

        public EllipseShape(Rectangle rectangle) : base(rectangle)
        {
        }

        #endregion

        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
            {
                float a = Width / 2;
                float b = Height / 2;
                float x = Location.X + a;
                float y = Location.Y + b;

                return (Math.Pow((point.X - x) / a, 2) + Math.Pow((point.Y - y) / b, 2) - 1) <= 0;
            }
            
            return false;
        }

        public override void DrawSelf(Graphics grfx)
        {
            Pen pen = new Pen(BorderColor, BorderWidth);
            SolidBrush brush = new SolidBrush(FillColor);
            
            base.DrawSelf(grfx);

            grfx.FillEllipse(brush, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawEllipse(pen, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
        }
    }
}
