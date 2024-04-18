using System;
using System.Drawing;

namespace Draw
{
    [Serializable]
    public class SquareShape : Shape
    {
        #region Constructor

        public SquareShape(RectangleF rect) : base(rect)
        {
        }

        public SquareShape(Rectangle rectangle) : base(rectangle)
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

            grfx.FillRectangle(brush, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawRectangle(pen, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

        }
    }
}
