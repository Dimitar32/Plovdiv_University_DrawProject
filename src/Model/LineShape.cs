using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw
{
    [Serializable]
    public class LineShape : Shape
    {
        #region Constructor
         
        public LineShape(RectangleF rect) : base(rect)
        {
        }

        public LineShape(Rectangle rectangle) : base(rectangle)
        {
        }

        #endregion

        public override bool Contains(PointF point)
        {
            return base.Contains(point);
        }

        public override void DrawSelf(Graphics grfx)
        {
            Pen pen = new Pen(BorderColor, BorderWidth);

            base.DrawSelf(grfx);

            PointF P1 = new PointF(Rectangle.X, Rectangle.Y);
            PointF P2 = new PointF(Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Width);

            grfx.DrawLine(pen, P1, P2);
            grfx.ResetTransform();

        }
    }
}
