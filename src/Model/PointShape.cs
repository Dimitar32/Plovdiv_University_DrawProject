using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    [Serializable]
    internal class PointShape : Shape
    {
        #region Constructor

        public PointShape(RectangleF rect) : base(rect)
        {
        }

        public PointShape(Rectangle rectangle) : base(rectangle)
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
            SolidBrush brush = new SolidBrush(FillColor);

            base.DrawSelf(grfx);

            grfx.FillEllipse(brush, Rectangle.X, Rectangle.Y, 8, 8);
            grfx.DrawEllipse(pen, Rectangle.X, Rectangle.Y, 8, 8);
        }
    }
}
